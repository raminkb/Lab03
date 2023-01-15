namespace Lab03
{
    public partial class Form1 : Form
    {
        //array <-> List
        List<Student> _students = new List<Student>();
        //max min GPA
        double maxIGPA = 0;
        double minIGPA = int.MaxValue;
        int NumStudent = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //get value from textbox
            String name = this.textBoxName.Text;
            String id = this.textBoxID.Text;
            String year = this.textBoxBirhtY.Text;
            String height = this.textBoxHeight.Text;
            String gpa = this.textBoxGPA.Text;
            String major = this.textBoxMajor.Text;
            //convert string to in
            int iYear = Int32.Parse(year);
            int iHeight = Int32.Parse(height);
            double iGPA = double.Parse(gpa);


            //create obj from Student
            Student newStudent = new Student(name, id, iYear, iHeight, iGPA , major);
            //Add new student to list
            this._students.Add(newStudent);

            //max min
            if(iGPA>maxIGPA)
            {
                maxIGPA = iGPA;
            }
            if(iGPA<minIGPA)
            {
                minIGPA = iGPA;
            }

            //NumStudent
            NumStudent = NumStudent + 1;

            //clear textbox
            this.textBoxName.Text = "";
            this.textBoxID.Text = "";
            this.textBoxBirhtY.Text = "";
            this.textBoxHeight.Text = "";
            this.textBoxGPA.Text = "";
            this.textBoxMajor.Text = "";
            this.textBoxMaxGPA.Text = "";
            this.textBoxMinGPA.Text = "";
            this.textBoxNumS.Text = "";

            //display max min GPA
            this.textBoxMaxGPA.Text = this.textBoxMaxGPA.Text + maxIGPA; 
            this.textBoxMinGPA.Text = this.textBoxMinGPA.Text + minIGPA;

            //display numstudent
            this.textBoxNumS.Text = this.textBoxNumS.Text + NumStudent;
            
            // add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._students;
            this.dataGridView1.DataSource = source;
            
            
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }