using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _01___WFDataSetexample.Model
{
    public class TownInfo
    {

        public DataSet GetTownInfo()
        {
            // Create a DataTable with columns id and name
            DataTable towns = new DataTable("Towns");
            // add the columns we will have in the table
            towns.Columns.Add(new DataColumn("id", typeof(int)));
            towns.Columns.Add(new DataColumn("name", typeof(string)));
            // Add three rows to the table
            // declaring row, intialize it as part of the table and add values in each column of this row. and then add it to the collections of Rows
            DataRow row;
            row = towns.NewRow();
            row["id"] = 1;
            row["name"] = "София";
            towns.Rows.Add(row);
            row = towns.NewRow();
            row["id"] = 2;
            row["name"] = "Пловдив";
            towns.Rows.Add(row);
            row = towns.NewRow();
            row["id"] = 3;
            row["name"] = "Варна";
            towns.Rows.Add(row);
            // Create a DataSet and add the table to the DataSet
            DataSet ds = new DataSet();
            ds.Tables.Add(towns);
            return ds;
        }
    }
}
