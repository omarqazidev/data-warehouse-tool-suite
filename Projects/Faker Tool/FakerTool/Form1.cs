using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace FakerTool {
    public partial class Form1 : MaterialForm {

        string databaseCreationScript = "";
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {


        }

        private void button3_Click(object sender, EventArgs e) {
            
        }

        private void button2_Click(object sender, EventArgs e) {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) {
            materialLabel1.Text = "Generated Data:";
            DataFabricator fabricator = new DataFabricator();

            fabricator.fabricateLists();



            textBox1.Text =
                fabricator.getStudentSQL() + Environment.NewLine +
                fabricator.getStaffSQL() + Environment.NewLine +
                fabricator.getAdminSQL() + Environment.NewLine +
                fabricator.getCourseSQL() + Environment.NewLine +
                fabricator.getSubjectSQL() + Environment.NewLine +
                fabricator.getSubjectDetailSQL() + Environment.NewLine +
                fabricator.getClassSQL() + Environment.NewLine +
                fabricator.getSectionSQL() + Environment.NewLine +
                fabricator.getFeeSQL() + Environment.NewLine +
                fabricator.getFeeDetailSQL() + Environment.NewLine +
                fabricator.getFundSQL() + Environment.NewLine +
                fabricator.getOtherFundingSQL() + Environment.NewLine +
                fabricator.getZDonationSQL() + Environment.NewLine +
                fabricator.getSDonationSQL() + Environment.NewLine +
                fabricator.getGuardianSQL() + Environment.NewLine +
                fabricator.getGuardianDetailSQL() + Environment.NewLine +
                fabricator.getRegistrationSQL() + Environment.NewLine +
                fabricator.getSalarySQL() + Environment.NewLine +
                fabricator.getSalaryDetailSQL() + Environment.NewLine +
                fabricator.getTeacherSQL() + Environment.NewLine +
                fabricator.getTeachingDetailSQL() + Environment.NewLine +
                fabricator.getEnrollmentDetailSQL() + Environment.NewLine +
                fabricator.getExamSQL() + Environment.NewLine +
                "";


        }

        private void materialRaisedButton2_Click(object sender, EventArgs e) {
            Clipboard.SetText(textBox1.Text);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e) {
            MessageBox.Show("A Data Faker and Fabrication Tool");
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e) {
            materialRaisedButton4_Click(sender, e);
        }

        private void exiToolStripMenuItem_Click(object sender, EventArgs e) {
            materialRaisedButton3_Click(sender, e);
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e) {
            materialRaisedButton2_Click(sender, e);
        }

        private void genToolStripMenuItem_Click(object sender, EventArgs e) {
            materialRaisedButton1_Click(sender, e);
        }

        private void getDatabaseCreationSQLToolStripMenuItem_Click(object sender, EventArgs e) {
            textBox1.Text = databaseCreationScript;
            materialLabel1.Text = "Database Creation Script:";
        }

        private void Form1_Load(object sender, EventArgs e) {
            databaseCreationScript = textBox1.Text;
        }
    }
}




/*
Person person1 = new Person();
            Student student1 = new Student();
            Staff staff1 = new Staff();
            Admin admin1 = new Admin();
            Course course1 = new Course();
            Subject subject1 = new Subject();

            SubjectDetail subjectDetail1 = new SubjectDetail(33, 56);
            Class class1 = new Class(23);
            Section section1 = new Section(12);

            Fee fee1 = new Fee();
            FeeDetail feeDetail1 = new FeeDetail(2,3);

            Guardian guardian1 = new Guardian();
            GuardianDetail guardianDetail1 = new GuardianDetail(2, 3);

            Fund fund1 = new Fund(2);

            OtherFunding otherfunding1 = new OtherFunding(22);
            ZDonation zdonation1 = new ZDonation(65);
            SDonation sdonation1 = new SDonation(33);

            Registration registration = new Registration(3, 4);


            Salary salary = new Salary();
            SalaryDetail salaryDetail = new SalaryDetail(1, 1);

            Teacher teacher1 = new Teacher(1);

            TeachingDetail teachingDetail1 = new TeachingDetail(2, 3);
            EnrollmentDetail enrollmentDetail1 = new EnrollmentDetail(5, 25);

            Exam exam1 = new Exam(1, 2, 3);

 


*/


