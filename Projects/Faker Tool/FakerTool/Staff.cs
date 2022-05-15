using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Staff : Person {

        public string referrer { get; set; }

        public Staff(Random random) : base(random) {
            MockData mock = new MockData();
            referrer = mock.getFullName();
        }


        public string GETString() {
            string toReturn = "";
            toReturn = "" +
                base.GetString() +
                referrer + Environment.NewLine +
                "";
            return toReturn;
        }

        public string GETSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Staff VALUES(" +
                base.GetSQLString() +
                "'" + referrer + "'" +
                ");";
            return toReturn;
        }



    }
}

