using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("Single");
            cbStatus.Items.Add("Married");
            cbStatus.Items.Add("It's Complicated");

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            string mobile = txtMobile.Text;
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string sex = "";
            string status = "";
            DateTime birthday = dtpBirthday.Value;
            string location = txtLocation.Text;

            if (rdoMale.Checked == true)
            {
                sex = "Male";
            } else if (rdoFemale.Checked == true)
            {
                sex = "Female";
            }

            if (cbStatus.SelectedItem != null)
            {
                status = cbStatus.SelectedItem.ToString();
            }

            Form2 frm2 = new Form2(img, mobile, firstname, lastname, sex, status, birthday, location);
            frm2.Show();
        }
    }
}
