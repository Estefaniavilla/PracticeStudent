using System.Diagnostics;

namespace PracticeStudent
{
    public partial class Form1 : Form
    {
        string txtMotherLastname;
        string txtLastName;
        string txtName;
        int Grade;
        private object txtbox1;
        private object nup;
        private object txtbox;
        private object dt1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtLastName = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtMotherLastname = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbox1 != null && txtbox1 != null && txtbox1 != null)
            {
                while (true)
                {
                    try
                    {
                        Grade = Convert.ToInt32(nup.Value);
                        break;

                    }
                    catch (FormatException)
                    {
                        txtbox.Text = "Please enter a right Grade";



                    }
                }

                NamePerson n1 = new NamePerson(txtbox1.Text, label2.Text, label3.Text);


                DateTime dt = dt1.Value;
                Student n3 = new Student(txtbox1.Text, label2.Text, label3.Text, dt, label4.Text, label5.Text, Grade);

                txtbox.Text = Convert.ToString(n3.Birthdate);
                txtbox.Text = Convert.ToString(n3.Grade);

                txtbox.Text = n3.ToString();
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnd_Click(object sender, EventArgs e)
        {

            label1.Clear();
            label2.Clear();
            label3.Clear();
            label4.Clear();
            label5.Clear();
            txtbox.Clear();
            nup.Value = 0;

        }
    }
}

