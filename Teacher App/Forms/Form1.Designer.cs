namespace Teacher_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add_Drop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Button();
            this.Help_Panel = new System.Windows.Forms.Panel();
            this.AddDrop_Help = new System.Windows.Forms.Button();
            this.Attendance_Help = new System.Windows.Forms.Button();
            this.Grades_Help = new System.Windows.Forms.Button();
            this.Students_Help = new System.Windows.Forms.Button();
            this.Help_Text = new System.Windows.Forms.TextBox();
            this.Help_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Drop
            // 
            this.Add_Drop.Location = new System.Drawing.Point(40, 276);
            this.Add_Drop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Drop.Name = "Add_Drop";
            this.Add_Drop.Size = new System.Drawing.Size(93, 36);
            this.Add_Drop.TabIndex = 0;
            this.Add_Drop.Text = "Add/Drop";
            this.Add_Drop.UseVisualStyleBackColor = true;
            this.Add_Drop.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 276);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Attendace";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 276);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Grades";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 276);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Students";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome Professor...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please select from the options below";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(815, 31);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(100, 30);
            this.Help.TabIndex = 7;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Help_Panel
            // 
            this.Help_Panel.Controls.Add(this.Students_Help);
            this.Help_Panel.Controls.Add(this.Grades_Help);
            this.Help_Panel.Controls.Add(this.Attendance_Help);
            this.Help_Panel.Controls.Add(this.AddDrop_Help);
            this.Help_Panel.Location = new System.Drawing.Point(815, 55);
            this.Help_Panel.Name = "Help_Panel";
            this.Help_Panel.Size = new System.Drawing.Size(100, 120);
            this.Help_Panel.TabIndex = 8;
            // 
            // AddDrop_Help
            // 
            this.AddDrop_Help.Location = new System.Drawing.Point(0, 0);
            this.AddDrop_Help.Name = "AddDrop_Help";
            this.AddDrop_Help.Size = new System.Drawing.Size(100, 30);
            this.AddDrop_Help.TabIndex = 9;
            this.AddDrop_Help.Text = "Add/Drop";
            this.AddDrop_Help.UseVisualStyleBackColor = true;
            this.AddDrop_Help.Click += new System.EventHandler(this.button4_Click);
            // 
            // Attendance_Help
            // 
            this.Attendance_Help.Location = new System.Drawing.Point(0, 30);
            this.Attendance_Help.Name = "Attendance_Help";
            this.Attendance_Help.Size = new System.Drawing.Size(100, 30);
            this.Attendance_Help.TabIndex = 10;
            this.Attendance_Help.Text = "Attendance";
            this.Attendance_Help.UseVisualStyleBackColor = true;
            this.Attendance_Help.Click += new System.EventHandler(this.Attendance_Help_Click);
            // 
            // Grades_Help
            // 
            this.Grades_Help.Location = new System.Drawing.Point(0, 60);
            this.Grades_Help.Name = "Grades_Help";
            this.Grades_Help.Size = new System.Drawing.Size(100, 30);
            this.Grades_Help.TabIndex = 11;
            this.Grades_Help.Text = "Grades";
            this.Grades_Help.UseVisualStyleBackColor = true;
            this.Grades_Help.Click += new System.EventHandler(this.Grades_Help_Click);
            // 
            // Students_Help
            // 
            this.Students_Help.Location = new System.Drawing.Point(0, 90);
            this.Students_Help.Name = "Students_Help";
            this.Students_Help.Size = new System.Drawing.Size(100, 30);
            this.Students_Help.TabIndex = 12;
            this.Students_Help.Text = "Students";
            this.Students_Help.UseVisualStyleBackColor = true;
            this.Students_Help.Click += new System.EventHandler(this.Students_Help_Click);
            // 
            // Help_Text
            // 
            this.Help_Text.Location = new System.Drawing.Point(524, 220);
            this.Help_Text.Multiline = true;
            this.Help_Text.Name = "Help_Text";
            this.Help_Text.ReadOnly = true;
            this.Help_Text.Size = new System.Drawing.Size(436, 307);
            this.Help_Text.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Teacher_App.Properties.Resources.school_apple_on_desk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.Help_Text);
            this.Controls.Add(this.Help_Panel);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_Drop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Utility Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Help_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Drop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Panel Help_Panel;
        private System.Windows.Forms.Button Students_Help;
        private System.Windows.Forms.Button Grades_Help;
        private System.Windows.Forms.Button Attendance_Help;
        private System.Windows.Forms.Button AddDrop_Help;
        private System.Windows.Forms.TextBox Help_Text;
    }
}

