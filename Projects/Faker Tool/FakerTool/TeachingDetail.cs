using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class TeachingDetail {
       
        public int teacher_id { get; set; }
        public int section_id { get; set; }


        public TeachingDetail(int teacherID, int sectionID) {
            MockData mock = new MockData();
            teacher_id = mock.getInteger(teacherID);
            section_id = mock.getInteger(sectionID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                teacher_id + Environment.NewLine +
                section_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Teaching_Detail VALUES(" +
                "" + teacher_id + "," +
                "" + section_id + "" +
                ");";
            return toReturn;
        }


    }
}
