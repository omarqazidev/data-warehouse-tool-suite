using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FakerTool {
    class Person {

        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public DateTime date_of_birth { get; set; }
        public string mobile_phone { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
       
        public Person(Random random) {
            MockData mock = new MockData();
            first_name = mock.getFirstName();
            last_name = mock.getLastName();
            gender = mock.getGender();
            date_of_birth = mock.getDate(1960,random);
            mobile_phone = mock.getPhoneNumber();
            telephone = mock.getPhoneNumber();
            address = mock.getAddress();

        }

        public string GetString() {
            string toReturn = "";
            toReturn = "" +
                first_name + Environment.NewLine +
                last_name + Environment.NewLine +
                gender + Environment.NewLine +
                date_of_birth + Environment.NewLine +
                mobile_phone + Environment.NewLine +
                telephone + Environment.NewLine +
                address + Environment.NewLine + 
                "";
            return toReturn;
        }


        public string GetSQLString() {
            string toReturn = "";
            toReturn = "" +
                "'" + first_name + "', " +
                "'" + last_name + "', " +
                "'" + gender + "', " +
                "'" + date_of_birth.Date.ToShortDateString() + "', " +
                "'" + mobile_phone + "', " +
                "'" + telephone + "', " +
                "'" + address + "', " +
                "";
            return toReturn;
        }

    }
}
