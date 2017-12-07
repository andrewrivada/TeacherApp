using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Teacher_App
{
    public partial class Form1 : Form
    {
        public static List<Student> Student_list = new List<Student>();
        public static int index;
        bool panelDisplayed = false;
        bool helpTextbox = false;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Help_Panel.Visible = false;
            Help_Text.Visible = false;
            //reading data from textfile
            if (File.Exists("students.dat") && global_status.First_load) // loads from file for only the first time
            {
                //Check if File exists 

                using (BinaryReader reader = new BinaryReader(File.Open("students.dat", FileMode.Open)))
                {
                    while (reader.PeekChar() != -1)
                    {

                        string name = reader.ReadString();
                        string student_id = reader.ReadString();
                        int profesor_id = reader.ReadInt32();
                        int course_id = reader.ReadInt32();
                        int Gindex = reader.ReadInt32();
                        int attendance = reader.ReadInt32();

                        List<decimal> Grades = new List<decimal>();

                        //using Gindex to keep track of how many grades in Grades list
                        for (int i = 0; i < Gindex; i++)
                        {
                            int grade = reader.ReadInt32();
                            Grades.Add(grade);
                        }
                        
                        Student student = new Student(name, student_id, profesor_id, course_id, Gindex, attendance, Grades);
                        Student_list.Add(student);
                        index++;
                        
                    }
                    global_status.First_load = false;
                }
               
            } // end of data reading from file
            // if the list has been changed save the changes
            if (global_status.List_changed) 
                {
                    //writing data to textfile
                    using (BinaryWriter writer = new BinaryWriter(File.Open("students.dat", FileMode.Create)))
                    {
                        foreach (Student student in Student_list)
                        {
                            writer.Write(student.name);
                            writer.Write(student.student_id);
                            writer.Write(student.profesor_id);
                            writer.Write(student.course_id);
                            writer.Write(student.Gindex);
                            writer.Write(student.attendance);
                            foreach (int grade in student.Grades)
                            {
                                writer.Write(grade);
                            }

                        }
                    }// end of writing */
                    global_status.List_changed = false; // ensures that only changes get saved once
                }

        }
        
        private void button1_Click(object sender, EventArgs e) // add drop students
        {
            
            this.Hide();
            Add_Drop F2 = new Add_Drop();
            F2.Left = this.Left;
            F2.Top = this.Top;
            F2.Size = this.Size;
            F2.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e) // alter attendance
        {
            this.Hide();
            N_Attendance_label F2 = new N_Attendance_label();
            F2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // enter grades
        {
            this.Hide();
            Grades F2 = new Grades();
            F2.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) // view the classroom
        {
            this.Hide();
            Students F2 = new Students();
            F2.ShowDialog();
            this.Close();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        

        //example adding student to list for testing
        private void Add_Click(object sender, EventArgs e)
        {
            List<decimal> exGrades = new List<decimal>();
            exGrades.Add(1);
            Student student = new Student("Ryan","RyanOune01",123,1234,1,10,exGrades);
           
            Student_list.Add(student);
            index++;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (helpTextbox == false)
            {
                helpTextbox = true;
                Help_Text.Visible = true;

                Help_Text.Text = "\t\tAdd/Drop\t\t" +
                "\r\nAdd Student:\r\n" +
                "\t1. Click on the Add Students button.\r\n" +
                "\t2. Enter Student Id.\r\n" +
                "\t3. Enter Course Id.\r\n" +
                "\t4. Enter Student Name.\r\n" +
                "\t5. Enter Professor Id.\r\n" +
                "\t6. Press enter.\r\n" +
                "\r\nDrop Student:\r\n" +
                "\t1. Click on the Drop Students button.\r\n" +
                "\t2. Enter Student Id.\r\n" +
                "\t3. Enter Course Id.\r\n" +
                "\t6. Press enter.\r\n";
                
            }
            else
            {
                helpTextbox = false;
                Help_Text.Visible = false;
            }
            

        }

        private void Help_Click(object sender, EventArgs e)
        {
            if (panelDisplayed == false)
            {
                panelDisplayed = true;
                Help_Panel.Visible = true;
            }
            else
            {
                panelDisplayed = false;
                Help_Panel.Visible = false;
                Help_Text.Visible = false;
            }
        }

        private void Attendance_Help_Click(object sender, EventArgs e)
        {
            if (helpTextbox == false)
            {
                helpTextbox = true;
                Help_Text.Visible = true;

                Help_Text.Text = "\t\tAttendance\t\t\r\n" +
                "1. Enter Course Id.\r\n" + 
                "2. Press enter.\r\n" +
                "3. Select Present or Absent.\r\n" +
                "4. Press next to go to next student in course.\r\n" +
                "5. Press back to go back to main menu.\r\n";
            }
            else
            {
                helpTextbox = false;
                Help_Text.Visible = false;
            }
        }

        private void Grades_Help_Click(object sender, EventArgs e)
        {
            if (helpTextbox == false)
            {
                helpTextbox = true;
                Help_Text.Visible = true;

                Help_Text.Text = "\t\tGrades\t\t\r\n" +
                "1. Enter Course Id.\r\n" + 
                "1. Enter Professor Id.\r\n" +
                "2. Press enter.\r\n" +
                "3. Press Grade New Assignment, Grade Midterm, or Grade Final Exam.\r\n" +
                "4. Enter a score for student.\r\n" +
                "5. Press Finish Grading to go back to main menu.\r\n";
            }
            else
            {
                helpTextbox = false;
                Help_Text.Visible = false;
            }
        }

        private void Students_Help_Click(object sender, EventArgs e)
        {
            if (helpTextbox == false)
            {
                helpTextbox = true;
                Help_Text.Visible = true;

                Help_Text.Text = "\t\tStudents\t\t" +
                "\r\nStudent List:\r\n" +
                "\t1. Enter Professor Id, Course Id, and/or Student Id in respective textbox.\r\n" +
                "\t2. Press Filter List to display students in given classifications.\r\n" +
                "\t3. Reset list to display all students available.\r\n" +
                "\t4. Press Students to show which students are failing.\r\n" +
                "\t5. Press back to go back to main menu.\r\n" +
                "\r\nExport:\r\n" +
                "\t1. Follow steps 1-3 to display necessary students.\r\n" +
                "\t2. Enter a name for your file in the textbox given above the export button.\r\n" +
                "\t3. Press export.\r\n" +
                "\t4. Select a directory on your computer to save the file to.\r\n"+
                "\t5. Press ok.\r\n"+
                "\t6. Press back to go back to main menu.\r\n";

            }
            else
            {
                helpTextbox = false;
                Help_Text.Visible = false;
            }
        }
    }
}
