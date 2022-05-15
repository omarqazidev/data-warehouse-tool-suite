using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Class {

        public string name { get; set; }
        public int subject_detail_id { get; set; }


        public Class(int subjectDetailID) {
            MockData mock = new MockData();
            name = mock.getWordLorem();
            subject_detail_id = mock.getInteger(subjectDetailID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                name + Environment.NewLine +
                subject_detail_id + Environment.NewLine +
                "";
            return toReturn;
        }


        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Class VALUES(" +
                "'" + name + "', " +
                "" + subject_detail_id + "" +
                ");";
            return toReturn;
        }

    }
}
