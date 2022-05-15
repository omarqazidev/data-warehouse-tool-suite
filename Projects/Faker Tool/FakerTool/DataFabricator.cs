using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class DataFabricator {

        List<Student> studentList = new List<Student>();
        List<Staff> staffList = new List<Staff>();
        List<Admin> adminList = new List<Admin>();
        List<Course> courseList = new List<Course>();
        List<Subject> subjectList = new List<Subject>();
        List<SubjectDetail> subjectDetailList = new List<SubjectDetail>();
        List<Class> classList = new List<Class>();
        List<Section> sectionList = new List<Section>();
        List<Fee> feeList = new List<Fee>();
        List<FeeDetail> feeDetailList = new List<FeeDetail>();
        List<Guardian> guardianList = new List<Guardian>();
        List<Fund> fundList = new List<Fund>();
        List<OtherFunding> otherFundingList = new List<OtherFunding>();
        List<GuardianDetail> guardianDetailList = new List<GuardianDetail>();
        List<Registration> registrationList = new List<Registration>();
        List<Salary> salaryList = new List<Salary>();
        List<SalaryDetail> salaryDetailList = new List<SalaryDetail>();
        List<Teacher> teacherList = new List<Teacher>();
        List<TeachingDetail> teachingDetailList = new List<TeachingDetail>();
        List<EnrollmentDetail> enrollmentDetailList = new List<EnrollmentDetail>();
        List<ZDonation> zDonationList = new List<ZDonation>();
        List<SDonation> sDonationList = new List<SDonation>();
        List<Exam> examList = new List<Exam>();

        Random random = new Random();

        public void fabricateLists() {
            fabricateStudent(300);
            fabricateStaff(15);
            fabricateAdmin(3);

            fabricateCourse(6);


            fabricateSubject(40);
            fabricateSubjectDetail(40);

            fabricateClass(15);
            fabricateSection(20);

            fabricateFee(800);
            fabricateFeeDetail(800);

            fabricateGuardian(280);

            fabricateFund(10);
            fabricateOtherFunding(3);
            fabricateZDonation(5);
            fabricateSDonation(2);

            fabricateGuardianDetail(300);
            fabricateRegistration(300);
            fabricateSalary(500);
            fabricateSalaryDetail(500);


            fabricateTeacher(10);
            

            fabricateTeachingDetail(90);
            fabricateEnrollmentDetail(100);


            fabricateExam(5000);
        }




        public void fabricateStudent(int numberOfRecords) {
            for (int i = 0; i < numberOfRecords; i++) {
                studentList.Add(new Student(random));
            }
        }

        public void fabricateStaff(int numberOfRecords) {
            for (int i = 0; i < numberOfRecords; i++) {
                staffList.Add(new Staff(random));
            }
        }

        public void fabricateAdmin(int numberOfRecords) {
            for (int i = 0; i < numberOfRecords; i++) {
                adminList.Add(new Admin());
            }
        }

        public void fabricateCourse(int numberOfRecords) {
            for (int i = 0; i < numberOfRecords; i++) {
                courseList.Add(new Course());
            }
        }

        public void fabricateSubject(int numberOfRecords) {
            for (int i = 0; i < numberOfRecords; i++) {
                subjectList.Add(new Subject());
            }
        }

        public void fabricateSubjectDetail(int numberOfRecords) {
            int subjectID = 0;
            int courseID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                subjectID++;
                courseID++;
                if (subjectID == subjectList.Count + 1) {
                    subjectID = 1;
                }
                if (courseID == courseList.Count + 1) {
                    courseID = 1;
                }
                subjectDetailList.Add(new SubjectDetail(subjectID, courseID));
            }
        }

        public void fabricateClass(int numberOfRecords) {
            int subjectDetailID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                subjectDetailID++;
                if (subjectDetailID == subjectDetailList.Count + 1) {
                    subjectDetailID = 1;
                }
                classList.Add(new Class(subjectDetailID));
            }
        }

        public void fabricateSection(int numberOfRecords) {
            int classID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                classID++;
                if (classID == classList.Count + 1) {
                    classID = 1;
                }
                sectionList.Add(new Section(classID));
            }
        }

        public void fabricateFee(int numberOfRecords) {
            for (int i = 0; i < numberOfRecords; i++) {
                feeList.Add(new Fee(random));
            }
        }

        public void fabricateFeeDetail(int numberOfRecords) {
            int studentID = 0;
            int feeID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                studentID++;
                feeID++;
                if (studentID == studentList.Count + 1) {
                    studentID = 1;
                }
                if (feeID == feeList.Count + 1) {
                    feeID = 1;
                }
                feeDetailList.Add(new FeeDetail(studentID, feeID));
            }
        }

        public void fabricateGuardian(int numberOfRecords) {
            for (int i = 0; i < numberOfRecords; i++) {
                guardianList.Add(new Guardian(random));
            }
        }

        public void fabricateFund(int numberOfRecords) {
            int adminID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                adminID++;
                if (adminID == adminList.Count + 1) {
                    adminID = 1;
                }
                fundList.Add(new Fund(adminID, random)); ;
            }
        }

        public void fabricateOtherFunding(int numberOfRecords) {
            int fundID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                fundID++;
                if (fundID == fundList.Count + 1) {
                    fundID = 1;
                }
                otherFundingList.Add(new OtherFunding(fundID)); ;
            }
        }

        public void fabricateZDonation(int numberOfRecords) {
            int fundID = otherFundingList.Count;
            for (int i = 0; i < numberOfRecords; i++) {
                fundID++;
                if (fundID == fundList.Count + 1) {
                    fundID = 1;
                }
                zDonationList.Add(new ZDonation(fundID)); ;
            }
        }

        public void fabricateSDonation(int numberOfRecords) {
            int fundID = otherFundingList.Count + zDonationList.Count;
            for (int i = 0; i < numberOfRecords; i++) {
                fundID++;
                if (fundID == fundList.Count + 1) {
                    fundID = 1;
                }
                sDonationList.Add(new SDonation(fundID)); ;
            }
        }

        public void fabricateGuardianDetail(int numberOfRecords) {
            int guardianID = 0;
            int studentID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                guardianID++;
                studentID++;
                if (guardianID == guardianList.Count + 1) {
                    guardianID = 1;
                }
                if (studentID == studentList.Count + 1) {
                    studentID = 1;
                }
                guardianDetailList.Add(new GuardianDetail(guardianID, studentID));
            }
        }

        public void fabricateRegistration(int numberOfRecords) {
            int studentID = 0;
            int adminID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                studentID++;
                adminID++;
                if (studentID == studentList.Count + 1) {
                    studentID = 1;
                }
                if (adminID == adminList.Count + 1) {
                    adminID = 1;
                }
                registrationList.Add(new Registration(studentID, adminID));
            }
        }

        public void fabricateSalary(int numberOfRecords) {
           
            for (int i = 0; i < numberOfRecords; i++) {
                salaryList.Add(new Salary(random));
            }
        }

        public void fabricateSalaryDetail(int numberOfRecords) {
            int salaryID = 0;
            int staffID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                salaryID++;
                staffID++;
                if (salaryID == salaryList.Count + 1) {
                    salaryID = 1;
                }
                if (staffID == staffList.Count + 1) {
                    staffID = 1;
                }
                salaryDetailList.Add(new SalaryDetail(salaryID, staffID));
            }
        }


        public void fabricateTeacher(int numberOfRecords) {
            int staffID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                staffID++;
                if (staffID == staffList.Count + 1) {
                    staffID = 1;
                }
                teacherList.Add(new Teacher(staffID, random));
            }
        }

        public void fabricateTeachingDetail(int numberOfRecords) {
            int teacherID = 0;
            int sectionID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                teacherID++;
                sectionID++;

                if (teacherID == teacherList.Count + 1) {
                    teacherID = 1;
                }
                if (sectionID == sectionList.Count + 1) {
                    sectionID = 1;
                }
                teachingDetailList.Add(new TeachingDetail(teacherID, sectionID));
            }
        }

        public void fabricateEnrollmentDetail(int numberOfRecords) {
            int studentID = 0;
            int sectionID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                studentID++;
                sectionID++;
                if (studentID == studentList.Count + 1) {
                    studentID = 1;
                }
                if (sectionID == sectionList.Count + 1) {
                    sectionID = 1;
                }
                enrollmentDetailList.Add(new EnrollmentDetail(studentID, sectionID));
            }
        }


        public void fabricateExam(int numberOfRecords) {
            int subjectID = 0;
            int teachingDetailID = 0;
            int enrollmentDetailID = 0;
            for (int i = 0; i < numberOfRecords; i++) {
                subjectID++;
                teachingDetailID++;
                enrollmentDetailID++;
                if (subjectID == subjectList.Count + 1) {
                    subjectID = 1;
                }
                if (teachingDetailID == teachingDetailList.Count + 1) {
                    teachingDetailID = 1;
                }
                if (enrollmentDetailID == enrollmentDetailList.Count + 1) {
                    enrollmentDetailID = 1;
                }
                examList.Add(new Exam(subjectID,teachingDetailID,enrollmentDetailID,random));
            }
        }











        public string getStudentSQL() {
            string toReturn = "";
            foreach (Student x in studentList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getStaffSQL() {
            string toReturn = "";
            foreach (Staff x in staffList) {
                toReturn = toReturn + x.GETSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getAdminSQL() {
            string toReturn = "";
            foreach (Admin x in adminList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getCourseSQL() {
            string toReturn = "";
            foreach (Course x in courseList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getSubjectSQL() {
            string toReturn = "";
            foreach (Subject x in subjectList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getSubjectDetailSQL() {
            string toReturn = "";
            foreach (SubjectDetail x in subjectDetailList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getClassSQL() {
            string toReturn = "";
            foreach (Class x in classList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getSectionSQL() {
            string toReturn = "";
            foreach (Section x in sectionList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getFeeSQL() {
            string toReturn = "";
            foreach (Fee x in feeList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getFeeDetailSQL() {
            string toReturn = "";
            foreach (FeeDetail x in feeDetailList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getGuardianSQL() {
            string toReturn = "";
            foreach (Guardian x in guardianList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getFundSQL() {
            string toReturn = "";
            foreach (Fund x in fundList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getOtherFundingSQL() {
            string toReturn = "";
            foreach (OtherFunding x in otherFundingList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getZDonationSQL() {
            string toReturn = "";
            foreach (ZDonation x in zDonationList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getSDonationSQL() {
            string toReturn = "";
            foreach (SDonation x in sDonationList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }


        public string getGuardianDetailSQL() {
            string toReturn = "";
            foreach (GuardianDetail x in guardianDetailList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getRegistrationSQL() {
            string toReturn = "";
            foreach (Registration x in registrationList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getSalarySQL() {
            string toReturn = "";
            foreach (Salary x in salaryList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getSalaryDetailSQL() {
            string toReturn = "";
            foreach (SalaryDetail x in salaryDetailList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getTeacherSQL() {
            string toReturn = "";
            foreach (Teacher x in teacherList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getTeachingDetailSQL() {
            string toReturn = "";
            foreach (TeachingDetail x in teachingDetailList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getEnrollmentDetailSQL() {
            string toReturn = "";
            foreach (EnrollmentDetail x in enrollmentDetailList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }

        public string getExamSQL() {
            string toReturn = "";
            foreach (Exam x in examList) {
                toReturn = toReturn + x.getSQLString() + Environment.NewLine;
            }
            return toReturn;
        }


    }
}
