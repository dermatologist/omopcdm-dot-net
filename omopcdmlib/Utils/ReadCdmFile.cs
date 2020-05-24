using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace omopcdmlib.Utils
{

    //https://stackoverflow.com/questions/23225973/parsing-tab-delimited-text-files
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

            return ConvertDataTable(datatable);
        }
        // https://www.c-sharpcorner.com/UploadFile/ee01e6/different-way-to-convert-datatable-to-list/        
        private static List<T> ConvertDataTable(DataTable dt)  
        {  
            List<T> data = new List<T>();
            int id = 0;
            foreach (DataRow row in dt.Rows)  
            {  
                T item = GetItem(row, id);  
                data.Add(item);
                id++;
            }  
            return data;  
        }  
        private static T GetItem(DataRow dr, int id)  
        {  
            Type temp = typeof(T);  
            T obj = Activator.CreateInstance<T>();
            foreach (DataColumn column in dr.Table.Columns)  
            {  
                foreach (PropertyInfo pro in temp.GetProperties())  
                {  
                    if (pro.Name == TitleCaseConvert(column.ColumnName))  
                        pro.SetValue(obj, dr[column.ColumnName], null);  
                    else if (pro.Name == "Id")
                        pro.SetValue(obj, id, null);
                    else  
                        continue;  
                    
                }
            }  
            return obj;  
        } 
        private static string TitleCaseConvert(string title)
        { 
            return new CultureInfo("en").TextInfo.ToTitleCase(title.ToLower().Replace("_", " ")).Replace(" ", "");
        }
    }
}