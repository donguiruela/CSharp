using System;
using System.Data;

namespace Aficio
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable data = new DataTable();
            data.Columns.Add("col1");
            data.Columns.Add("col2");
            data.Columns.Add("col3");
            data.Columns.Add("col4");

            data.Rows.Add(new string[] { "Addition", "Subtraction", "Multiplication", "Division" });
            data.Rows.Add(new string[] { "Science", "Mathematics", "Language", "Arts" });

            string[] oof = data.GetCSV();

            foreach (var a in oof)
            {
                Console.WriteLine(a);
            }

            string axe = "abdj";
            Console.WriteLine(axe.GetMissingLetters());
        }
    }
}

