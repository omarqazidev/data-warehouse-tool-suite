using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Fund {
        public DateTime date { get; set; }
        public string contributor_name { get; set; }
        public decimal amount { get; set; }
        public int admin_id { get; set; }

        public Fund(int adminID, Random random) {
            MockData mock = new MockData();
            date = mock.getDate(2010,random);
            contributor_name = mock.getFullName();
            amount = mock.getRandomDecimalRoundedOff(1000,100000,100, random);
            admin_id = mock.getInteger(adminID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                date + Environment.NewLine +
                contributor_name + Environment.NewLine +
                amount + Environment.NewLine +
                admin_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Fund VALUES(" +
                "'" + date + "'," +
                "'" + contributor_name + "'," +
                "" + amount + "," +
                "" + admin_id + "" +
                ");";
            return toReturn;
        }


    }
}
