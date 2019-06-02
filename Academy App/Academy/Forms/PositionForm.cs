using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academy.Classes;
using Academy.Forms;
using Academy.Models;

namespace Academy.Forms
{
    public partial class PositionForm : Form
    {
        
        public PositionForm()
        {
            InitializeComponent();
        }
        int SelectedID;
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PositionForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxs();
            ChangeBtnToFalse();

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
        private void FillDataGrid()
        {
            dataGrid.Rows.Clear();
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                List<Position> position = db.Positions.ToList();
                foreach (var item in position)
                {
                    if (item.Status_pos == true)
                    {
                        dataGrid.Rows.Add(
                         item.ID_pos,
                         item.Name_pos,
                         item.Status_pos
                         );
                    }

                }
            }
        }
        private bool Create()
        {

            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Position Newdata = new Position();

                if (GoCheck.IsEmpityOrMaxChar(textBoxPositionName.Text) && GoCheck.IsStringValue(textBoxPositionName.Text))
                {
                    Newdata.Name_pos = GoCheck.ClearValue;
                    Newdata.Status_pos = true;
                }
                else { return false; }

                db.Positions.Add(Newdata);
                return GoCheck.isSave(db.SaveChanges());
            }
        }
        private bool UpdateData()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Position UpdatedData = db.Positions.Where(x => x.ID_pos == SelectedID).FirstOrDefault();
                if (GoCheck.IsEmpityOrMaxChar(textBoxPositionName.Text) && GoCheck.IsStringValue(textBoxPositionName.Text))
                {
                    UpdatedData.Name_pos = GoCheck.ClearValue;
                }
                else { return false; }

                return GoCheck.isSave(db.SaveChanges());

            }
        }
        private bool Delete()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Position DeletedData = db.Positions.Where(x => x.ID_pos == SelectedID).FirstOrDefault();
                string Dialog = "Seçilmiş " + DeletedData.Name_pos + " vəzifəsini silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!", MessageBoxButtons.YesNo);
                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + DeletedData.Name_pos + " vəzifəsi Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    DeletedData.Status_pos = false;
                    return GoCheck.isDeleted(db.SaveChanges());
                }
            }
        }
        private void ClearTextBoxs()
        {
            textBoxPositionName.Text = "";
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

        private void DataGrid_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRowID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                SelectedID = db.Positions.Where(x => x.ID_pos == SelectedRowID).FirstOrDefault().ID_pos;
                textBoxPositionName.Text = db.Positions.Where(x => x.ID_pos == SelectedID).FirstOrDefault().Name_pos;
            }
            ChangeBtnToTrue();
        }
    }
}
