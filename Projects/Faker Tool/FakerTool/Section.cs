using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Section {

        public string name { get; set; }
        public int class_id { get; set; }


        public Section(int classID) {
            MockData mock = new MockData();
            name = mock.getCharAsString();
            class_id = mock.getInteger(classID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                name + Environment.NewLine +
                class_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Section VALUES(" +
                "'" + name + "', " +
                "" + class_id + "" +
                ");";
            return toReturn;
        }


    }
}
