using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class GuardianDetail {
        public int guardian_id { get; set; }
        public int student_id { get; set; }


        public GuardianDetail(int guardianID, int studentID) {
            MockData mock = new MockData();
            guardian_id = mock.getInteger(guardianID);
            student_id = mock.getInteger(studentID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                guardian_id + Environment.NewLine +
                student_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Guardian_Detail VALUES(" +
                "" + guardian_id + "," +
                "" + student_id + "" +
                ");";
            return toReturn;
        }

    }
}
