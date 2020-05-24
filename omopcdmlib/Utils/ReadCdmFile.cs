using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;

namespace omopcdmlib.Utils
{
    public class ReadCdmFile<T>
    {

        public List<T> Read(string filename)
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

            return ConvertDataTable<T>(datatable);
            // foreach (DataRow row in datatable.Rows)
            // {
            //     Console.WriteLine("----Row No: " + datatable.Rows.IndexOf(row) + "----");
            //
            //     foreach (DataColumn column in datatable.Columns)
            //     {
            //         //check what columns you need
            //         if (column.ColumnName == "concept_name" || 
            //             column.ColumnName == "concept_id" ||
            //             column.ColumnName == "domain_id") 
            //         {
            //             Console.Write(column.ColumnName);
            //             Console.Write(" ");
            //             Console.WriteLine(row[column]);
            //         }
            //     }
            //
            //     if (datatable.Rows.IndexOf(row) > 10)
            //     {
            //         break;
            //     }
            // }
            // Console.ReadLine();
            // return datatable;
        }
        
        private static List<T> ConvertDataTable<T>(DataTable dt)  
        {  
            List<T> data = new List<T>();
            int id = 0;
            foreach (DataRow row in dt.Rows)  
            {  
                T item = GetItem<T>(row, id);  
                data.Add(item);
                id++;
            }  
            return data;  
        }  
        private static T GetItem<T>(DataRow dr, int id)  
        {  
            Type temp = typeof(T);  
            T obj = Activator.CreateInstance<T>();
            foreach (DataColumn column in dr.Table.Columns)  
            {  
                foreach (PropertyInfo pro in temp.GetProperties())  
                {  
                    if (pro.Name == column.ColumnName)  
                        pro.SetValue(obj, dr[column.ColumnName], null);  
                    else if (pro.Name == "Id")
                        pro.SetValue(obj, id, null);
                    else  
                        continue;  
                    
                }
            }  
            return obj;  
        } 
    }
}