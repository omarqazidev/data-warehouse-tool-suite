using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Teacher {

        public string education { get; set; }
        public string reference { get; set; }
        public int experience { get; set; }
        public int staff_id { get; set; }


        public Teacher(int StaffID, Random random) {
            MockData mock = new MockData();
            List<string> list = new List<string> { "Middle Eastern and Islamic Studies", "Islamic Banking and Finance", "Islamic Finance and Economics", "Islamic Finance and Management", "Islamic Intellectual History", "Doctor of Philosophy in Islamic Studies", "Master of Arts in Islamic Studies", "MA in Arab and Islamic Studies", "MPhil in Asian and Middle Eastern Studies", "Islamic Studies - MA" };
            education = mock.getRandomValueFromList(list,random);
            reference = mock.getFullName();
            experience = (int)mock.getRandomDecimal(0, 20, random);
            staff_id = mock.getInteger(StaffID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                education + Environment.NewLine +
                reference + Environment.NewLine +
                experience + Environment.NewLine +
                staff_id + Environment.NewLine +
                "";
            return toReturn;
        }
        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Teacher VALUES(" +
                "'" + education + "'," +
                "'" + reference + "'," +
                "" + experience + "," +
                "" + staff_id + "" +
                ");";
            return toReturn;
        }

       

    }
}
