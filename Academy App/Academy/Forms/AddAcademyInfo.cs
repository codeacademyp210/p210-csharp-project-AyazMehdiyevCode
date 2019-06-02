using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Academy.Classes;
using Academy.Models;

namespace Academy.Forms
{
    public partial class AddAcademyInfo : Form
    {
        public AddAcademyInfo()
        {
            InitializeComponent();
    }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void BtnCreateAcademy_Click(object sender, EventArgs e)
        {
            if (CreateAcademyInfo())
            {
                string AcPath = Directory.GetCurrentDirectory() + @"\Academy.txt";
                File.Create(AcPath);
                this.Close();
                AboutAcademy aboutAcademy = new AboutAcademy();
                aboutAcademy.ShowDialog();
            }
        }
        public bool CreateAcademyInfo()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Academy_info Ai = new Academy_info();

                if (GoCheck.IsEmpityOrMaxChar(textBoxAcademyName.Text) && GoCheck.IsStringValue(textBoxAcademyName.Text))
                {
                    Ai.Name_academy = textBoxAcademyName.Text;
                }
                else { return false; }
                if (GoCheck.IsEmpityOrMaxChar(textBoxAcademyPhone.Text) && GoCheck.IsPhoneValue(textBoxAcademyPhone.Text))
                {
                    Ai.phone_academy = textBoxAcademyPhone.Text;
                }
                else { return false; }
                if (GoCheck.IsEmpityOrMaxChar(textBoxAcademyEmail.Text) && GoCheck.IsEmailValue(textBoxAcademyEmail.Text))
                {
                    Ai.email_academy = textBoxAcademyEmail.Text;
                }
                else { return false; }
                if (GoCheck.IsEmpityOrMaxChar(textBoxAcademyAdress.Text, 150))
                {
                    Ai.Adress_academy = textBoxAcademyAdress.Text;
                    Ai.Status_academy = true;
                }
                else { return false; }

                db.Academy_info.Add(Ai);
                return GoCheck.isSave(db.SaveChanges());
            }
        }
    }
}
