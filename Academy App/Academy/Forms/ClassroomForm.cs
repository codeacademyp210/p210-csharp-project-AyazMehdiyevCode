using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academy.Models;
using Academy.Classes;
using Academy.Forms;

namespace Academy.Forms
{
    public partial class ClassroomForm : Form
    {
        public ClassroomForm()
        {
            InitializeComponent();
        }
        int SelectedID;
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (Create())
            {
                FillDataGrid();
                ClearTextBoxs();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateData())
            {
                FillDataGrid();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Delete())
            {
                FillDataGrid();
                ClearTextBoxs();
                ChangeBtnToFalse();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxs();
            ChangeBtnToFalse();
        }

        private void ClassroomForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dataGrid.Rows.Clear();
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                List<Classroom> classrooms = db.Classrooms.ToList();
                foreach (var item in classrooms)
                {
                    if (item.Status_room == true)
                    {
                        dataGrid.Rows.Add(
                         item.ID_room,
                         item.Name_room,
                         item.Capacity,
                         item.Status_room
                         );
                    }
                }
            }
        }
        private void ClearTextBoxs()
        {
            textBoxName.Text = "";
            textBoxCapacity.Text = "";

        }
        private bool Create()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Classroom Newdata = new Classroom();

                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    Newdata.Name_room = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.isInt(textBoxCapacity.Text))
                {
                    Newdata.Capacity = Convert.ToInt32(GoCheck.ClearValue);
                    Newdata.Status_room = true;
                }
                else { return false; }
                db.Classrooms.Add(Newdata);
                return GoCheck.isSave(db.SaveChanges());
            }
        }
        private void ChangeBtnToTrue()
        {
            this.btnDelete.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.btnCreate.Enabled = false;
        }
        private void ChangeBtnToFalse()
        {
            this.btnDelete.Enabled = false;
            this.btnUpdate.Enabled = false;
            this.btnCreate.Enabled = true;
        }
        private bool UpdateData()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Classroom UpdatedData = db.Classrooms.Where(x => x.ID_room == SelectedID).FirstOrDefault();
                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    UpdatedData.Name_room = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.isInt(textBoxCapacity.Text))
                {
                    UpdatedData.Capacity = Convert.ToInt32(GoCheck.ClearValue);
                }
                else { return false; }

                return GoCheck.isSave(db.SaveChanges());

            }
        }
        private bool Delete()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Classroom DeletedData = db.Classrooms.Where(x => x.ID_room == SelectedID).FirstOrDefault();
                string Dialog = "Seçilmiş " + DeletedData.Name_room + " otağını silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!", MessageBoxButtons.YesNo);
                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + DeletedData.Name_room + " otağı Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    DeletedData.Status_room = false;
                    return GoCheck.isDeleted(db.SaveChanges());
                }
            }
        }

        private void DataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRowID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                SelectedID = db.Classrooms.Where(x => x.ID_room == SelectedRowID).FirstOrDefault().ID_room;
                textBoxName.Text = db.Classrooms.Where(x => x.ID_room == SelectedID).FirstOrDefault().Name_room;
                textBoxCapacity.Text = db.Classrooms.Where(x => x.ID_room == SelectedID).FirstOrDefault().Capacity.ToString();

            }
            ChangeBtnToTrue();
        }
    }
}
