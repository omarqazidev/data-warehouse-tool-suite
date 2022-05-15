using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class EnrollmentDetail {
        public int student_id { get; set; }
        public int section_id { get; set; }


        public EnrollmentDetail(int studentID, int sectionID) {
            MockData mock = new MockData();
            student_id = mock.getInteger(studentID);
            section_id = mock.getInteger(sectionID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                student_id + Environment.NewLine +
                section_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Enrollment_Detail VALUES(" +
                "" + student_id + "," +
                "" + section_id + "" +
                ");";
            return toReturn;
        }

    }
}
