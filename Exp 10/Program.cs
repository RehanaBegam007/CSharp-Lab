using System;
using System.Drawing;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}

class MainForm : Form
{
    private MenuStrip menuStrip;
    private ToolStripMenuItem fileMenu;
    private ToolStripMenuItem studentMenu;
    private ToolStripMenuItem courseMenu;
    private ToolStripMenuItem dialogMenu;
    private ToolStripMenuItem exitMenu;

    public MainForm()
    {
        Text = "MDI Application";
        IsMdiContainer = true;
        WindowState = FormWindowState.Maximized;

        menuStrip = new MenuStrip();

        fileMenu = new ToolStripMenuItem("Menu");

        studentMenu = new ToolStripMenuItem("Student Details");
        courseMenu = new ToolStripMenuItem("Course Details");
        dialogMenu = new ToolStripMenuItem("Show Dialog");
        exitMenu = new ToolStripMenuItem("Exit");

        studentMenu.Click += StudentMenu_Click;
        courseMenu.Click += CourseMenu_Click;
        dialogMenu.Click += DialogMenu_Click;
        exitMenu.Click += ExitMenu_Click;

        fileMenu.DropDownItems.Add(studentMenu);
        fileMenu.DropDownItems.Add(courseMenu);
        fileMenu.DropDownItems.Add(dialogMenu);
        fileMenu.DropDownItems.Add(exitMenu);

        menuStrip.Items.Add(fileMenu);

        MainMenuStrip = menuStrip;
        Controls.Add(menuStrip);
    }

    private void StudentMenu_Click(object? sender, EventArgs e)
    {
        StudentForm studentForm = new StudentForm();
        studentForm.MdiParent = this;
        studentForm.Show();
    }

    private void CourseMenu_Click(object? sender, EventArgs e)
    {
        CourseForm courseForm = new CourseForm();
        courseForm.MdiParent = this;
        courseForm.Show();
    }

    private void DialogMenu_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            "Welcome to the MDI Application!",
            "Dialog Box",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void ExitMenu_Click(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Do you want to exit?",
            "Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}

class StudentForm : Form
{
    public StudentForm()
    {
        Text = "Student Details";
        Size = new Size(400, 250);

        Label label = new Label();

        label.Text =
            "Student Details\n\n" +
            "ID : 101\n" +
            "Name : Arun\n" +
            "Department : IT";

        label.Location = new Point(40, 40);
        label.AutoSize = true;

        Controls.Add(label);
    }
}

class CourseForm : Form
{
    public CourseForm()
    {
        Text = "Course Details";
        Size = new Size(400, 250);

        Label label = new Label();

        label.Text =
            "Course Details\n\n" +
            "Course : C# Programming\n" +
            "Duration : 6 Months\n" +
            "Mode : Classroom";

        label.Location = new Point(40, 40);
        label.AutoSize = true;

        Controls.Add(label);
    }
}