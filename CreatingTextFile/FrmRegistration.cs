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

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        public static string SetFileName;
        private void button1_Click(object sender, EventArgs e)
        {
            

            string getStudNo = student.Text;
            string getProgram = program.Text;
            string getLastName = lastname.Text;
            string getFirstName = firstname.Text;
            string getMI = middleinitial.Text;
            string getAge = age.Text;
            string getGender = gender.Text;
            string getBirthday = birthday.Text;
            string getContactNo = contactno.Text;

            SetFileName = student.Text + ".txt";




            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            SetFileName)))
            {
                outputFile.WriteLine("Student No.: " + getStudNo);
                outputFile.WriteLine("Full Name : " + getLastName + ", " + getFirstName + ", " + getMI + ".");

                outputFile.WriteLine("Program: "+ getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No.: " + getContactNo);


            }
            Close();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
