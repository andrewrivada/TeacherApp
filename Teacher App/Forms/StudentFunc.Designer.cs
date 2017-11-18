namespace Teacher_App
{
    partial class Students
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
            this.filter_list = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class_pick = new System.Windows.Forms.TextBox();
            this.class_pick_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.proff_pick = new System.Windows.Forms.TextBox();
            this.proff_pick_label = new System.Windows.Forms.Label();
            this.stud_pick_label = new System.Windows.Forms.Label();
            this.student_pick = new System.Windows.Forms.TextBox();
            this.filter_prof = new System.Windows.Forms.Button();
            this.filter_class = new System.Windows.Forms.Button();
            this.filter_stud = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filter_list
            // 
            this.filter_list.Location = new System.Drawing.Point(280, 375);
            this.filter_list.Name = "filter_list";
            this.filter_list.Size = new System.Drawing.Size(106, 30);
            this.filter_list.TabIndex = 3;
            this.filter_list.Text = "Filter List";
            this.filter_list.UseVisualStyleBackColor = true;
            this.filter_list.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(498, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Click To See Failing Students";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Student List";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 50);
            this.button3.TabIndex = 18;
            this.button3.Text = "Students";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.warningmessage_students);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 308);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Professor ID";
            this.columnHeader0.Width = 72;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Class ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student ID";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Attendance Score";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Grade";
            this.columnHeader5.Width = 89;
            // 
            // class_pick
            // 
            this.class_pick.Location = new System.Drawing.Point(111, 381);
            this.class_pick.Name = "class_pick";
            this.class_pick.Size = new System.Drawing.Size(74, 20);
            this.class_pick.TabIndex = 19;
            this.class_pick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.class_pick_KeyPress);
            // 
            // class_pick_label
            // 
            this.class_pick_label.AutoSize = true;
            this.class_pick_label.Location = new System.Drawing.Point(111, 365);
            this.class_pick_label.Name = "class_pick_label";
            this.class_pick_label.Size = new System.Drawing.Size(74, 13);
            this.class_pick_label.TabIndex = 20;
            this.class_pick_label.Text = "Enter Class ID";
            this.class_pick_label.Click += new System.EventHandler(this.class_pick_label_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 21;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(519, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 44);
            this.button4.TabIndex = 22;
            this.button4.Text = "Export";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // proff_pick
            // 
            this.proff_pick.Location = new System.Drawing.Point(12, 381);
            this.proff_pick.Name = "proff_pick";
            this.proff_pick.Size = new System.Drawing.Size(96, 20);
            this.proff_pick.TabIndex = 23;
            this.proff_pick.TextChanged += new System.EventHandler(this.proff_pick_TextChanged);
            this.proff_pick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proff_pick_KeyPress);
            // 
            // proff_pick_label
            // 
            this.proff_pick_label.AutoSize = true;
            this.proff_pick_label.Location = new System.Drawing.Point(15, 365);
            this.proff_pick_label.Name = "proff_pick_label";
            this.proff_pick_label.Size = new System.Drawing.Size(93, 13);
            this.proff_pick_label.TabIndex = 24;
            this.proff_pick_label.Text = "Enter Professor ID";
            // 
            // stud_pick_label
            // 
            this.stud_pick_label.AutoSize = true;
            this.stud_pick_label.Location = new System.Drawing.Point(188, 365);
            this.stud_pick_label.Name = "stud_pick_label";
            this.stud_pick_label.Size = new System.Drawing.Size(86, 13);
            this.stud_pick_label.TabIndex = 25;
            this.stud_pick_label.Text = "Enter Student ID";
            // 
            // student_pick
            // 
            this.student_pick.Location = new System.Drawing.Point(187, 381);
            this.student_pick.Name = "student_pick";
            this.student_pick.Size = new System.Drawing.Size(87, 20);
            this.student_pick.TabIndex = 26;
            // 
            // filter_prof
            // 
            this.filter_prof.Location = new System.Drawing.Point(12, 402);
            this.filter_prof.Name = "filter_prof";
            this.filter_prof.Size = new System.Drawing.Size(96, 27);
            this.filter_prof.TabIndex = 27;
            this.filter_prof.Text = "Professor ID";
            this.filter_prof.UseVisualStyleBackColor = true;
            this.filter_prof.Click += new System.EventHandler(this.filter_prof_Click);
            // 
            // filter_class
            // 
            this.filter_class.Location = new System.Drawing.Point(110, 402);
            this.filter_class.Name = "filter_class";
            this.filter_class.Size = new System.Drawing.Size(75, 27);
            this.filter_class.TabIndex = 28;
            this.filter_class.Text = "Class ID";
            this.filter_class.UseVisualStyleBackColor = true;
            this.filter_class.Click += new System.EventHandler(this.filter_class_Click);
            // 
            // filter_stud
            // 
            this.filter_stud.Location = new System.Drawing.Point(187, 402);
            this.filter_stud.Name = "filter_stud";
            this.filter_stud.Size = new System.Drawing.Size(87, 27);
            this.filter_stud.TabIndex = 29;
            this.filter_stud.Text = "Student ID";
            this.filter_stud.UseVisualStyleBackColor = true;
            this.filter_stud.Click += new System.EventHandler(this.filter_stud_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(519, 257);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 26);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter File Name";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Teacher_App.Properties.Resources.school_apple_on_desk;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.filter_stud);
            this.Controls.Add(this.filter_class);
            this.Controls.Add(this.filter_prof);
            this.Controls.Add(this.student_pick);
            this.Controls.Add(this.stud_pick_label);
            this.Controls.Add(this.proff_pick_label);
            this.Controls.Add(this.proff_pick);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.class_pick_label);
            this.Controls.Add(this.class_pick);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filter_list);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Students";
            this.Text = "c";
            this.Load += new System.EventHandler(this.Students_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button filter_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox class_pick;
        private System.Windows.Forms.Label class_pick_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox proff_pick;
        private System.Windows.Forms.Label proff_pick_label;
        private System.Windows.Forms.Label stud_pick_label;
        private System.Windows.Forms.TextBox student_pick;
        private System.Windows.Forms.Button filter_prof;
        private System.Windows.Forms.Button filter_class;
        private System.Windows.Forms.Button filter_stud;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}