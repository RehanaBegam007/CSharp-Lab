using System;
using System.Drawing;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new ValidationForm());
    }
}

class ValidationForm : Form
{
    Label lblName;
    Label lblAge;
    Label lblEmail;

    TextBox txtName;
    TextBox txtAge;
    TextBox txtEmail;

    Button btnSubmit;
    Button btnClear;

    ErrorProvider errorProvider;

    public ValidationForm()
    {
        Text = "Student Form Validation";
        Size = new Size(500, 350);

        lblName = new Label();
        lblName.Text = "Name:";
        lblName.Location = new Point(50, 40);
        lblName.AutoSize = true;

        txtName = new TextBox();
        txtName.Location = new Point(160, 37);
        txtName.Width = 250;

        lblAge = new Label();
        lblAge.Text = "Age:";
        lblAge.Location = new Point(50, 90);
        lblAge.AutoSize = true;

        txtAge = new TextBox();
        txtAge.Location = new Point(160, 87);
        txtAge.Width = 250;

        lblEmail = new Label();
        lblEmail.Text = "Email:";
        lblEmail.Location = new Point(50, 140);
        lblEmail.AutoSize = true;

        txtEmail = new TextBox();
        txtEmail.Location = new Point(160, 137);
        txtEmail.Width = 250;

        btnSubmit = new Button();
        btnSubmit.Text = "Submit";
        btnSubmit.Location = new Point(160, 190);
        btnSubmit.Click += BtnSubmit_Click;

        btnClear = new Button();
        btnClear.Text = "Clear";
        btnClear.Location = new Point(250, 190);
        btnClear.Click += BtnClear_Click;

        errorProvider = new ErrorProvider();

        Controls.Add(lblName);
        Controls.Add(txtName);
        Controls.Add(lblAge);
        Controls.Add(txtAge);
        Controls.Add(lblEmail);
        Controls.Add(txtEmail);
        Controls.Add(btnSubmit);
        Controls.Add(btnClear);
    }

    private void BtnSubmit_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();

        bool valid = true;

        if (txtName.Text.Trim() == "")
        {
            errorProvider.SetError(txtName, "Enter your name");
            valid = false;
        }

        if (!int.TryParse(txtAge.Text, out int age))
        {
            errorProvider.SetError(txtAge, "Enter a valid age");
            valid = false;
        }
        else if (age < 18 || age > 60)
        {
            errorProvider.SetError(txtAge, "Age must be between 18 and 60");
            valid = false;
        }

        if (!txtEmail.Text.Contains("@"))
        {
            errorProvider.SetError(txtEmail, "Enter a valid email");
            valid = false;
        }

        if (valid)
        {
            MessageBox.Show(
                "Validation Successful!\n\n" +
                "Name : " + txtName.Text +
                "\nAge : " + txtAge.Text +
                "\nEmail : " + txtEmail.Text,
                "Student Details");
        }
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        txtName.Clear();
        txtAge.Clear();
        txtEmail.Clear();
        errorProvider.Clear();
    }
}