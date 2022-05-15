using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Guardian : Person {

        public string relation_with_student { get; set; }

        public Guardian(Random random) : base(random) {
            MockData mock = new MockData();
            List<string> list = new List<string> { "Parent", "Sibling", "Guardian" };
            relation_with_student = mock.getRandomValueFromList(list, random);
        }


        public string getString() {
            string toReturn = "";
            toReturn = "" +
                base.GetString() +
                relation_with_student + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Guardian VALUES(" +
                base.GetSQLString() +
                "'" + relation_with_student + "'" +
                ");";
            return toReturn;
        }


    }
}
