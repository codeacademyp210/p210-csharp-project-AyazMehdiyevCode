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
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int SelectedID;
        private void BtnClassroom_Click(object sender, EventArgs e)
        {
            ClassroomForm classroomForm = new ClassroomForm();
            classroomForm.ShowDialog();
        }

        private void BtnEducation_Click(object sender, EventArgs e)
        {
            EducationProgramForm educationProgramForm = new EducationProgramForm();
            educationProgramForm.ShowDialog();
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            FillCombo();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (Create())
            {
                FillDataGrid();
                ClearTextBoxs();
                FillCombo();
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

        private void DataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRowID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value);
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                SelectedID = db.Groups.Where(x => x.ID_group == SelectedRowID).FirstOrDefault().ID_group;
                textBoxName.Text = db.Groups.Where(x => x.ID_group == SelectedID).FirstOrDefault().Name_group;
                comboBoxClass.SelectedIndex = db.Classrooms.Where(x => x.Status_room == true).ToList().FindIndex(x => x.ID_room == db.Groups.Where(y => y.ID_group == SelectedID).FirstOrDefault().ClassroomID);
                comboBoxEdu.SelectedIndex = db.Education_Program.Where(x => x.Status_edu == true).ToList().FindIndex(x => x.ID_edu == db.Groups.Where(y => y.ID_group == SelectedID).FirstOrDefault().EducationID);
            }
            ChangeBtnToTrue();
        }
        private void ClearTextBoxs()
        {
            textBoxName.Text = "";
            comboBoxClass.SelectedItem = null;
            comboBoxEdu.SelectedItem = null;
        }
        private void FillDataGrid()
        {
            dataGrid.Rows.Clear();
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                List<Group> classrooms = db.Groups.ToList();
                foreach (var item in classrooms)
                {
                    if (item.Status_group == true)
                    {
                        dataGrid.Rows.Add(
                         item.ID_group,
                         item.Name_group,
                         db.Classrooms.Where(x => x.ID_room == item.ClassroomID).FirstOrDefault().Name_room,
                         db.Education_Program.Where(x => x.ID_edu == item.EducationID).FirstOrDefault().Name_edu,
                         db.Classrooms.Where(x => x.ID_room == item.ClassroomID).FirstOrDefault().Capacity,
                         item.Status_group
                         );
                    }
                }
            }
        }
        private bool Create()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Group Newdata = new Group();

                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    Newdata.Name_group = GoCheck.ClearValue;
                }
                else { return false; }
                if (!(comboBoxClass.SelectedItem == null))
                {
                    Newdata.ClassroomID = db.Classrooms.Where(x => x.Status_room == true).ToList()[comboBoxClass.SelectedIndex].ID_room;
                }
                else
                {
                    MessageBox.Show("Otaq seçin", "Diqqət!");
                    return false;
                }
                if (!(comboBoxEdu.SelectedItem == null))
                {
                    Newdata.EducationID = db.Education_Program.Where(x => x.Status_edu == true).ToList()[comboBoxEdu.SelectedIndex].ID_edu;
                    Newdata.Status_group = true;
                }
                else
                {
                    MessageBox.Show("Təhsil seçin", "Diqqət!");
                    return false;
                }
                db.Groups.Add(Newdata);
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
                Group UpdatedData = db.Groups.Where(x => x.ID_group == SelectedID).FirstOrDefault();
                if (GoCheck.IsEmpityOrMaxChar(textBoxName.Text) && GoCheck.IsStringValue(textBoxName.Text))
                {
                    UpdatedData.Name_group = GoCheck.ClearValue;
                }
                else { return false; }
                if (!(comboBoxClass.SelectedItem == null))
                {
                    UpdatedData.ClassroomID = db.Classrooms.Where(x => x.Status_room == true).ToList()[comboBoxClass.SelectedIndex].ID_room;
                }
                else
                {
                    MessageBox.Show("Otaq seçin", "Diqqət!");
                    return false;
                }
                if (!(comboBoxEdu.SelectedItem == null))
                {
                    UpdatedData.EducationID = db.Education_Program.Where(x => x.Status_edu == true).ToList()[comboBoxEdu.SelectedIndex].ID_edu;
                    UpdatedData.Status_group = true;
                }
                else
                {
                    MessageBox.Show("Təhsil seçin", "Diqqət!");
                    return false;
                }
                return GoCheck.isSave(db.SaveChanges());
                
            }
            
        }
        private bool Delete()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Group DeletedData = db.Groups.Where(x => x.ID_group == SelectedID).FirstOrDefault();
                string Dialog = "Seçilmiş " + DeletedData.Name_group + " grupunu silmək istəyirsiniz?";
                DialogResult result = MessageBox.Show(Dialog, "Silmək Sorğusu!", MessageBoxButtons.YesNo);
                if (DialogResult.Yes != result)
                {
                    MessageBox.Show("Seçilmiş " + DeletedData.Name_group + " grupu Silinmədi.", "Silmək Sorğusuna cavab");
                    return false;
                }
                else
                {
                    DeletedData.Status_group = false;
                    return GoCheck.isDeleted(db.SaveChanges());
                }
            }
        }
        private void FillCombo()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                comboBoxClass.DataSource = db.Classrooms.Where(x => x.Status_room == true).Select(x => x.Name_room).ToList();
                comboBoxEdu.DataSource = db.Education_Program.Where(x => x.Status_edu == true).Select(x => x.Name_edu).ToList();

            }
        }

        private void GroupForm_Activated(object sender, EventArgs e)
        {
            FillCombo();
        }
    }
}
