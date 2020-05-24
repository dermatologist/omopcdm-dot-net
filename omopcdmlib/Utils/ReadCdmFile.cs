using System;
using System.Data;
using System.IO;

namespace omopcdmlib.Utils
{
    public class ReadCdmFile
    {

        public void Read(string filename)
        {
            DataTable datatable = new DataTable();
            StreamReader streamreader = new StreamReader(filename);
            char[] delimiter = new char[] { '\t' };
            string[] columnheaders = streamreader.ReadLine().Split(delimiter);
            foreach (string columnheader in columnheaders)
            {
                datatable.Columns.Add(columnheader); // I've added the column headers here.
            }

            while (streamreader.Peek() > 0)
            {
                DataRow datarow = datatable.NewRow();
                datarow.ItemArray = streamreader.ReadLine().Split(delimiter);
                datatable.Rows.Add(datarow);
            }

            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("----Row No: " + datatable.Rows.IndexOf(row) + "----");

                foreach (DataColumn column in datatable.Columns)
                {
                    //check what columns you need
                    if (column.ColumnName == "Column2" || 
                        column.ColumnName == "Column12" ||
                        column.ColumnName == "Column45") 
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
        }
    }
}