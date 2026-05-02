using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWeek_9
{
    public delegate void ManageStudentDelegate(Student student);
    public partial class Form2 : Form
    {
        public event ManageStudentDelegate StudentEvent;
        public Student currentStudent = new Student();
        
        
        private void Form2_Load(object sender, EventArgs e)
        {
            if (currentStudent.index >= 0)
            {
                txtName.Text = currentStudent.name.ToString();
                txtGrade.Text = currentStudent.grade.ToString();
                btnAdd.Text = "Update";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(currentStudent == null)
                currentStudent = new Student();
            currentStudent.name = txtName.Text;
            currentStudent.grade = int.Parse(txtGrade.Text);

            StudentEvent(currentStudent);
            this.Close();
        }


        public Form2()
        {
            InitializeComponent();
        }
    }
}
