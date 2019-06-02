using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academy.Forms;
using Academy.Models;

namespace Academy
{
    public partial class AboutAcademy : Form
    {
        public AboutAcademy()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateAcademyName addAcademiInfo = new UpdateAcademyName();
            addAcademiInfo.ShowDialog();
        }

        private void AboutAcademy_Load(object sender, EventArgs e)
        {
            using (MyAcademyEntities db = new MyAcademyEntities())
            {
                Academy_info academy_Info = db.Academy_info.FirstOrDefault();
                academyNameLabel.Text = academy_Info.Name_academy;
                textPhone.Text = academy_Info.phone_academy;
                textEmail.Text = academy_Info.email_academy;
                textAdress.Text = academy_Info.Adress_academy;
                this.academyNameLabel.Left = (this.Width - this.academyNameLabel.Width) / 2;
            }
        }

    }
}
