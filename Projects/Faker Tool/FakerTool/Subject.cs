using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Subject {

        public string name { get; set; }
        public string description { get; set; }

        public Subject() {
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
            toReturn = "INSERT INTO Subject VALUES(" +
                "'" + name + "', " +
                "'" + description + "'" +
                ");";
            return toReturn;
        }

    }
}
