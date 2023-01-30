namespace LAB4
{
    public partial class Form1 : Form
    {
        private Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.tBoxName.Text;
            int year = int.Parse(this.tBoxbirthYear.Text);
            double GPA = double.Parse(this.tBoxGPA.Text);

            Person person = new Person(name, year, GPA);
            this.classroom.addPerson(person);

            tBoxName1.Text = this.classroom.ShowPerson();
            tBoxAge.Text = this.classroom.ShowAllAge().ToString();
            this.classroom.SetGPA();
            this.tBoxMax.Text = this.classroom.ShowGPAMax().ToString();
            this.tBoxMin.Text = this.classroom.ShowGPAMin().ToString();
            this.tBoxMax.Text = this.classroom.ShowGPAMaxName2();
            this.tBoxMin.Text = this.classroom.ShowGPAMinName3();
        }
    }
}