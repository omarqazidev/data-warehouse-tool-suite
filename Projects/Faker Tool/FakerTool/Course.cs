using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Course {

        public string name { get; set; }
        public string description { get; set; }

        public Course() {
            MockData mock = new MockData();
            name = mock.getWordLorem();
            description = mock.getSentenceLorem();
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                name + Environment.NewLine +
                description + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Course VALUES(" +
                "'" + name + "', " +
                "'" + description + "'" +
                ");";
            return toReturn;
        }

    }
}
