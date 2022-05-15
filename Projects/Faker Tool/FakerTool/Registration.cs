using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Registration {

        public int student_id { get; set; }
        public int admin_id { get; set; }


        public Registration(int studentID, int adminID) {
            MockData mock = new MockData();
            student_id = mock.getInteger(studentID);
            admin_id = mock.getInteger(adminID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                student_id + Environment.NewLine +
                admin_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Registration VALUES(" +
                "" + student_id + "," +
                "" + admin_id + "" +
                ");";
            return toReturn;
        }
    }
}
