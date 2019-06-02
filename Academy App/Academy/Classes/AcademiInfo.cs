using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academy.Classes;
using Academy.Forms;
using Academy.Models;
using System.IO;

namespace Academy.Classes
{
    public static class AcademiInfo
    {

        public static void AddInfo()
        {
            // Proqram işə düşdükdə bir dəfə sizdən Academy haqqında məlumatı soruşacaq.
            // bunu tənzimləmək üçün sizin kompda bir səfərlik boş fayl yaradıram.
            // faylı silib yenidən yoxlamaq üçün aşağıdakı sətri commentdən çıxarın və faylın yerini görün.
            // MessageBox.Show(Directory.GetCurrentDirectory());
            string AcPath = Directory.GetCurrentDirectory() + @"\Academy.txt";
            if (!File.Exists(AcPath))
            {
                AddAcademyInfo addAcademiInfo = new AddAcademyInfo();
                addAcademiInfo.ShowDialog();
            }
        }
    }
}
