using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class Student : Person {

        public int is_Z_Donee { get; set; }
        public int is_S_Donee { get; set; }


        public Student(Random random) : base(random) {
            MockData mock = new MockData();
            is_Z_Donee = mock.getIntTrueFalse();
            is_S_Donee = mock.getIntTrueFalse();
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                base.GetString() +
                is_Z_Donee + Environment.NewLine +
                is_S_Donee + Environment.NewLine +
                "";
            return toReturn;
        }


        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Student VALUES(" +
                base.GetSQLString() +
                is_Z_Donee + ", " +
                is_S_Donee + "" +
                ");";
            return toReturn;
        }


    }
}
