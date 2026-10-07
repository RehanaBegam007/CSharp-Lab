using System;
using System.Windows.Forms;

namespace WindowsFormsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = "";

            if (rdoMale.Checked)
                gender = "Male";
            else if (rdoFemale.Checked)
                gender = "Female";

            string course = cmbCourse.Text;

            string hobbies = "";

            if (chkSports.Checked)
                hobbies += "Sports";

            if (chkMusic.Checked)
            {
                if (hobbies != "")
                    hobbies += ", ";

                hobbies += "Music";
            }

            MessageBox.Show(
                "Name : " + name +
                "\nGender : " + gender +
                "\nCourse : " + course +
                "\nHobbies : " + hobbies,
                "Student Details");
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            txtName.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkSports.Checked = false;
            chkMusic.Checked = false;
            cmbCourse.SelectedIndex = -1;
        }
    }
}