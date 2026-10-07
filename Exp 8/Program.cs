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
    MenuStrip menuStrip;
    ToolStripMenuItem fileMenu;
    ToolStripMenuItem studentMenu;
    ToolStripMenuItem courseMenu;
    ToolStripMenuItem exitMenu;

    public MainForm()
    {
        Text = "MDI Application";
        IsMdiContainer = true;
        WindowState = FormWindowState.Maximized;

        menuStrip = new MenuStrip();

        fileMenu = new ToolStripMenuItem("File");

        studentMenu = new ToolStripMenuItem("Student Details");
        studentMenu.Click += StudentMenu_Click;

        courseMenu = new ToolStripMenuItem("Course Details");
        courseMenu.Click += CourseMenu_Click;

        exitMenu = new ToolStripMenuItem("Exit");
        exitMenu.Click += ExitMenu_Click;

        fileMenu.DropDownItems.Add(studentMenu);
        fileMenu.DropDownItems.Add(courseMenu);
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

    private void ExitMenu_Click(object? sender, EventArgs e)
    {
        Application.Exit();
    }
}

class StudentForm : Form
{
    public StudentForm()
    {
        Text = "Student Details";
        Size = new Size(400, 250);

        Label label = new Label();
        label.Text = "Student Details\n\nName : Arun\nRoll Number : 101\nDepartment : Information Technology";
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
        label.Text = "Course Details\n\nCourse : C# Programming\nDuration : 6 Months\nMode : Classroom";
        label.Location = new Point(40, 40);
        label.AutoSize = true;

        Controls.Add(label);
    }
}