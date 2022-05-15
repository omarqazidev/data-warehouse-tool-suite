using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Admin {

        public string first_name { get; set; }
        public string last_name { get; set; }

        public Admin() {
            MockData mock = new MockData();
            first_name = mock.getFirstName();
            last_name = mock.getLastName();
        }
       
        public string getString() {
            string toReturn = "";
            toReturn = "" +
                first_name + Environment.NewLine +
                last_name + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Admin VALUES(" +
                "'" + first_name + "', " +
                "'" + last_name + "'" +
                ");";
            return toReturn;
        }

    }
}





        



