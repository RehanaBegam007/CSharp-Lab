namespace WindowsFormsControls
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblGender = new System.Windows.Forms.Label();
            rdoMale = new System.Windows.Forms.RadioButton();
            rdoFemale = new System.Windows.Forms.RadioButton();
            lblCourse = new System.Windows.Forms.Label();
            cmbCourse = new System.Windows.Forms.ComboBox();
            lblHobbies = new System.Windows.Forms.Label();
            chkSports = new System.Windows.Forms.CheckBox();
            chkMusic = new System.Windows.Forms.CheckBox();
            btnSubmit = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            SuspendLayout();

            // lblName
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(40, 40);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(50, 20);
            lblName.Text = "Name:";

            // txtName
            txtName.Location = new System.Drawing.Point(150, 37);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(220, 27);

            // lblGender
            lblGender.AutoSize = true;
            lblGender.Location = new System.Drawing.Point(40, 90);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(60, 20);
            lblGender.Text = "Gender:";

            // rdoMale
            rdoMale.AutoSize = true;
            rdoMale.Location = new System.Drawing.Point(150, 88);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new System.Drawing.Size(63, 24);
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;

            // rdoFemale
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new System.Drawing.Point(230, 88);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new System.Drawing.Size(78, 24);
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;

            // lblCourse
            lblCourse.AutoSize = true;
            lblCourse.Location = new System.Drawing.Point(40, 140);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new System.Drawing.Size(58, 20);
            lblCourse.Text = "Course:";

            // cmbCourse
            cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[]
            {
                "Information Technology",
                "Computer Science",
                "Electronics"
            });
            cmbCourse.Location = new System.Drawing.Point(150, 137);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new System.Drawing.Size(220, 28);

            // lblHobbies
            lblHobbies.AutoSize = true;
            lblHobbies.Location = new System.Drawing.Point(40, 190);
            lblHobbies.Name = "lblHobbies";
            lblHobbies.Size = new System.Drawing.Size(67, 20);
            lblHobbies.Text = "Hobbies:";

            // chkSports
            chkSports.AutoSize = true;
            chkSports.Location = new System.Drawing.Point(150, 188);
            chkSports.Name = "chkSports";
            chkSports.Size = new System.Drawing.Size(75, 24);
            chkSports.Text = "Sports";
            chkSports.UseVisualStyleBackColor = true;

            // chkMusic
            chkMusic.AutoSize = true;
            chkMusic.Location = new System.Drawing.Point(150, 220);
            chkMusic.Name = "chkMusic";
            chkMusic.Size = new System.Drawing.Size(69, 24);
            chkMusic.Text = "Music";
            chkMusic.UseVisualStyleBackColor = true;

            // btnSubmit
            btnSubmit.Location = new System.Drawing.Point(150, 270);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(80, 35);
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;

            // btnClear
            btnClear.Location = new System.Drawing.Point(250, 270);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(80, 35);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 370);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblGender);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(lblCourse);
            Controls.Add(cmbCourse);
            Controls.Add(lblHobbies);
            Controls.Add(chkSports);
            Controls.Add(chkMusic);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Name = "Form1";
            Text = "Student Details";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}