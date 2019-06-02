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
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }
        int SelectedID;
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void DataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRowID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                SelectedID = db.Tasks.Where(x => x.ID_task == SelectedRowID).FirstOrDefault().ID_task;
                textBoxName.Text = db.Tasks.Where(x => x.ID_task == SelectedID).FirstOrDefault().Name_task;
                dateTimeDeadline.Value = db.Tasks.Where(x => x.ID_task == SelectedID).FirstOrDefault().DeadLine;
            }
            ChangeBtnToTrue();
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
        private void ClearTextBoxs()
        {
            textBoxName.Text = "";
            dateTimeDeadline.Value = DateTime.Today;

        }
        private void FillDataGrid()
        {
            dataGrid.Rows.Clear();
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                List<Models.Task> classrooms = db.Tasks.ToList();
                foreach (var item in classrooms)
                {
                    if (item.Status_task == true)
                    {
                        dataGrid.Rows.Add(
                         item.ID_task,
                         item.Name_task,
                         item.DeadLine.ToShortDateString(),
                         item.Status_task
                         );
                    }
                }
            }
        }
        private bool Create()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Models.Task Newdata = new Models.Task();

                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    Newdata.Name_task = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.isDate(dateTimeDeadline.Value))
                {
                    Newdata.DeadLine = dateTimeDeadline.Value;
                    Newdata.Status_task = true;
                }
                else { return false; }
                db.Tasks.Add(Newdata);
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
                Models.Task UpdatedData = db.Tasks.Where(x => x.ID_task == SelectedID).FirstOrDefault();
                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    UpdatedData.Name_task = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.isDate(dateTimeDeadline.Value))
                {
                    UpdatedData.DeadLine = dateTimeDeadline.Value;
                }
                else { return false; }

                return GoCheck.isSave(db.SaveChanges());

            }
        }
        private bool Delete()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Models.Task DeletedData = db.Tasks.Where(x => x.ID_task == SelectedID).FirstOrDefault();
                string Dialog = "Seçilmiş " + DeletedData.Name_task + " tapşırığı silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!", MessageBoxButtons.YesNo);
                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + DeletedData.Name_task + " tapşırıq Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    DeletedData.Status_task = false;
                    return GoCheck.isDeleted(db.SaveChanges());
                }
            }
        }
    }
}
