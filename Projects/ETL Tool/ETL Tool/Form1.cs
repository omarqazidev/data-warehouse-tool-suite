using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace ETL_Tool {
    public partial class Form1 : MaterialForm {

        SQLDataRetriever dataRetriever;
        public Form1() {
            InitializeComponent();
            
            /*
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple100, Primary.DeepPurple400,
                Primary.Yellow100, Accent.Green100,
                TextShade.WHITE
            );
            */
        }

        private void button1_Click(object sender, EventArgs e) {

            dataRetriever = new SQLDataRetriever(textBox1.Text);
            if (dataRetriever.readDataIntoColumns()) {
                MessageBox.Show("Data loaded into the Transer Tool");
            } else {
                MessageBox.Show("Data cannot be loaded into the Transer Tool");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void button2_Click(object sender, EventArgs e) {

            bool dataPopulated = true;

            SQLDataPopulator dataPopulator = new SQLDataPopulator(textBox2.Text);

            if (!dataPopulator.populateStudent(dataRetriever.students)) { dataPopulated = false; };
            if (!dataPopulator.populateTeachers(dataRetriever.teachers)) { dataPopulated = false; };
            if (!dataPopulator.populateSubjects(dataRetriever.subjects)) { dataPopulated = false; };
            if (!dataPopulator.populateDates(dataRetriever.exams)) { dataPopulated = false; };
            if (!dataPopulator.populateExams(dataRetriever.exams)) { dataPopulated = false; };

            if (dataPopulated) {
                MessageBox.Show("Data has been populated into the Data Warehouse");
            } else {
                MessageBox.Show("Data cannot be populated into the Data Warehouse");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) {
            dataRetriever = new SQLDataRetriever(textBox1.Text);
            if (dataRetriever.readDataIntoColumns()) {
                MessageBox.Show("Data loaded into the Transer Tool");
            } else {
                MessageBox.Show("Data cannot be loaded into the Transer Tool");
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e) {

            bool dataPopulated = true;

            SQLDataPopulator dataPopulator = new SQLDataPopulator(textBox2.Text);

            if (!dataPopulator.populateStudent(dataRetriever.students)) { dataPopulated = false; };
            if (!dataPopulator.populateTeachers(dataRetriever.teachers)) { dataPopulated = false; };
            if (!dataPopulator.populateSubjects(dataRetriever.subjects)) { dataPopulated = false; };
            if (!dataPopulator.populateDates(dataRetriever.exams)) { dataPopulated = false; };
            if (!dataPopulator.populateExams(dataRetriever.exams)) { dataPopulated = false; };

            if (dataPopulated) {
                MessageBox.Show("Data has been populated into the Data Warehouse");
            } else {
                MessageBox.Show("Data cannot be populated into the Data Warehouse");
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e) {
            MessageBox.Show("This an ETL Tool for the School DB to DW project ");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            materialRaisedButton4_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            materialRaisedButton3_Click(sender, e);
        }

        private void populateDWToolStripMenuItem_Click(object sender, EventArgs e) {
            materialRaisedButton2_Click(sender, e);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            materialRaisedButton1_Click(sender, e);
        }
    }
}
