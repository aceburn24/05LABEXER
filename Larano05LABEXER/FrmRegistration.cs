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

namespace Larano05LABEXER
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string getStudentNo = txtStudentNo.Text;
            string getLastName = txtLastName.Text;
            string getAge = txtAge.Text;
            string getBirthday = datePickerBirthday.Text;
            string getContactNo = txtContactNo.Text;
            string getGender = cbGender.Text;
            string getMid = txtMiddleInitial.Text;
            string getProgram = cbPrograms.Text;
            string getFirstName = txtFirstName.Text;
            string setFileName = String.Concat(getStudentNo, ".txt");
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter (Path.Combine(docpath, setFileName));

            string[] info = {"Student No. " + getStudentNo, "Full name: " + getFirstName + " " + getMid + " " + getLastName,
                "Program: " + getProgram, "Gender: " + getGender, "Age: " + getAge, "Birthday: " + getBirthday, "Contact No. " + getContactNo};

            Console.WriteLine(getStudentNo);
            foreach (string i in info)
            outputFile.WriteLine(i);
            outputFile.Close();
            Close();


        }
    }
}
