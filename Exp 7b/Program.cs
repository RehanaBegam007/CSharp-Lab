using System;
using System.Drawing;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new DialogForm());
    }
}

class DialogForm : Form
{
    Button btnInfo;
    Button btnWarning;
    Button btnConfirm;
    Button btnExit;

    public DialogForm()
    {
        Text = "Dialog Box Example";
        Size = new Size(450, 300);

        btnInfo = new Button();
        btnInfo.Text = "Information";
        btnInfo.Location = new Point(120, 40);
        btnInfo.Size = new Size(200, 40);
        btnInfo.Click += BtnInfo_Click;

        btnWarning = new Button();
        btnWarning.Text = "Warning";
        btnWarning.Location = new Point(120, 90);
        btnWarning.Size = new Size(200, 40);
        btnWarning.Click += BtnWarning_Click;

        btnConfirm = new Button();
        btnConfirm.Text = "Confirmation";
        btnConfirm.Location = new Point(120, 140);
        btnConfirm.Size = new Size(200, 40);
        btnConfirm.Click += BtnConfirm_Click;

        btnExit = new Button();
        btnExit.Text = "Exit";
        btnExit.Location = new Point(120, 190);
        btnExit.Size = new Size(200, 40);
        btnExit.Click += BtnExit_Click;

        Controls.Add(btnInfo);
        Controls.Add(btnWarning);
        Controls.Add(btnConfirm);
        Controls.Add(btnExit);
    }

    private void BtnInfo_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            "Welcome to the application!",
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void BtnWarning_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            "Please check the entered details.",
            "Warning",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }

    private void BtnConfirm_Click(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Do you want to continue?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            MessageBox.Show("You selected Yes.");
        }
        else
        {
            MessageBox.Show("You selected No.");
        }
    }

    private void BtnExit_Click(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Are you sure you want to exit?",
            "Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}