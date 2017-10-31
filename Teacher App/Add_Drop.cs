using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_App
{
    public partial class Add_Drop : Form
    {
        public Add_Drop()
        {
            InitializeComponent();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F2 = new Form1();
            F2.ShowDialog();
            this.Close();            
        }
        private void Add_Student(object sender, EventArgs e)
        {
            bool check;
            check = radioButton1.Checked;
            if (check == radioButton2.Checked)
            {
                radioButton2.Checked = false;
            }
            if (radioButton1.Checked == false)
            {
                student_name.Visible = false;
                studentname.Visible = false;
                professor_ID.Visible = false;
                Profesor_ID.Visible = false;
            }
            else
            {
                student_name.Visible = true;
                studentname.Visible = true;
                professor_ID.Visible = true;
                Profesor_ID.Visible = true;
            }
        }
        private void Drop_Student(object sender, EventArgs e)
        {
            bool check;
            check = radioButton2.Checked;
            if (check == radioButton1.Checked)
            {
                radioButton2.Checked = true;
            }

            if (radioButton2.Checked == false)
            {
                student_name.Visible = true;
                studentname.Visible = true;
                professor_ID.Visible = true;
                Profesor_ID.Visible = true;
            }
            else
            {
                student_name.Visible = false;
                studentname.Visible = false;
                professor_ID.Visible = false;
                Profesor_ID.Visible = false;
            }
        }

        private void studentname_Click(object sender, EventArgs e)
        {
        }

        private void proceed_button(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) // add student selected
            {
                Student temp = new Student();
                if (student_id.Text != "" && Convert.ToInt32(course_ID.Text) > 0 && Convert.ToInt32(Profesor_ID.Text) > 0 && studentname.Text != "")
                {
                    temp.student_id = student_id.Text;
                    temp.course_id = Convert.ToInt32(course_ID.Text);
                    temp.profesor_id = Convert.ToInt32(Profesor_ID.Text);
                    temp.name = student_name.Text;
                    Form1.Student_list.Add(temp);
                    student_id.Text = "";// reset the display
                    course_ID.Text = "";
                    Profesor_ID.Text = "";
                    student_name.Text = "";
                    MessageBox.Show(temp.name + " has been added");
                    last_student.Text = "Last Student Added: " + Form1.Student_list[Form1.Student_list.Count - 1].name;
                }
                else
                {
                    string message = "Please ensure all fields are complete.";
                    string caption = "Incomplete Entry";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Student remove_student = Form1.Student_list.SingleOrDefault(x => x.course_id == Convert.ToInt32(course_ID.Text));
                

                if (remove_student != null && remove_student.student_id == student_id.Text)
                {
                    Form1.Student_list.Remove(remove_student);
                }
                else
                {
                    MessageBox.Show("Student not found!\n");
                }
            }
        }
    }
}
