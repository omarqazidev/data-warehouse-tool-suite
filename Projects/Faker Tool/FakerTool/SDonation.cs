﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerTool {
    class SDonation {
        public int fund_id { get; set; }


        public SDonation(int fundID) {
            MockData mock = new MockData();
            fund_id = mock.getInteger(fundID);
        }

        public string getString() {
            string toReturn = "";
            toReturn = "" +
                fund_id + Environment.NewLine +
                "";
            return toReturn;
        }

        public string getSQLString() {
            string toReturn = "";
            toReturn = "INSERT INTO S_Donation VALUES(" +
                "" + fund_id + "" +
                ");";
            return toReturn;
        }

    }
}
