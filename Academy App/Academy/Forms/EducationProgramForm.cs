using Academy.Classes;
using Academy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Forms
{
    public partial class EducationProgramForm : Form
    {
        public EducationProgramForm()
        {
            InitializeComponent();
        }
        int SelectedID;
        private void EducationProgramForm_Load(object sender, EventArgs e)
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

        private void DataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRowID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                SelectedID = db.Education_Program.Where(x => x.ID_edu == SelectedRowID).FirstOrDefault().ID_edu;
                textBoxName.Text = db.Education_Program.Where(x => x.ID_edu == SelectedID).FirstOrDefault().Name_edu;
                textBoxPrice.Text = db.Education_Program.Where(x => x.ID_edu == SelectedID).FirstOrDefault().Price.ToString();

            }
            ChangeBtnToTrue();
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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ClearTextBoxs()
        {
            textBoxName.Text = "";
            textBoxPrice.Text = "";

        }
        private void FillDataGrid()
        {
            dataGrid.Rows.Clear();
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                List<Education_Program> classrooms = db.Education_Program.ToList();
                foreach (var item in classrooms)
                {
                    if (item.Status_edu == true)
                    {
                        dataGrid.Rows.Add(
                         item.ID_edu,
                         item.Name_edu,
                         item.Price,
                         item.Status_edu
                         );
                    }
                }
            }
        }
        private bool Create()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Education_Program Newdata = new Education_Program();

                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    Newdata.Name_edu = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.isPrice(textBoxPrice.Text))
                {
                    Newdata.Price = Convert.ToDecimal(GoCheck.ClearValue);
                    Newdata.Status_edu = true;
                }
                else { return false; }
                db.Education_Program.Add(Newdata);
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
                Education_Program UpdatedData = db.Education_Program.Where(x => x.ID_edu == SelectedID).FirstOrDefault();
                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    UpdatedData.Name_edu = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.isPrice(textBoxPrice.Text))
                {
                    UpdatedData.Price = Convert.ToDecimal(GoCheck.ClearValue);
                }
                else { return false; }

                return GoCheck.isSave(db.SaveChanges());

            }
        }
        private bool Delete()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Education_Program DeletedData = db.Education_Program.Where(x => x.ID_edu == SelectedID).FirstOrDefault();
                string Dialog = "Seçilmiş " + DeletedData.Name_edu + " təhsil proqramını silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!", MessageBoxButtons.YesNo);
                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + DeletedData.Name_edu + " təhsil proqramı Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    DeletedData.Status_edu = false;
                    return GoCheck.isDeleted(db.SaveChanges());
                }
            }
        }

    }
}
