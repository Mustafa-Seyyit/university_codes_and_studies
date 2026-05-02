namespace LabWeek_9
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        public void manageStudentList(Student student)
        {
            if (student.index >= 0)
                lstStudents.Items[student.index] = student.ToString();
            else
                lstStudents.Items.Add(student.ToString());
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.StudentEvent += manageStudentList;
            frm2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex < 0)
                return;
            Form2 frm2 = new Form2();
            frm2.StudentEvent += manageStudentList;

            //GET STUDENT OBJECT FROM LISTBOX
            string[] data = lstStudents.SelectedItem.ToString().Split(":");
            Student student = new Student();
            student.index = lstStudents.SelectedIndex;
            student.name = data[0];
            student.grade = int.Parse(data[1]);
            frm2.currentStudent = student;

            frm2.ShowDialog();
        }
    }
}