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
using Academy.Models;
using Academy.Forms;


namespace Academy
{
    public partial class MyAcademyApp : Form
    {
        public MyAcademyApp()
        {
            InitializeComponent();
        }

        private void MyAcademyApp_Load(object sender, EventArgs e)
        {
            AcademiInfo.AddInfo();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStundent_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmloyee_Click(object sender, EventArgs e)
        {
            EmlploeeForm emlploeeForm = new EmlploeeForm();
            emlploeeForm.ShowDialog();
        }

        private void BtnGroup_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
        }

        private void BtnTask_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AboutAcademy aboutAcademy = new AboutAcademy();
            aboutAcademy.ShowDialog();
        }

        private void MyAcademyApp_Activated(object sender, EventArgs e)
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                app_name.Text = db.Academy_info.FirstOrDefault().Name_academy;
            }
        }
    }
}
