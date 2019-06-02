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

namespace Academy.Forms
{
    public partial class UpdateAcademyName : Form
    {
        public UpdateAcademyName()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdateAcademy_Click(object sender, EventArgs e)
        {
            if (UpdateAcademyInfo())
            {
                FillTextBoxs();
            }
        }
        public void FillTextBoxs()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Academy_info Ai = db.Academy_info.FirstOrDefault();
                textBoxAcademyİnfo.Text = Ai.Name_academy;
                textBoxAcademyPhone.Text = Ai.phone_academy;
                textBoxAcademyEmail.Text = Ai.email_academy;
                textBoxAcademyAdress.Text = Ai.Adress_academy;
            }
        }
        public bool UpdateAcademyInfo()
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Academy_info Ai = db.Academy_info.FirstOrDefault();

                if (GoCheck.IsEmpityOrMaxChar(textBoxAcademyİnfo.Text) && GoCheck.IsStringValue(textBoxAcademyİnfo.Text))
                {
                    Ai.Name_academy = textBoxAcademyİnfo.Text;
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

                return GoCheck.isSave(db.SaveChanges());
            }
        }

        private void UpdateAcademyName_Load(object sender, EventArgs e)
        {
            FillTextBoxs();
        }
    }
}
