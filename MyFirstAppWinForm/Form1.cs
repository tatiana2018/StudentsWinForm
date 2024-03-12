using Logic;
using Logic.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstAppWinForm
{
    public partial class Form1 : Form
    {
        private Students student = new Students();
        private Libraries libraries = new Libraries();
        public Form1()
        {
            InitializeComponent();
            libraries = new Libraries();

            var listTextBox = new List<TextBox> {
                txtNid,
                txtNombre,
                txtApellido,
                txtCorreo
            };


            var listLabel = new List<Label> {
                lblNid,
                lblNombre,
                lblApellido,
                lblCorreo
            };

            Object[] objets = {pictureBoxImage};

            student = new Students(listTextBox, listLabel, objets);
        }

        private void PictureBoxImage_Click(object sender, EventArgs e)
        {
            libraries.uploadImage.UploadImages(pictureBoxImage);
        }

        private void txtNid_TextChanged(object sender, EventArgs e)
        {
            if (txtNid.Text.Equals(""))
            {
                lblNid.ForeColor = Color.Red;
            } else
            {
                lblNid.ForeColor = Color.Green;
                lblNid.Text = "Nid";

            }
        }

        private void txtNid_KeyPress(object sender, KeyPressEventArgs e)
        {
            libraries.txtBoxEvent.TextKeyPress(e);

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            student.Registry();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
