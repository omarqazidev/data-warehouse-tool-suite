using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

namespace AnalysisTool {
    public partial class Form1 : Form {

        string stringDWJoins;
        string stringDWJoinsOnly;
        public Form1() {
            InitializeComponent();

        }
        

        private void getDataIntoDataGridView() {
            

        }
        

        private void flatButton3_Click(object sender, EventArgs e) {
            flatTabControl1.SelectedIndex = (flatTabControl1.SelectedIndex + 1 < flatTabControl1.TabCount) ? flatTabControl1.SelectedIndex + 1 : flatTabControl1.SelectedIndex;
        }

        private void flatButton2_Click_1(object sender, EventArgs e) {
            dbHandler handler = new dbHandler();
            List<String> lst = handler.getTableNames(textBox1.Text);
            flatComboBox1.DataSource = lst;
        }

        private void flatButton1_Click_1(object sender, EventArgs e) {



            if (flatComboBox1.SelectedItem != null) {
                dbHandler handler = new dbHandler();
                DataSet ds = handler.getInDataSet(flatComboBox1.SelectedItem.ToString(), textBox1.Text);
                if (ds.Tables.Count > 0) {
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Refresh();
                } else {
                    MessageBox.Show("Empty or Wrong Table");
                }

               
            } else {
                MessageBox.Show("Please select a table first");

            }
        }

        private void tab2_Click(object sender, EventArgs e) {

        }

        private void flatButton4_Click(object sender, EventArgs e) {
            flatTabControl1.SelectedIndex = (flatTabControl1.SelectedIndex + 1 < flatTabControl1.TabCount) ? flatTabControl1.SelectedIndex + 1 : flatTabControl1.SelectedIndex;
        }

        private void flatButton5_Click(object sender, EventArgs e) {
            flatTabControl1.SelectedIndex = (flatTabControl1.SelectedIndex - 1 > -1) ? flatTabControl1.SelectedIndex - 1 : flatTabControl1.SelectedIndex;
        }

        private void saveToExcelToolStripMenuItem_Click(object sender, EventArgs e) {

            string saveExcelFileString = "excelfile.xls";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Excel File";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                saveExcelFileString = saveFileDialog1.FileName;
            }

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dataGridView1.RowCount - 1; i++) {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++) {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            
            xlWorkBook.SaveAs(saveExcelFileString, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file " + saveExcelFileString);

        }


        private void releaseObject(object obj) {
            try {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            } catch (Exception ex) {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            } finally {
                GC.Collect();
            }
        }

        private void tab3_Click(object sender, EventArgs e) {

        }

        private void flatComboBox6_SelectedIndexChanged(object sender, EventArgs e) {
            dbHandler handler = new dbHandler();

            
            
            flatComboBox2.DataSource = handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString());
            flatComboBox3.DataSource = insertEmptySpaceOnTop(handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString()));
            flatComboBox5.DataSource = insertEmptySpaceOnTop(handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString()));
            flatComboBox4.DataSource = insertEmptySpaceOnTop(handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString()));
            flatComboBox7.DataSource = insertEmptySpaceOnTop(handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString()));
            flatComboBox12.DataSource = insertEmptySpaceOnTop(handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString()));
            flatComboBox9.DataSource = insertEmptySpaceOnTop(handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString()));
            flatComboBox10.DataSource = insertEmptySpaceOnTop(handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString()));
            flatComboBox14.DataSource = insertEmptySpaceOnTop(handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString()));
        }

        private void flatButton6_Click(object sender, EventArgs e) {
            dbHandler handler = new dbHandler();
            List<String> lst = handler.getTableNames(textBox1.Text);
            flatComboBox6.DataSource = lst;
        }


       

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }



        private List<string> insertEmptySpaceOnTop(List<string> lst) {
            lst.Insert(0, "");
            return lst;
        }

        private void flatButton7_Click(object sender, EventArgs e) {
            

            if(flatComboBox2.SelectedItem !=null && flatComboBox6.SelectedItem != null) {
                string query = "";
                query = query + "SELECT ";

                if (flatCheckBox1.Checked == true) {
                    query = query + "DISTINCT ";
                }

                query = query + flatComboBox2.SelectedItem.ToString() + "";
                if (flatComboBox3.SelectedItem.ToString() != "") {
                    query = query + ", " + flatComboBox3.SelectedItem.ToString() + "";
                }
                if (flatComboBox5.SelectedItem.ToString() != "") {
                    query = query + ", " + flatComboBox5.SelectedItem.ToString() + "";
                }
                if (flatComboBox4.SelectedItem.ToString() != "") {
                    query = query + ", " + flatComboBox4.SelectedItem.ToString() + "";
                }

                query = query + " FROM " + flatComboBox6.SelectedItem.ToString();


                if (flatComboBox7.SelectedItem.ToString() != "" && flatComboBox8.SelectedItem != null && flatTextBox1.Text != "") {
                    query = query + " WHERE ";
                    query = query + " " + flatComboBox7.SelectedItem.ToString() + "";
                    query = query + " " + flatComboBox8.SelectedItem.ToString() + "";
                    query = query + " " + flatTextBox1.Text + "";
                    if (flatComboBox14.SelectedItem.ToString() != "" && flatComboBox11.SelectedItem != null && flatComboBox13.SelectedItem != null && flatTextBox2.Text != "") {
                        query = query + " " + flatComboBox11.SelectedItem.ToString() + "";
                        query = query + " " + flatComboBox14.SelectedItem.ToString() + "";
                        query = query + " " + flatComboBox13.SelectedItem.ToString() + "";
                        query = query + " " + flatTextBox2.Text + "";
                    }
                }

                if (flatComboBox12.SelectedItem.ToString() != "" && (flatComboBox12.SelectedItem.ToString() == flatComboBox2.SelectedItem.ToString() || flatComboBox12.SelectedItem.ToString() == flatComboBox3.SelectedItem.ToString() || flatComboBox12.SelectedItem.ToString() == flatComboBox5.SelectedItem.ToString() || flatComboBox12.SelectedItem.ToString() == flatComboBox4.SelectedItem.ToString())) {
                    query = query + " ORDER BY ";
                    query = query + " " + flatComboBox12.SelectedItem.ToString() + "";
                    if (flatRadioButton1.Checked == true) {
                        query = query + " ASC";
                    } else {
                        query = query + " DESC";
                    }

                    if (flatComboBox9.SelectedItem.ToString() != "" && (flatComboBox9.SelectedItem.ToString() == flatComboBox2.SelectedItem.ToString() || flatComboBox9.SelectedItem.ToString() == flatComboBox3.SelectedItem.ToString() || flatComboBox9.SelectedItem.ToString() == flatComboBox5.SelectedItem.ToString() || flatComboBox9.SelectedItem.ToString() == flatComboBox4.SelectedItem.ToString())) {
                        query = query + ", " + flatComboBox9.SelectedItem.ToString() + "";
                        if (flatRadioButton4.Checked == true) {
                            query = query + " ASC";
                        } else {
                            query = query + " DESC";
                        }

                        if (flatComboBox10.SelectedItem.ToString() != "" && (flatComboBox10.SelectedItem.ToString() == flatComboBox2.SelectedItem.ToString() || flatComboBox10.SelectedItem.ToString() == flatComboBox3.SelectedItem.ToString() || flatComboBox10.SelectedItem.ToString() == flatComboBox5.SelectedItem.ToString() || flatComboBox10.SelectedItem.ToString() == flatComboBox4.SelectedItem.ToString())) {
                            query = query + ", " + flatComboBox10.SelectedItem.ToString() + "";
                            if (flatRadioButton6.Checked == true) {
                                query = query + " ASC";
                            } else {
                                query = query + " DESC";
                            }
                        }
                    }

                }
                flatTextBox3.Text = query;
            } else {
                MessageBox.Show("Please select a table first");
            }
            
        }

        private void flatButton9_Click(object sender, EventArgs e) {
            flatTabControl1.SelectedIndex = (flatTabControl1.SelectedIndex + 1 < flatTabControl1.TabCount) ? flatTabControl1.SelectedIndex + 1 : flatTabControl1.SelectedIndex;
        }

        private void flatButton8_Click(object sender, EventArgs e) {
            flatTabControl1.SelectedIndex = (flatTabControl1.SelectedIndex - 1 > -1) ? flatTabControl1.SelectedIndex - 1 : flatTabControl1.SelectedIndex;
        }

        private void flatButton10_Click(object sender, EventArgs e) {
            
            flatButton7_Click(sender, e);
            if (flatTextBox3.Text != "") {
                if (flatComboBox6.SelectedItem != null) {
                    dbHandler handler = new dbHandler();
                    DataSet dataSet = handler.getCustomQueryInDataSet(textBox1.Text, flatTextBox3.Text);
                    if (dataSet.Tables.Count > 0) { 
                        dataGridView2.DataSource = dataSet.Tables[0];
                        dataGridView2.Refresh();
                    } else {
                        MessageBox.Show("Empty or Wrong Table");
                    }
                    
                } else {
                    MessageBox.Show("Please select a table first");

                }
            } else {
                MessageBox.Show("Please generate a query first");
            }

            
        }

        private void flatButton14_Click(object sender, EventArgs e) {


            if (selectCB1.SelectedItem != null) {
                string query = "";
                query = query + "SELECT ";

                if (distinctCheckBox.Checked == true) {
                    query = query + "DISTINCT ";
                }

                query = query + selectCB1.SelectedItem.ToString() + "";
                if (selectCB2.SelectedItem.ToString() != "") {
                    query = query + ", " + selectCB2.SelectedItem.ToString() + "";
                }
                if (selectCB3.SelectedItem.ToString() != "") {
                    query = query + ", " + selectCB3.SelectedItem.ToString() + "";
                }
                if (selectCB4.SelectedItem.ToString() != "") {
                    query = query + ", " + selectCB4.SelectedItem.ToString() + "";
                }

                query = query + " FROM " + dwjoinsFlatTextBox1.Text;


                if (whereCB1.SelectedItem.ToString() != "" && whereOperatorCB1.SelectedItem != null && whereTextBox1.Text != "") {
                    query = query + " WHERE ";
                    query = query + " " + whereCB1.SelectedItem.ToString() + "";
                    query = query + " " + whereOperatorCB1.SelectedItem.ToString() + "";
                    query = query + " " + whereTextBox1.Text + "";

                    if (whereCB2.SelectedItem.ToString() != "" && whereConditionalCB1.SelectedItem != null && whereOperatorCB2.SelectedItem != null && whereTextBox2.Text != "") {
                        query = query + " " + whereConditionalCB1.SelectedItem.ToString() + "";
                        query = query + " " + whereCB2.SelectedItem.ToString() + "";
                        query = query + " " + whereOperatorCB2.SelectedItem.ToString() + "";
                        query = query + " " + whereTextBox2.Text + "";
                    }
                }

                if (orderCB1.SelectedItem.ToString() != "" && (orderCB1.SelectedItem.ToString() == selectCB1.SelectedItem.ToString() || orderCB1.SelectedItem.ToString() == selectCB2.SelectedItem.ToString() || orderCB1.SelectedItem.ToString() == selectCB3.SelectedItem.ToString() || orderCB1.SelectedItem.ToString() == selectCB4.SelectedItem.ToString())) {
                    query = query + " ORDER BY ";
                    query = query + " " + orderCB1.SelectedItem.ToString() + "";
                    if (descCheckBox1.Checked == false) {
                        query = query + " ASC";
                    } else {
                        query = query + " DESC";
                    }

                    if (orderCB2.SelectedItem.ToString() != "" && (orderCB2.SelectedItem.ToString() == selectCB1.SelectedItem.ToString() || orderCB2.SelectedItem.ToString() == selectCB2.SelectedItem.ToString() || orderCB2.SelectedItem.ToString() == selectCB3.SelectedItem.ToString() || orderCB2.SelectedItem.ToString() == selectCB4.SelectedItem.ToString())) {
                        query = query + ", " + orderCB2.SelectedItem.ToString() + "";
                        if (descCheckBox2.Checked == false) {
                            query = query + " ASC";
                        } else {
                            query = query + " DESC";
                        }

                        if (orderCB3.SelectedItem.ToString() != "" && (orderCB3.SelectedItem.ToString() == selectCB1.SelectedItem.ToString() || orderCB3.SelectedItem.ToString() == selectCB2.SelectedItem.ToString() || orderCB3.SelectedItem.ToString() == selectCB3.SelectedItem.ToString() || orderCB3.SelectedItem.ToString() == selectCB4.SelectedItem.ToString())) {
                            query = query + ", " + orderCB3.SelectedItem.ToString() + "";
                            if (descCheckBox3.Checked == false) {
                                query = query + " ASC";
                            } else {
                                query = query + " DESC";
                            }
                        }
                    }

                }
                resultFlatTextBox1.Text = query;
            } else {
                MessageBox.Show("Please load data first");
            }
        }

        private void flatButton15_Click(object sender, EventArgs e) {

            List<string> list = new List<string>();
            dbHandler handler = new dbHandler();

            selectCB1.DataSource = getColumns(handler.getCustomQueryInDataSet(textBox1.Text, stringDWJoins));
            selectCB2.DataSource = insertEmptySpaceOnTop(getColumns(handler.getCustomQueryInDataSet(textBox1.Text, stringDWJoins)));
            selectCB3.DataSource = insertEmptySpaceOnTop(getColumns(handler.getCustomQueryInDataSet(textBox1.Text, stringDWJoins)));
            selectCB4.DataSource = insertEmptySpaceOnTop(getColumns(handler.getCustomQueryInDataSet(textBox1.Text, stringDWJoins)));
            whereCB1.DataSource = insertEmptySpaceOnTop(getColumns(handler.getCustomQueryInDataSet(textBox1.Text, stringDWJoins)));
            whereCB2.DataSource = insertEmptySpaceOnTop(getColumns(handler.getCustomQueryInDataSet(textBox1.Text, stringDWJoins)));
            orderCB1.DataSource = insertEmptySpaceOnTop(getColumns(handler.getCustomQueryInDataSet(textBox1.Text, stringDWJoins)));
            orderCB2.DataSource = insertEmptySpaceOnTop(getColumns(handler.getCustomQueryInDataSet(textBox1.Text, stringDWJoins)));
            orderCB3.DataSource = insertEmptySpaceOnTop(getColumns(handler.getCustomQueryInDataSet(textBox1.Text, stringDWJoins)));


            //flatComboBox2.DataSource = handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString());
            //flatComboBox3.DataSource = insertEmptySpaceOnTop(handler.getColumNames(textBox1.Text, flatComboBox6.SelectedItem.ToString()));

        }


        private List<string> getColumns(DataSet dataSet) {
            List<string> list = new List<string>();
            if (dataSet.Tables.Count > 0) {
                foreach (DataColumn column in dataSet.Tables[0].Columns) {
                    list.Add(column.ColumnName);
                }
            }
            return list;
        }

        private void dwjoinsFlatTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label14_Click(object sender, EventArgs e) {

        }

        private void selectCB4_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void selectCB3_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void selectCB2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            stringDWJoins = "SELECT Date.date_dim_id as Date_Dim__date_dim_id, Date.date as Date_Dim__date, Date.dayOfWeek as Date_Dim__dayOfWeek, Date.dayOfMonth as Date_Dim__dayOfMonth, Date.month as Date_Dim__month, Date.year as Date_Dim__year, Teacher.teacher_detail_dim_id as Teacher_Detail_Dim__teacher_detail_dim_id, Teacher.teaching_detail_id as Teacher_Detail_Dim__teaching_detail_id, Teacher.teacher_id as Teacher_Detail_Dim__teacher_id, Teacher.name as Teacher_Detail_Dim__name, Teacher.gender as Teacher_Detail_Dim__gender, Teacher.date_of_birth as Teacher_Detail_Dim__date_of_birth, Teacher.mobile_phone as Teacher_Detail_Dim__mobile_phone, Teacher.telephone as Teacher_Detail_Dim__telephone, Teacher.address as Teacher_Detail_Dim__address, Teacher.referrer as Teacher_Detail_Dim__referrer, Teacher.education as Teacher_Detail_Dim__education, Teacher.reference as Teacher_Detail_Dim__reference, Teacher.experience as Teacher_Detail_Dim__experience, Teacher.section_id as Teacher_Detail_Dim__section_id, Teacher.section_name as Teacher_Detail_Dim__section_name, Teacher.class_id as Teacher_Detail_Dim__class_id, Teacher.class_name as Teacher_Detail_Dim__class_name, Teacher.subject_detail_id as Teacher_Detail_Dim__subject_detail_id, Teacher.course_id as Teacher_Detail_Dim__course_id, Teacher.course_name as Teacher_Detail_Dim__course_name, Teacher.course_description as Teacher_Detail_Dim__course_description, Teacher.subject_id as Teacher_Detail_Dim__subject_id, Teacher.subject_name as Teacher_Detail_Dim__subject_name, Teacher.subject_description as Teacher_Detail_Dim__subject_description, Student.student_detail_dim_id as Student_Detail_Dim__student_detail_dim_id, Student.enrollment_detail_id as Student_Detail_Dim__enrollment_detail_id, Student.student_id as Student_Detail_Dim__student_id, Student.name as Student_Detail_Dim__name, Student.gender as Student_Detail_Dim__gender, Student.date_of_birth as Student_Detail_Dim__date_of_birth, Student.mobile_phone as Student_Detail_Dim__mobile_phone, Student.telephone as Student_Detail_Dim__telephone, Student.address as Student_Detail_Dim__address, Student.is_Z_Donee as Student_Detail_Dim__is_Z_Donee, Student.is_S_Donee as Student_Detail_Dim__is_S_Donee, Student.section_id as Student_Detail_Dim__section_id, Student.section_name as Student_Detail_Dim__section_name, Student.class_id as Student_Detail_Dim__class_id, Student.class_name as Student_Detail_Dim__class_name, Student.subject_detail_id as Student_Detail_Dim__subject_detail_id, Student.course_id as Student_Detail_Dim__course_id, Student.course_name as Student_Detail_Dim__course_name, Student.course_description as Student_Detail_Dim__course_description, Student.subject_id as Student_Detail_Dim__subject_id, Student.subject_name as Student_Detail_Dim__subject_name, Student.subject_description as Student_Detail_Dim__subject_description, Subject.subject_dim_id as Subject_Dim__subject_dim_id, Subject.subject_id as Subject_Dim__subject_id, Subject.name as Subject_Dim__name, Subject.description as Subject_Dim__description, Exam.exams_fact_id as Exams_Fact__exams_fact_id, Exam.exam_id as Exams_Fact__exam_id, Exam.student_detail_dim_id as Exams_Fact__student_detail_dim_id, Exam.teacher_detail_dim_id as Exams_Fact__teacher_detail_dim_id, Exam.subject_dim_id as Exams_Fact__subject_dim_id, Exam.date_dim_id as Exams_Fact__date_dim_id, Exam.total_marks as Exams_Fact__total_marks, Exam.obtained_marks as Exams_Fact__obtained_marks FROM Exams_Fact as Exam INNER JOIN Student_Detail_Dim as Student on Exam.student_detail_dim_id = Student.student_detail_dim_id INNER JOIN Teacher_Detail_Dim as Teacher on Exam.teacher_detail_dim_id = Teacher.teacher_detail_dim_id INNER JOIN Date_Dim as Date on Exam.date_dim_id = Date.date_dim_id INNER JOIN Subject_Dim as Subject on Exam.subject_dim_id = Subject.subject_dim_id ";
            stringDWJoinsOnly = " Exams_Fact INNER JOIN Student_Detail_Dim on Exams_Fact.student_detail_dim_id = Student_Detail_Dim.student_detail_dim_id INNER JOIN Teacher_Detail_Dim on Exams_Fact.teacher_detail_dim_id = Teacher_Detail_Dim.teacher_detail_dim_id INNER JOIN Date_Dim on Exams_Fact.date_dim_id = Date_Dim.date_dim_id INNER JOIN Subject_Dim on Exams_Fact.subject_dim_id = Subject_Dim.subject_dim_id";

        }

        private void flatTextBox2_TextChanged(object sender, EventArgs e) {

        }

        private void queryExeBtn1_Click(object sender, EventArgs e) {
            flatButton14_Click(sender, e);

            string resultString = resultFlatTextBox1.Text;

            if (resultFlatTextBox1.Text != "") {


                resultString = resultString.Replace("__", ".");
                resultString = resultString.Replace("DW_JOINS", stringDWJoinsOnly);

                dbHandler handler = new dbHandler();
                DataSet dataSet = handler.getCustomQueryInDataSet(textBox1.Text, resultString);

                Clipboard.SetText(resultString);


                if (dataSet.Tables.Count > 0) {
                    dataGridView3.DataSource = dataSet.Tables[0];
                    dataGridView3.Refresh();
                } else {
                    MessageBox.Show("Empty or Wrong Table");
                }

                
            } else {
                MessageBox.Show("Please generate a query first");
            }

        }

        private void flatButton13_Click(object sender, EventArgs e) {
            flatTabControl1.SelectedIndex = (flatTabControl1.SelectedIndex + 1 < flatTabControl1.TabCount) ? flatTabControl1.SelectedIndex + 1 : flatTabControl1.SelectedIndex;
        }

        private void flatButton12_Click(object sender, EventArgs e) {
            flatTabControl1.SelectedIndex = (flatTabControl1.SelectedIndex - 1 > -1) ? flatTabControl1.SelectedIndex - 1 : flatTabControl1.SelectedIndex;
        }

        private void flatButton11_Click(object sender, EventArgs e) {
            dbHandler handler = new dbHandler();
            DataSet dataSet = handler.getCustomQueryInDataSet(textBox1.Text, textBox2.Text);
            if (dataSet.Tables.Count > 0) {
                dataGridView4.DataSource = dataSet.Tables[0];
                dataGridView4.Refresh();
            } else {
                MessageBox.Show("There might be some problem with yourr query");
            }
        }

        private void flatButton16_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void flatButton14_Click_1(object sender, EventArgs e) {
            flatTabControl1.SelectedIndex = (flatTabControl1.SelectedIndex - 1 > -1) ? flatTabControl1.SelectedIndex - 1 : flatTabControl1.SelectedIndex;
        }

        private void tab5_Click(object sender, EventArgs e) {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FlatContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            string saveExcelFileString = "excelfile.xls";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Excel File";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveExcelFileString = saveFileDialog1.FileName;
            }

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dataGridView2.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView2.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView2[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }


            xlWorkBook.SaveAs(saveExcelFileString, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file " + saveExcelFileString);
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string saveExcelFileString = "excelfile.xls";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Excel File";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveExcelFileString = saveFileDialog1.FileName;
            }

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dataGridView3.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView3.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView3[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }


            xlWorkBook.SaveAs(saveExcelFileString, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file " + saveExcelFileString);
        }

        private void ContextMenuForDG4_Opening(object sender, CancelEventArgs e)
        {
            string saveExcelFileString = "excelfile.xls";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Excel File";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveExcelFileString = saveFileDialog1.FileName;
            }

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            
            for (i = 0; i <= dataGridView4.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView4.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView4[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }


            xlWorkBook.SaveAs(saveExcelFileString, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file " + saveExcelFileString);
        }
    }
}
/*
 
      
        }

        private void flatButton8_Click(object sender, EventArgs e) {
            
     
     */


/*
String baseQ = "SELECT sum(a.TPurchase) as Total_Purchase_Amount, sum(a.Tsales) as Total_Sales_Amount, sum(a.Tprofit) as Total_Profit_Earned, sum(a.quantity) as Total_Quantity_Sold " +
"FROM FACT_TABLE as a " +
"INNER JOIN User_Dim as b ON a.userr_id = b.userr_id " +
"INNER JOIN Product_Dim c ON a.product_id = c.product_id " +
"LEFT JOIN Coupon_Dim d ON a.coupon_id =  d.coupon_id " +
"INNER JOIN Time_Dim e ON a.time_id =  e.time_id ";

String condQ = "WHERE ";

String couponQ = "";
*/
