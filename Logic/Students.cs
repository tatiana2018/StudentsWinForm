using Data;
using LinqToDB;
using Logic.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Students : Libraries
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;

        public Students()
        {
        }

        public Students(List<TextBox> listTextBox, List<Label> listLabel, object[] objets)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            image = (PictureBox)objets[0];
        }

        public void Registry()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "Campo requerido";
                listLabel[0].ForeColor = Color.Red;
                listTextBox[0].Focus();
            }

            if (listTextBox[3].Text.Equals(""))
            {
                listLabel[3].Text = "Campo requerido";
                listLabel[3].ForeColor = Color.Red;
                listTextBox[3].Focus();
            } else
            {
                if (txtBoxEvent.EmailAdressAttribute(listTextBox[3].Text))
                {

                    BeginTransactionAsync();
                    try
                    {
                        var imageArray = uploadImage.ImageToByte(image.Image);

                        student.Value(e => e.nid, listTextBox[0].Text)
                         .Value(e => e.name, listTextBox[1].Text)
                         .Value(e => e.lastName, listTextBox[2].Text)
                         .Value(e => e.email, listTextBox[3].Text)
                         .Value(e => e.image, imageArray)
                         .Insert();

                        CommitTransaction();
                    } catch (Exception ex)
                    {
                        RollbackTransaction();
                    }


                } else
                {
                    listLabel[3].ForeColor = Color.Red;
                    listLabel[3].Text = "Formato incorrecto";
                    listTextBox[3].Focus();
                }
            }
        }
    }
}
