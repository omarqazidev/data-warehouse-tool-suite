using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_Tool {
    class Exam {
        public int exam_id { get; set; }
        public decimal total_marks { get; set; }
        public decimal obtained_marks { get; set; }
        public DateTime date_of_exam { get; set; }
        public int subject_id { get; set; }
        public int student_detail_dim_id { get; set; }
        public int teacher_detail_dim_id { get; set; }
    }
}
