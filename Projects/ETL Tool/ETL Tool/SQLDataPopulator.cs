using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ETL_Tool {
    class SQLDataPopulator {

        String connectionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;


        public SQLDataPopulator(String connectionString) {
            this.connectionString = connectionString;
        }

        private string stripQuoteMarks(string theStringToStrip) {
            theStringToStrip = theStringToStrip.Replace("\"", "");
            theStringToStrip = theStringToStrip.Replace("'", "");
            return theStringToStrip;
        }


        public bool populateStudent(List<StudentDetail> students) {

            bool toReturn = false;

            foreach (StudentDetail student in students) {


                try {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    int S_Donee;
                    int Z_Donee;

                    if (student.is_S_Donee == true) {
                        S_Donee = 1;
                    } else {
                        S_Donee = 0;
                    }

                    if (student.is_Z_Donee == true) {
                        Z_Donee = 1;
                    } else {
                        Z_Donee = 0;
                    }

                    String insertionQuery = "INSERT INTO Student_Detail_Dim (student_detail_dim_id, enrollment_detail_id, student_id, name, gender, date_of_birth, mobile_phone, telephone, address, is_Z_Donee, is_S_Donee, section_id, section_name, class_id, class_name, subject_detail_id, course_id, course_name, course_description, subject_id, subject_name, subject_description) VALUES (";
                   
                    //str = string.Format("Name: {0}, Age: {1}", name, age); ANOTHER WAY TO DO IT

                    var builder = new StringBuilder();
                    builder.Append("" + student.enrollment_detail_id + ", ");
                    builder.Append("" + student.enrollment_detail_id + ", ");
                    builder.Append("" + student.student_id + ", ");
                    builder.Append("'" + stripQuoteMarks(student.first_name) + " " + stripQuoteMarks(student.last_name) + "', ");
                    builder.Append("'" + student.gender + "', ");
                    builder.Append("'" + student.date_of_birth.Date + "', ");
                    builder.Append("'" + student.mobile_phone + "', ");
                    builder.Append("'" + student.telephone + "', ");
                    builder.Append("'" + stripQuoteMarks(student.address) + "', ");
                    builder.Append("" + Z_Donee + ", ");
                    builder.Append("" + S_Donee + ", ");

                    builder.Append("" + student.section_id + ", ");
                    builder.Append("'" + student.section_name + "', ");
                    builder.Append("" + student.class_id + ", ");
                    builder.Append("'" + student.class_name + "', ");
                    builder.Append("" + student.subject_detail_id + ", ");
                    builder.Append("" + student.course_id + ", ");
                    builder.Append("'" + student.course_name + "', ");
                    builder.Append("'" + student.course_description + "', ");
                    builder.Append("" + student.subject_id + ", ");
                    builder.Append("'" + student.subject_name + "', ");
                    builder.Append("'" + student.subject_description + "' ");
                    builder.Append(");");
                    insertionQuery = insertionQuery + builder.ToString();
                   
                    command = new SqlCommand(insertionQuery, connection);

                    Console.WriteLine(insertionQuery);

                    command.ExecuteNonQuery();
                    connection.Close();
                    toReturn = true;

                } catch (Exception e) {
                    Console.WriteLine("Exception occured while creating table:" + e.Message + "\t" + e.GetType());
                    toReturn = false;
                }
            }
            return toReturn;
        }

        public bool populateTeachers(List<Teacher> teachers) {

            bool toReturn = false;

            foreach (Teacher teacher in teachers) {


                try {
                    connection = new SqlConnection(connectionString);
                    connection.Open();


                    String insertionQuery = "INSERT INTO Teacher_Detail_Dim (teacher_detail_dim_id, teaching_detail_id, teacher_id, name, gender, date_of_birth, mobile_phone, telephone, address, referrer, education, reference, experience, section_id, section_name, class_id, class_name, subject_detail_id, course_id, course_name, course_description, subject_id, subject_name, subject_description) VALUES (";

                    var builder = new StringBuilder();
                    builder.Append("" + teacher.teaching_detail_id + ", ");
                    builder.Append("" + teacher.teaching_detail_id + ", ");
                    builder.Append("" + teacher.teacher_id + ", ");
                    builder.Append("'" + stripQuoteMarks(teacher.first_name) + " " + stripQuoteMarks(teacher.last_name) + "', ");
                    builder.Append("'" + teacher.gender + "', ");
                    builder.Append("'" + teacher.date_of_birth + "', ");
                    builder.Append("'" + teacher.mobile_phone + "', ");
                    builder.Append("'" + teacher.telephone + "', ");
                    builder.Append("'" + stripQuoteMarks(teacher.address) + "', ");
                    builder.Append("'" + stripQuoteMarks(teacher.referrer) + "', ");
                    builder.Append("'" + stripQuoteMarks(teacher.education) + "', ");
                    builder.Append("'" + stripQuoteMarks(teacher.reference) + "', ");
                    builder.Append("" + teacher.experience + ", ");

                    builder.Append("" + teacher.section_id + ", ");
                    builder.Append("'" + teacher.section_name + "', ");
                    builder.Append("" + teacher.class_id + ", ");
                    builder.Append("'" + teacher.class_name + "', ");
                    builder.Append("" + teacher.subject_detail_id + ", ");
                    builder.Append("" + teacher.course_id + ", ");
                    builder.Append("'" + teacher.course_name + "', ");
                    builder.Append("'" + teacher.course_description + "', ");
                    builder.Append("" + teacher.subject_id + ", ");
                    builder.Append("'" + teacher.subject_name + "', ");
                    builder.Append("'" + teacher.subject_description + "' ");
                    builder.Append(");");
                    insertionQuery = insertionQuery + builder.ToString();

                    command = new SqlCommand(insertionQuery, connection);

                    Console.WriteLine(insertionQuery);

                    command.ExecuteNonQuery();
                    connection.Close();
                    toReturn = true;

                } catch (Exception e) {
                    Console.WriteLine("Exception occured while creating table:" + e.Message + "\t" + e.GetType());
                    toReturn = false;
                }
            }
            return toReturn;
        }


        public bool populateSubjects(List<Subject> subjects) {

            bool toReturn = false;

            foreach (Subject subject in subjects) {


                try {
                    connection = new SqlConnection(connectionString);
                    connection.Open();


                    String insertionQuery = "insert into Subject_Dim (subject_dim_id, subject_id, name, description) values (";

                    var builder = new StringBuilder();
                    builder.Append("" + subject.subject_id + ", ");
                    builder.Append("" + subject.subject_id + ", ");
                    builder.Append("'" + stripQuoteMarks(subject.name) + "', ");
                    builder.Append("'" + stripQuoteMarks(subject.description) + "' ");
                    builder.Append(");");
                    insertionQuery = insertionQuery + builder.ToString();

                    command = new SqlCommand(insertionQuery, connection);

                    Console.WriteLine(insertionQuery);

                    command.ExecuteNonQuery();
                    connection.Close();
                    toReturn = true;

                } catch (Exception e) {
                    Console.WriteLine("Exception occured while creating table:" + e.Message + "\t" + e.GetType());
                    toReturn = false;
                }
            }
            return toReturn;
        }

        


        public bool populateDates(List<Exam> exams) {

            bool toReturn = false;

            foreach (Exam exam in exams) {


                try {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    int dayOfExamWeek = (int)exam.date_of_exam.DayOfWeek;
                    int dayOfExamMonth = (int)exam.date_of_exam.Day;
                    int monthOfExam = (int)exam.date_of_exam.Month;
                    int yearOfExam = (int)exam.date_of_exam.Year;

                    String insertionQuery = "insert into Date_Dim (date, dayOfWeek, dayOfMonth, month, year) values (";

                    var builder = new StringBuilder();
                    builder.Append("'" + exam.date_of_exam.Date + "', ");
                    builder.Append("" + dayOfExamWeek + ", ");
                    builder.Append("" + dayOfExamMonth + ", ");
                    builder.Append("" + monthOfExam + ", ");
                    builder.Append("" + yearOfExam + " ");
                    builder.Append(");");
                    insertionQuery = insertionQuery + builder.ToString();

                    command = new SqlCommand(insertionQuery, connection);

                    Console.WriteLine(insertionQuery);

                    command.ExecuteNonQuery();
                    connection.Close();
                    toReturn = true;

                } catch (Exception e) {
                    Console.WriteLine("Exception occured while creating table:" + e.Message + "\t" + e.GetType());
                    toReturn = false;
                }
            }
            return toReturn;
        }





        public bool populateExams(List<Exam> exams) {

            bool toReturn = false;

            int numberOfExamRecord = 0;
            foreach (Exam exam in exams) {
                numberOfExamRecord++;

                try {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    String insertionQuery = "insert into Exams_Fact (exams_fact_id, exam_id, student_detail_dim_id, teacher_detail_dim_id, subject_dim_id, date_dim_id, total_marks, obtained_marks) values (";

                    var builder = new StringBuilder();
                    builder.Append("" + exam.exam_id + ", ");
                    builder.Append("" + exam.exam_id + ", ");
                    builder.Append("" + exam.student_detail_dim_id + ", ");
                    builder.Append("" + exam.teacher_detail_dim_id + ", ");
                    builder.Append("" + exam.subject_id + ", ");
                    builder.Append("" + numberOfExamRecord + ", ");
                    builder.Append("" + exam.total_marks + ", ");
                    builder.Append("" + exam.obtained_marks + " ");
                    builder.Append(");");
                    insertionQuery = insertionQuery + builder.ToString();

                    command = new SqlCommand(insertionQuery, connection);

                    Console.WriteLine(insertionQuery);

                    command.ExecuteNonQuery();
                    connection.Close();
                    toReturn = true;

                } catch (Exception e) {
                    Console.WriteLine("Exception occured while creating table:" + e.Message + "\t" + e.GetType());
                    toReturn = false;
                }
            }
            return toReturn;
        }

    }
    }






