using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Fee {

        public decimal amount { get; set; }
        public DateTime issue_date { get; set; }
        public DateTime final_date { get; set; }
        

        public Fee(Random random) {
            MockData mock = new MockData();
            amount = mock.getRandomDecimalRoundedOff(1000,100000,100, random);
            issue_date = mock.getDate(2010,random);
            final_date = mock.getDate(issue_date.Year,random);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                amount + Environment.NewLine +
                issue_date + Environment.NewLine +
                final_date + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Fee VALUES(" +
                "" + amount + ", " +
                "'" + issue_date.Date.ToShortDateString() + "', " +
                "'" + final_date.Date.ToShortDateString() + "' " +
                ");";
            return toReturn;
        }


    }
}
