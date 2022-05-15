using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_Tool {
    class SQLDataRetriever {

        String connectionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public List<StudentDetail> students = new List<StudentDetail>();
        public List<Teacher> teachers = new List<Teacher>();
        public List<Subject> subjects = new List<Subject>();
        public List<Exam> exams = new List<Exam>();


        //Data Source=DESKTOP-HALNTBS\SQLEXPRESS;Initial Catalog=theSchoolA;Integrated Security=True

        public SQLDataRetriever(String connectionString) {
            this.connectionString = connectionString;
        }
        


        public bool readDataIntoColumns() {

            bool toReturn = false;

            try {
                readDataIntoStudents();
                readDataIntoTeachers();
                readDataIntoSubjects();
                readDataIntoExams();
                toReturn = true;
            } catch {
                toReturn = false;
            }
            return toReturn;

        }

        public void readDataIntoStudents() {


            reader = null;
            connection = new SqlConnection(connectionString);
            string queryString = "SELECT *, Section.name as section_name, Class.name as class_name, Course.name as course_name, Course.description as course_description, Subject.name as subject_name, Subject.description as subject_description FROM Student INNER JOIN Enrollment_Detail ON Student.student_id = Enrollment_Detail.student_id INNER JOIN Section ON Enrollment_Detail.section_id = Section.section_id INNER JOIN Class ON Section.class_id = Class.class_id INNER JOIN Subject_Detail ON Class.subject_detail_id = Subject_Detail.subject_detail_id INNER JOIN Course ON Subject_Detail.course_id = Course.course_id INNER JOIN Subject ON Subject_Detail.subject_id = Subject.subject_id ";
            command = new SqlCommand(queryString, connection);

            try {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read()) {

                    students.Add(new StudentDetail() {
                        student_id = reader.GetInt32(reader.GetOrdinal("student_id")),
                        first_name = reader.GetString(reader.GetOrdinal("first_name")),
                        last_name = reader.GetString(reader.GetOrdinal("last_name")),
                        gender = reader.GetString(reader.GetOrdinal("gender")),
                        date_of_birth = reader.GetDateTime(reader.GetOrdinal("date_of_birth")),
                        mobile_phone = reader.GetString(reader.GetOrdinal("mobile_phone")),
                        telephone = reader.GetString(reader.GetOrdinal("telephone")),
                        address = reader.GetString(reader.GetOrdinal("address")),
                        is_S_Donee = reader.GetBoolean(reader.GetOrdinal("is_S_Donee")),
                        is_Z_Donee = reader.GetBoolean(reader.GetOrdinal("is_Z_Donee")),

                        enrollment_detail_id = reader.GetInt32(reader.GetOrdinal("enrollment_detail_id")),
                        section_id = reader.GetInt32(reader.GetOrdinal("section_id")),
                        class_id = reader.GetInt32(reader.GetOrdinal("class_id")),
                        subject_detail_id = reader.GetInt32(reader.GetOrdinal("subject_detail_id")),
                        subject_id = reader.GetInt32(reader.GetOrdinal("subject_id")),
                        course_id = reader.GetInt32(reader.GetOrdinal("course_id")),
                        section_name = reader.GetString(reader.GetOrdinal("section_name")),
                        class_name = reader.GetString(reader.GetOrdinal("class_name")),
                        course_name = reader.GetString(reader.GetOrdinal("course_name")),
                        course_description = reader.GetString(reader.GetOrdinal("course_description")),
                        subject_name = reader.GetString(reader.GetOrdinal("subject_name")),
                        subject_description = reader.GetString(reader.GetOrdinal("subject_description")),

                    });

                }
                reader.Close();
            } catch (Exception exp) {
                Console.WriteLine(exp.Message); Console.WriteLine(exp.Message);
                throw;
            } finally {
                connection.Close();
            }

            foreach (StudentDetail student in students) {
                Console.WriteLine(student.student_id + "\t" + student.first_name + "\t" + student.date_of_birth);
            }
        }

        public void readDataIntoTeachers() {

            reader = null;

            
            connection = new SqlConnection(connectionString);
            string queryString = "SELECT *, Section.name as section_name, Class.name as class_name, Course.name as course_name, Course.description as course_description, Subject.name as subject_name, Subject.description as subject_description FROM Teacher LEFT JOIN Staff ON Teacher.staff_id = Staff.staff_id INNER JOIN Teaching_Detail ON Teacher.teacher_id = Teaching_Detail.teacher_id INNER JOIN Section ON Teaching_Detail.section_id = Section.section_id INNER JOIN Class ON Section.class_id = Class.class_id INNER JOIN Subject_Detail ON Class.subject_detail_id = Subject_Detail.subject_detail_id INNER JOIN Course ON Subject_Detail.course_id = Course.course_id INNER JOIN Subject ON Subject_Detail.subject_id = Subject.subject_id";
            command = new SqlCommand(queryString, connection);

            try {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read()) {

                    teachers.Add(new Teacher() {
                        teacher_id = reader.GetInt32(reader.GetOrdinal("teacher_id")),
                        first_name = reader.GetString(reader.GetOrdinal("first_name")),
                        last_name = reader.GetString(reader.GetOrdinal("last_name")),
                        gender = reader.GetString(reader.GetOrdinal("gender")),
                        date_of_birth = reader.GetDateTime(reader.GetOrdinal("date_of_birth")),
                        mobile_phone = reader.GetString(reader.GetOrdinal("mobile_phone")),
                        telephone = reader.GetString(reader.GetOrdinal("telephone")),
                        address = reader.GetString(reader.GetOrdinal("address")),
                        referrer = reader.GetString(reader.GetOrdinal("referrer")),
                        education = reader.GetString(reader.GetOrdinal("education")),
                        reference = reader.GetString(reader.GetOrdinal("reference")),
                        experience = reader.GetInt32(reader.GetOrdinal("experience")),

                        teaching_detail_id = reader.GetInt32(reader.GetOrdinal("teaching_detail_id")),
                        section_id = reader.GetInt32(reader.GetOrdinal("section_id")),
                        class_id = reader.GetInt32(reader.GetOrdinal("class_id")),
                        subject_detail_id = reader.GetInt32(reader.GetOrdinal("subject_detail_id")),
                        subject_id = reader.GetInt32(reader.GetOrdinal("subject_id")),
                        course_id = reader.GetInt32(reader.GetOrdinal("course_id")),
                        section_name = reader.GetString(reader.GetOrdinal("section_name")),
                        class_name = reader.GetString(reader.GetOrdinal("class_name")),
                        course_name = reader.GetString(reader.GetOrdinal("course_name")),
                        course_description = reader.GetString(reader.GetOrdinal("course_description")),
                        subject_name = reader.GetString(reader.GetOrdinal("subject_name")),
                        subject_description = reader.GetString(reader.GetOrdinal("subject_description")),


                    });

                }
                reader.Close();
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
                throw;
            } finally {
                connection.Close();
            }

            foreach (Teacher teacher in teachers) {
                Console.WriteLine(teacher.first_name + "\t" + teacher.education + "\t" + teacher.experience);
            }
        }

        public void readDataIntoSubjects() {


            reader = null;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand("Select * from Subject", connection);

            try {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read()) {

                    subjects.Add(new Subject() {
                        subject_id = reader.GetInt32(reader.GetOrdinal("subject_id")),
                        name = reader.GetString(reader.GetOrdinal("name")),
                        description = reader.GetString(reader.GetOrdinal("description")),
                    });

                }
                reader.Close();
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
                throw;
            } finally {
                connection.Close();
            }

            foreach (Subject subject in subjects) {
                Console.WriteLine(subject.subject_id + "\t" + subject.name + "\t" + subject.description);
            }
        }

        public void readDataIntoExams() {


            reader = null;
            connection = new SqlConnection(connectionString);
            command = new SqlCommand("Select * from Exam", connection);

            try {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read()) {

                    exams.Add(new Exam() {
                        exam_id = reader.GetInt32(reader.GetOrdinal("exam_id")),
                        total_marks = reader.GetDecimal(reader.GetOrdinal("total_marks")),
                        obtained_marks = reader.GetDecimal(reader.GetOrdinal("obtained_marks")),
                        date_of_exam = reader.GetDateTime(reader.GetOrdinal("date_of_exam")),
                        subject_id = reader.GetInt32(reader.GetOrdinal("subject_id")),
                        student_detail_dim_id = reader.GetInt32(reader.GetOrdinal("enrollment_detail_id")),
                        teacher_detail_dim_id = reader.GetInt32(reader.GetOrdinal("teaching_detail_id")),
                    });

                }
                reader.Close();
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
                throw;
            } finally {
                connection.Close();
            }

            foreach (Exam exam in exams) {
                Console.WriteLine(exam.exam_id + "\t" + exam.obtained_marks + "\t" + exam.teacher_detail_dim_id);
            }
        }



















    }
}
