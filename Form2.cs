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
    public partial class Form2: Form
    {
        public Form2(Image img, string mobile, string firstname, string lastname, string sex, string status, DateTime birthday, string location)
        {
            InitializeComponent();

            txtMobile.Text = mobile;
            txtFirstname.Text = firstname;
            txtLastname.Text = lastname;
            txtLocation.Text = location;

            if (img != null)
            {
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (sex == "Male")
            {
                rdoMale.Checked = true;
            }
            else if (sex == "Female")
            {
                rdoFemale.Checked = true;
            }

            cbStatus.Items.Add("Single");
            cbStatus.Items.Add("Married");
            cbStatus.Items.Add("It's Complicated");

            cbStatus.SelectedItem = status;

            dtpBirthday.Value = birthday;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
