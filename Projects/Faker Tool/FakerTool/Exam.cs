using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Exam {

        public decimal total_marks { get; set; }
        public decimal obtained_marks { get; set; }
        public DateTime date_of_exam { get; set; }
        public int subject_id { get; set; }
        public int teaching_detail_id { get; set; }
        public int enrollment_detail_id { get; set; }

        public Exam(int subjectID, int teachingDetailID, int enrollmentDetailID, Random random) {
            MockData mock = new MockData();
            total_marks = mock.getRandomDecimal(100, 100, random);
            obtained_marks = mock.getRandomDecimal(0, 100, random);
            date_of_exam = mock.getDate(2010,random);
            subject_id = mock.getInteger(subjectID);
            teaching_detail_id = mock.getInteger(teachingDetailID);
            enrollment_detail_id = mock.getInteger(enrollmentDetailID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                total_marks + Environment.NewLine +
                obtained_marks + Environment.NewLine +
                date_of_exam + Environment.NewLine +
                subject_id + Environment.NewLine +
                teaching_detail_id + Environment.NewLine +
                enrollment_detail_id + Environment.NewLine +
                "";
            return toReturn;
        }


        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Exam VALUES(" +
                "" + total_marks + "," +
                "" + obtained_marks + "," +
                "'" + date_of_exam + "'," +
                "" + subject_id + "," +
                "" + teaching_detail_id + "," +
                "" + enrollment_detail_id + "" +
                ");";
            return toReturn;
        }
    }
}
