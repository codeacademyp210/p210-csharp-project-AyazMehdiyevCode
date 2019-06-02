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
    public partial class EmlploeeForm : Form
    {
        public EmlploeeForm()
        {
            InitializeComponent();
        }
        int SelectedID;
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmlploeeForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillComboPosition();
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
                ClearTextBoxs();
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

        private void DataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRowID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                SelectedID = db.Employees.Where(x => x.ID_emp == SelectedRowID).FirstOrDefault().ID_emp;
                textBoxName.Text = db.Employees.Where(x => x.ID_emp == SelectedID).FirstOrDefault().Name_emp;
                textBoxSurname.Text = db.Employees.Where(x => x.ID_emp == SelectedID).FirstOrDefault().Surname_emp;
                textBoxPhone.Text = db.Employees.Where(x => x.ID_emp == SelectedID).FirstOrDefault().Phone_emp;
                textBoxEmail.Text = db.Employees.Where(x => x.ID_emp == SelectedID).FirstOrDefault().Email_emp;
                comboBoxPosition.SelectedIndex = db.Positions.Where(x => x.Status_pos == true).ToList().FindIndex(x=> x.ID_pos == db.Employees.Where(y => y.ID_emp == SelectedID).FirstOrDefault().PositionID);
                textBoxSpeciality.Text = db.Employees.Where(x => x.ID_emp == SelectedID).FirstOrDefault().Speciality_emp;
                textBoxSalary.Text = db.Employees.Where(x => x.ID_emp == SelectedID).FirstOrDefault().Salary.ToString();
                dateTimeStartTime.Value = db.Employees.Where(x => x.ID_emp == SelectedID).FirstOrDefault().StartTime;
            }
            ChangeBtnToTrue();
        }
        private void ClearTextBoxs()
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            comboBoxPosition.SelectedItem = null;
            textBoxSpeciality.Text = "";
            textBoxSalary.Text = "";
            dateTimeStartTime.Value = DateTime.Today;
        }
        private void FillDataGrid()
        {
            dataGrid.Rows.Clear();
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                List<Employee> classrooms = db.Employees.ToList();
                foreach (var item in classrooms)
                {
                    if (item.Status_emp == true)
                    {
                        dataGrid.Rows.Add(
                         item.ID_emp,
                         item.Name_emp,
                         item.Surname_emp,
                         item.Phone_emp,
                         item.Email_emp,
                         db.Positions.Where(x=> x.ID_pos==item.PositionID).FirstOrDefault().Name_pos,
                         item.Speciality_emp,
                         item.Salary,
                         item.StartTime.ToShortDateString(),
                         item.Status_emp
                         );
                    }
                }
            }
        }
        private bool Create()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Employee Newdata = new Employee();

                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    Newdata.Name_emp = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.IsEmpityOrMaxChar(textBoxSurname.Text) && GoCheck.IsStringValue(textBoxSurname.Text))
                {
                    Newdata.Surname_emp = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.IsPhoneValue(textBoxPhone.Text))
                {
                    Newdata.Phone_emp = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.IsEmailValue(textBoxEmail.Text))
                {
                    Newdata.Email_emp = GoCheck.ClearValue;
                }
                else { return false; }
                if (!(comboBoxPosition.SelectedItem == null))
                {
                    Newdata.PositionID = db.Positions.Where(x => x.Status_pos == true).ToList()[comboBoxPosition.SelectedIndex].ID_pos;
                }
                else {
                    MessageBox.Show("Vəzifə seçin","Diqqət!");
                    return false; }
                if (GoCheck.IsEmpityOrMaxChar(textBoxSpeciality.Text) && GoCheck.IsStringValue(textBoxSpeciality.Text))
                {
                    Newdata.Speciality_emp = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.isPrice(textBoxSalary.Text))
                {
                    Newdata.Salary = Convert.ToDecimal(textBoxSalary.Text);
                    Newdata.StartTime = dateTimeStartTime.Value;
                    Newdata.Status_emp = true;
                }
                else { return false; }

                db.Employees.Add(Newdata);
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
                Employee UpdatedData = db.Employees.Where(x => x.ID_emp == SelectedID).FirstOrDefault();
                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    UpdatedData.Name_emp = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.IsEmpityOrMaxChar(textBoxSurname.Text) && GoCheck.IsStringValue(textBoxSurname.Text))
                {
                    UpdatedData.Surname_emp = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.IsPhoneValue(textBoxPhone.Text))
                {
                    UpdatedData.Phone_emp = GoCheck.ClearValue;
                }
                else { return false; }
                if (GoCheck.IsEmailValue(textBoxEmail.Text))
                {
                    UpdatedData.Email_emp = GoCheck.ClearValue;
                }
                else { return false; }
                if (!(comboBoxPosition.SelectedItem == null))
                {
                    UpdatedData.PositionID = db.Positions.Where(x => x.Status_pos == true).ToList()[comboBoxPosition.SelectedIndex].ID_pos;
                }
                else
                {
                    MessageBox.Show("Vəzifə seçin", "Diqqət!");
                    return false;
                }
                if (GoCheck.isPrice(textBoxSalary.Text))
                {
                    UpdatedData.Salary = Convert.ToDecimal(GoCheck.ClearValue);
                    UpdatedData.StartTime = dateTimeStartTime.Value;
                    UpdatedData.Status_emp = true;
                }
                else { return false; }
                if (GoCheck.IsEmpityOrMaxChar(textBoxSpeciality.Text) && GoCheck.IsStringValue(textBoxSpeciality.Text))
                {
                    UpdatedData.Speciality_emp = GoCheck.ClearValue;
                }
                else { return false; }
                return GoCheck.isSave(db.SaveChanges());

            }
        }
        private bool Delete()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Employee DeletedData = db.Employees.Where(x => x.ID_emp == SelectedID).FirstOrDefault();
                string Dialog = "Seçilmiş " + DeletedData.Name_emp + " işçisini silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!", MessageBoxButtons.YesNo);
                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + DeletedData.Name_emp + " işçi Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    DeletedData.Status_emp = false;
                    return GoCheck.isDeleted(db.SaveChanges());
                }
            }
        }
        private void FillComboPosition()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                comboBoxPosition.DataSource = db.Positions.Where(x => x.Status_pos == true).Select(x => x.Name_pos).ToList();
            }
        }

        private void EmlploeeForm_Activated(object sender, EventArgs e)
        {
            FillComboPosition();
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            PositionForm positionForm = new PositionForm();
            positionForm.ShowDialog();
        }
    }
}
