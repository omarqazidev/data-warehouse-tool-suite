using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class SalaryDetail {

        public int salary_id { get; set; }
        public int staff_id { get; set; }


        public SalaryDetail(int salaryID, int staffID) {
            MockData mock = new MockData();
            salary_id = mock.getInteger(salaryID);
            staff_id = mock.getInteger(staffID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                salary_id + Environment.NewLine +
                staff_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Salary_Detail VALUES(" +
                "" + salary_id + "," +
                "" + staff_id + "" +
                ");";
            return toReturn;
        }

    }
}
