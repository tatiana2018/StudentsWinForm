using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library
{
    public class TextBoxEvent
    {
        public void TextKeyPress(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)){ e.Handled = false; }    

            else if(e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }

            else if(char.IsControl(e.KeyChar)) {  e.Handled = false; } 
            
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            else { e.Handled = true; }

        }

        public void NumberKeyPress(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; } 
            
            else if (char.IsLetter(e.KeyChar)) { e.Handled = false; } else if (char.IsControl(e.KeyChar)) { e.Handled = false; } 
            
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; } 
            
            else { e.Handled = true; }

        

        }

        public bool EmailAdressAttribute(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }


    }
}
