using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Salary {

        public DateTime date { get; set; }
        public decimal amount { get; set; }

        public Salary(Random random) {
            MockData mock = new MockData();
            date = mock.getDate(2010,random);
            amount = mock.getRandomDecimalRoundedOff(25000, 300000, 100, random);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                date + Environment.NewLine +
                amount + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Salary VALUES(" +
                "'" + date + "'," +
                "" + amount + "" +
                ");";
            return toReturn;
        }

    }
}
