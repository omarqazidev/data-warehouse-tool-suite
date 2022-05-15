using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class SubjectDetail {

        public int subject_id { get; set; }
        public int course_id { get; set; }


        public SubjectDetail(int subjectID, int courseID) {
            MockData mock = new MockData();
            subject_id = mock.getInteger(subjectID);
            course_id = mock.getInteger(courseID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                subject_id + Environment.NewLine +
                course_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO Subject_Detail VALUES(" +
                "" + subject_id + ", " +
                "" + course_id + "" +
                ");";
            return toReturn;
        }

    }
}
