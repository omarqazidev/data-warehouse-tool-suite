using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class FeeDetail {

        public int student_id { get; set; }
        public int fee_id { get; set; }


        public FeeDetail(int studentID, int feeID) {
            MockData mock = new MockData();
            student_id = mock.getInteger(studentID);
            fee_id = mock.getInteger(feeID);

        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                student_id + Environment.NewLine +
                fee_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Fee_Detail VALUES(" +
                "" + student_id + ", " +
                "" + fee_id + "" +
                ");";
            return toReturn;
        }

    }
}
