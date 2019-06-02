using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Academy.Classes
{
    public static class GoCheck
    {
        public static string ClearValue {get;set;}
        public static bool IsEmpityOrMaxChar(string Value)
        {

            string TrimValue = Value.Trim();
            if (TrimValue == "")
            {
                MessageBox.Show("Xana və ya xanalar boş olmamalıdır.","Boş xana xətası!.");
                return false;
            }
            if (TrimValue.Length>50)
            {
                MessageBox.Show("Xana və ya xanalara ən çox 50 simvol daxil edilməlidir.","Simvol sayi xətası!.");
                return false;
            }
            
            return true;
        }
        public static bool IsEmpityOrMaxChar(string Value, int MaxCharSize)
        {

            string TrimValue = Value.Trim();
            if (TrimValue == "")
            {
                MessageBox.Show("Xana və ya xanalar boş olmamalıdır.", "Boş xana xətası!.");
                return false;
            }
            if (TrimValue.Length > MaxCharSize)
            {
                MessageBox.Show("Xana və ya xanalara ən çox "+ MaxCharSize + " simvol daxil edilməlidir.", "Simvol sayi xətası!.");
                return false;
            }

            return true;
        }
        public static bool IsStringValue(string Value)
        {
            Regex pattern = new Regex(@"(^[a-zA-zğöəışçüĞÖƏIŞÇÜİ]{1,})((\-){1}?)??([a-zA-zğöəışçüĞÖƏIŞÇÜİ]{1,}$)");

            if (!pattern.IsMatch(Value))
            {
                MessageBox.Show("Xana(lara) yalnız hərf daxil edilməlidir.İstisna olaraq bir ədəd \"-\"simvolu daxil etmək mümkündür.", "Simvol xətası!.");
                return false;
            }

            ClearValue = Value;
            return true;
        }
        public static bool IsEmailValue(string Value)
        {
            Regex pattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (!pattern.IsMatch(Value))
            {
                MessageBox.Show("Email ünvanınız doğru deyil", "Simvol xətası!.");
                return false;
            }

            ClearValue = Value;
            return true;
        }
        public static bool IsPhoneValue(string Value)
        {
            Regex pattern = new Regex(@"^((\(){1}?(\+){1}?[0-9]{3}?(\)){1}?){1}?([0-9]{2}?){1}?(\-){1}?([0-9]{3}?){1}?(\-){1}?([0-9]{2}?){1}?(\-){1}?([0-9]{2}){1}?$");

            if (!pattern.IsMatch(Value))
            {
                MessageBox.Show("Telefon Nömrəniz doğru deyil. Nümunə:(+994)XX-XXX-XX-XX", "Simvol xətası!.");
                return false;
            }

            ClearValue = Value;
            return true;
        }
        public static bool isSave(int i) {
            if (i > 0)
            {
                MessageBox.Show("Məlumat əlavə olundu və ya yeniləndi.","Uğurlu Əməliyyat.");
                return true;
            }
            else
            {
                MessageBox.Show("Məlumat əlavə olunmadı və ya yenilənmədi!", "Diqqət!");
                return false;
            }
        }
        public static bool isDeleted(int i)
            {
                if (i > 0)
                {
                    MessageBox.Show("Məlumat silindi", "Silmək Sorğusuna cavab");
                    return true;
                }
                else
                {
                    MessageBox.Show("Məlumat silindmədi", "Silmək Sorğusuna cavab");
                    return false;
                }
            }
        public static bool isPrice(string Value)
        {
            Regex pattern = new Regex(@"(^[0-9]{1,})((\.){1}?)??([0-9]{1,}$)");

            if (!pattern.IsMatch(Value))
            {
                MessageBox.Show("Qiymət doğru deyil. Nümunə:1.25 və ya tam ədəd", "Yazılış xətası!.");
                return false;
            }

            ClearValue = Value;
            return true;
        }
        public static bool isInt(string Value)
        {
            Regex pattern = new Regex(@"(^[0-9]{1,}$)");

            if (!pattern.IsMatch(Value))
            {
                MessageBox.Show("Rəqəm doğru deyil. Yalnız tam ədədlər daxil edin.", "Rəqəm xətası!.");
                return false;
            }

            ClearValue = Value;
            return true;
        }
        public static bool isDate(DateTime Value)
        {

            if (!(Value>DateTime.Today))
            {
                MessageBox.Show("Tapşırığın bitmə vaxtı minimum bir gün sonraya seçilməlidir.", "Tarix xətası!.");
                return false;
            }
            return true;
        }
    }
}
