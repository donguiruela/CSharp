namespace Aficio
{
    using System.Data                                                             ;
    public static class AficioCSV                                                 {
        public static string delimiter = ","                                      ;
        public static string[] GetCSV(this DataTable src)                         {
            int index = 1                                                         ;
            DataColumn lastcol = src.Columns[src.Columns.Count - 1]               ;
            string[] output = new string[src.Rows.Count + 1]                      ;
            foreach (DataColumn column in src.Columns)                            {
                output[0] += column.ColumnName                                    ;
                if (!column.Equals(lastcol)) output[0] += delimiter               ;}
            foreach (DataRow row in src.Rows)                                     {
                foreach (DataColumn column in src.Columns)                        {
                    if (row[column] != null)                                      {
                        output[index] += row[column]                              ;}
                    if (!column.Equals(lastcol)) output[index] += delimiter       ;}
                index++                                                           ;}
            return output                                                         ;}}}