namespace Teacher_App
{
    partial class Add_Drop
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.TextBox();
            this.studentname = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.TextBox();
            this.course_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.professor_ID = new System.Windows.Forms.Label();
            this.Profesor_ID = new System.Windows.Forms.TextBox();
            this.last_student = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(399, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add or Drop Students:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(272, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add Students";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.Add_Student);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(368, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Drop Students";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.Drop_Student);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student ID:";
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(151, 169);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(197, 20);
            this.student_name.TabIndex = 7;
            // 
            // studentname
            // 
            this.studentname.AutoSize = true;
            this.studentname.BackColor = System.Drawing.Color.Transparent;
            this.studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.Location = new System.Drawing.Point(31, 167);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(116, 20);
            this.studentname.TabIndex = 8;
            this.studentname.Text = "Student Name:";
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(128, 84);
            this.student_id.MaxLength = 10;
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(220, 20);
            this.student_id.TabIndex = 9;
            this.student_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.student_id_KeyPress);
            // 
            // course_ID
            // 
            this.course_ID.Location = new System.Drawing.Point(128, 127);
            this.course_ID.MaxLength = 10;
            this.course_ID.Name = "course_ID";
            this.course_ID.Size = new System.Drawing.Size(222, 20);
            this.course_ID.TabIndex = 10;
            this.course_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.course_ID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Class ID:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(272, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.proceed_button);
            // 
            // professor_ID
            // 
            this.professor_ID.AutoSize = true;
            this.professor_ID.BackColor = System.Drawing.Color.Transparent;
            this.professor_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_ID.Location = new System.Drawing.Point(31, 206);
            this.professor_ID.Name = "professor_ID";
            this.professor_ID.Size = new System.Drawing.Size(102, 20);
            this.professor_ID.TabIndex = 13;
            this.professor_ID.Text = "Professor ID:";
            // 
            // Profesor_ID
            // 
            this.Profesor_ID.Location = new System.Drawing.Point(139, 208);
            this.Profesor_ID.Name = "Profesor_ID";
            this.Profesor_ID.Size = new System.Drawing.Size(209, 20);
            this.Profesor_ID.TabIndex = 14;
            // 
            // last_student
            // 
            this.last_student.AutoSize = true;
            this.last_student.BackColor = System.Drawing.Color.Transparent;
            this.last_student.Location = new System.Drawing.Point(35, 268);
            this.last_student.Name = "last_student";
            this.last_student.Size = new System.Drawing.Size(104, 13);
            this.last_student.TabIndex = 15;
            this.last_student.Text = "Last Student Added:";
            // 
            // Add_Drop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Teacher_App.Properties.Resources.school_apple_on_desk;
            this.ClientSize = new System.Drawing.Size(513, 448);
            this.Controls.Add(this.last_student);
            this.Controls.Add(this.Profesor_ID);
            this.Controls.Add(this.professor_ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.course_ID);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_Drop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Drop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label studentname;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.TextBox course_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label professor_ID;
        private System.Windows.Forms.TextBox Profesor_ID;
        private System.Windows.Forms.Label last_student;
    }
}