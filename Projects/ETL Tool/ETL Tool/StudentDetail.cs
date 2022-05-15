﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_Tool {
    class StudentDetail {
        public int student_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public DateTime date_of_birth { get; set; }
        public string mobile_phone { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
        public bool is_Z_Donee { get; set; }
        public bool is_S_Donee { get; set; }

        public int enrollment_detail_id { get; set; }
        public int section_id { get; set; }
        public string section_name { get; set; }
        public int class_id { get; set; }
        public string class_name { get; set; }
        public int subject_detail_id { get; set; }
        public int course_id { get; set; }
        public string course_name { get; set; }
        public string course_description { get; set; }
        public int subject_id { get; set; }
        public string subject_name { get; set; }
        public string subject_description { get; set; }

    }
}

