using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_Tool {
    class TableColumn {
        String columnHead;
        List<String> columnRecords;

        public TableColumn(String columnTitle) {
            columnHead = columnTitle;
            columnRecords = new List<String>();
        }

        public void addRecord(String value) {
            columnRecords.Add(value);
        }









    }
}
