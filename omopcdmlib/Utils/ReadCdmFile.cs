using System;
using System.Data;
using System.IO;

namespace omopcdmlib.Utils
{
    public class ReadCdmFile
    {

        public DataTable Read(string filename)
        {
            DataTable datatable = new DataTable();
            StreamReader streamreader = new StreamReader(filename);
            char[] delimiter = new char[] { '\t' };
            string[] columnheaders = streamreader.ReadLine().Split(delimiter);
            foreach (string columnheader in columnheaders)
            {
                datatable.Columns.Add(columnheader); // I've added the column headers here.
            }

            var test =0;
            while (streamreader.Peek() > 0)
            {
                test++;
                DataRow datarow = datatable.NewRow();
                datarow.ItemArray = streamreader.ReadLine().Split(delimiter);
                datatable.Rows.Add(datarow);
                if(test>20){
                    break;
                }
            }

            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("----Row No: " + datatable.Rows.IndexOf(row) + "----");

                foreach (DataColumn column in datatable.Columns)
                {
                    //check what columns you need
                    if (column.ColumnName == "concept_name" || 
                        column.ColumnName == "concept_id" ||
                        column.ColumnName == "domain_id") 
                    {
                        Console.Write(column.ColumnName);
                        Console.Write(" ");
                        Console.WriteLine(row[column]);
                    }
                }

                if (datatable.Rows.IndexOf(row) > 10)
                {
                    break;
                }
            }
            Console.ReadLine();
            return datatable;
        }
    }
}