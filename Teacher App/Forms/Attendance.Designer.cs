namespace Teacher_App
{
    partial class N_Attendance_label
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
            this.main_menu_button = new System.Windows.Forms.Button();
            this.please_text = new System.Windows.Forms.Label();
            this.course_id_box = new System.Windows.Forms.TextBox();
            this.Enter_button = new System.Windows.Forms.Button();
            this.student_name_box = new System.Windows.Forms.TextBox();
            this.student_text = new System.Windows.Forms.Label();
            this.present_button = new System.Windows.Forms.RadioButton();
            this.absent_button = new System.Windows.Forms.RadioButton();
            this.Next_button = new System.Windows.Forms.Button();
            this.cAttendance_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nattendance_label = new System.Windows.Forms.Label();
            this.numerOfStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_menu_button
            // 
            this.main_menu_button.Location = new System.Drawing.Point(592, 412);
            this.main_menu_button.Margin = new System.Windows.Forms.Padding(2);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(80, 28);
            this.main_menu_button.TabIndex = 0;
            this.main_menu_button.Text = "Main Menu";
            this.main_menu_button.UseVisualStyleBackColor = true;
            this.main_menu_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // please_text
            // 
            this.please_text.AutoSize = true;
            this.please_text.BackColor = System.Drawing.Color.Transparent;
            this.please_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.please_text.Location = new System.Drawing.Point(54, 76);
            this.please_text.Name = "please_text";
            this.please_text.Size = new System.Drawing.Size(262, 26);
            this.please_text.TabIndex = 3;
            this.please_text.Text = "Please Enter the Class ID";
            // 
            // course_id_box
            // 
            this.course_id_box.Location = new System.Drawing.Point(332, 82);
            this.course_id_box.Name = "course_id_box";
            this.course_id_box.Size = new System.Drawing.Size(192, 20);
            this.course_id_box.TabIndex = 10;
            this.course_id_box.TextChanged += new System.EventHandler(this.student_id_TextChanged);
            this.course_id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.course_id_box_KeyPress);
            // 
            // Enter_button
            // 
            this.Enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_button.Location = new System.Drawing.Point(592, 75);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(93, 31);
            this.Enter_button.TabIndex = 13;
            this.Enter_button.Text = "Enter";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // student_name_box
            // 
            this.student_name_box.Location = new System.Drawing.Point(259, 192);
            this.student_name_box.Name = "student_name_box";
            this.student_name_box.ReadOnly = true;
            this.student_name_box.Size = new System.Drawing.Size(140, 20);
            this.student_name_box.TabIndex = 14;
            // 
            // student_text
            // 
            this.student_text.AutoSize = true;
            this.student_text.BackColor = System.Drawing.Color.Transparent;
            this.student_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_text.Location = new System.Drawing.Point(54, 186);
            this.student_text.Name = "student_text";
            this.student_text.Size = new System.Drawing.Size(152, 26);
            this.student_text.TabIndex = 15;
            this.student_text.Text = "Student Name";
            this.student_text.Click += new System.EventHandler(this.label2_Click);
            // 
            // present_button
            // 
            this.present_button.AutoSize = true;
            this.present_button.BackColor = System.Drawing.Color.Transparent;
            this.present_button.Checked = true;
            this.present_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.present_button.Location = new System.Drawing.Point(549, 192);
            this.present_button.Name = "present_button";
            this.present_button.Size = new System.Drawing.Size(72, 20);
            this.present_button.TabIndex = 16;
            this.present_button.TabStop = true;
            this.present_button.Text = "Present";
            this.present_button.UseVisualStyleBackColor = false;
            this.present_button.CheckedChanged += new System.EventHandler(this.present_button_CheckedChanged);
            // 
            // absent_button
            // 
            this.absent_button.AutoSize = true;
            this.absent_button.BackColor = System.Drawing.Color.Transparent;
            this.absent_button.Checked = true;
            this.absent_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absent_button.Location = new System.Drawing.Point(627, 193);
            this.absent_button.MaximumSize = new System.Drawing.Size(4000, 0);
            this.absent_button.Name = "absent_button";
            this.absent_button.Size = new System.Drawing.Size(68, 20);
            this.absent_button.TabIndex = 17;
            this.absent_button.TabStop = true;
            this.absent_button.Text = "Absent";
            this.absent_button.UseVisualStyleBackColor = false;
            this.absent_button.CheckedChanged += new System.EventHandler(this.absent_button_CheckedChanged);
            // 
            // Next_button
            // 
            this.Next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_button.Location = new System.Drawing.Point(592, 275);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(93, 29);
            this.Next_button.TabIndex = 18;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // cAttendance_label
            // 
            this.cAttendance_label.AutoSize = true;
            this.cAttendance_label.BackColor = System.Drawing.Color.Transparent;
            this.cAttendance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAttendance_label.Location = new System.Drawing.Point(55, 284);
            this.cAttendance_label.Name = "cAttendance_label";
            this.cAttendance_label.Size = new System.Drawing.Size(167, 20);
            this.cAttendance_label.TabIndex = 19;
            this.cAttendance_label.Text = "Current Attendance";
            this.cAttendance_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(54, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Attendance";
            // 
            // nattendance_label
            // 
            this.nattendance_label.AutoSize = true;
            this.nattendance_label.BackColor = System.Drawing.Color.Transparent;
            this.nattendance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nattendance_label.Location = new System.Drawing.Point(55, 332);
            this.nattendance_label.Name = "nattendance_label";
            this.nattendance_label.Size = new System.Drawing.Size(141, 20);
            this.nattendance_label.TabIndex = 23;
            this.nattendance_label.Text = "New Attendance";
            this.nattendance_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // numerOfStudent
            // 
            this.numerOfStudent.AutoSize = true;
            this.numerOfStudent.BackColor = System.Drawing.Color.Transparent;
            this.numerOfStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerOfStudent.Location = new System.Drawing.Point(55, 241);
            this.numerOfStudent.Name = "numerOfStudent";
            this.numerOfStudent.Size = new System.Drawing.Size(158, 20);
            this.numerOfStudent.TabIndex = 24;
            this.numerOfStudent.Text = "Number of student";
            // 
            // N_Attendance_label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Teacher_App.Properties.Resources.school_apple_on_desk;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.numerOfStudent);
            this.Controls.Add(this.nattendance_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cAttendance_label);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.absent_button);
            this.Controls.Add(this.present_button);
            this.Controls.Add(this.student_text);
            this.Controls.Add(this.student_name_box);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.course_id_box);
            this.Controls.Add(this.please_text);
            this.Controls.Add(this.main_menu_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "N_Attendance_label";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button main_menu_button;
        private System.Windows.Forms.Label please_text;
        private System.Windows.Forms.TextBox course_id_box;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.TextBox student_name_box;
        private System.Windows.Forms.Label student_text;
        private System.Windows.Forms.RadioButton present_button;
        private System.Windows.Forms.RadioButton absent_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Label cAttendance_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nattendance_label;
        private System.Windows.Forms.Label numerOfStudent;
    }
}