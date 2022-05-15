using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FakerTool {
    class MockData {

        public string getFirstName() {
            return stripQuoteMarks(Faker.Name.First());
        }

        public string getLastName() {
            return stripQuoteMarks(Faker.Name.Last());
        }

        public string getGender() {
            string toReturn = "F";
            bool isMale = Faker.Boolean.Random();
            if (isMale == true) {
                toReturn = "M";
            }
            return toReturn;
        }

        public DateTime getDate(int minimumDate, Random random) {
            DateTime toReturn = DateTime.Now;
            DateTime start = new DateTime(minimumDate, 1, 1);
            int range = (DateTime.Today - start).Days;
            toReturn = start.AddDays(random.Next(range));
            return toReturn;
        }


        public string getPhoneNumber() {
            string toReturn = "";
            toReturn = Faker.Phone.Number();
            string[] splits;
            splits = toReturn.Split('x');
            toReturn = splits[0];
            toReturn = Regex.Replace(toReturn, "[^0-9]", "");
            return toReturn;
        }

        public string getAddress() {
            string toReturn = "";
            toReturn = "" +
                Faker.Address.StreetAddress() + ", " +
                Faker.Address.City() + "." +
                "";

            return stripQuoteMarks(toReturn);
        }

        public int getIntTrueFalse() {
            int toReturn = 0;
            bool isTrue = Faker.Boolean.Random();
            if (isTrue == true) {
                toReturn = 1;
            }
            return toReturn;
        }
        public string getFullName() {
            return stripQuoteMarks(Faker.Name.First() + " " + Faker.Name.Last());
        }

        public string getWordLorem() {
            string toReturn = "";
            IEnumerable<string> tempIEnum;
            tempIEnum = Faker.Lorem.Words(1);
            toReturn = tempIEnum.ElementAt(0);
            return stripQuoteMarks(toReturn);
        }

        public string getSentenceLorem() {
            return stripQuoteMarks(Faker.Lorem.Sentence());
        }

        public int getInteger(int intValue) {
            return intValue;
        }

        public string getCharAsString() {
            string toReturn = "";
            toReturn = Faker.Lorem.Sentence();
            toReturn = toReturn.Substring(0, 1);
            return toReturn;
        }
        public decimal getRandomDecimalRoundedOff(int lowerLimit, int upperLimit, int roundOffValue, Random random) {
            decimal toReturn = 0;
            decimal randomDecimal = random.Next(lowerLimit, upperLimit);
            randomDecimal = Math.Round(randomDecimal/roundOffValue, 0) * roundOffValue;
            toReturn = randomDecimal;
            return toReturn;
        }

        public string getRandomValueFromList(List<string> list, Random random) {
            int index = random.Next(list.Count());
            return list.ElementAt(index);
        }

        public decimal getRandomDecimal(int lowerLimit, int upperLimit, Random random) {
            decimal toReturn = 0;
            decimal randomDecimal = random.Next(lowerLimit, upperLimit);
            toReturn = randomDecimal;
            return toReturn;
        }

        private string stripQuoteMarks(string theStringToStrip) {
            theStringToStrip = theStringToStrip.Replace("\"", "");
            theStringToStrip = theStringToStrip.Replace("'", "");
            return theStringToStrip;
        }


    }
}
