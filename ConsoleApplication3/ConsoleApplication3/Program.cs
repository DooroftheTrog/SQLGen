using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLGenerator
{
    //this will generate SQL that you need based on information that you copy from an excel sheet...::::only one column at a time::::... 
    //Step 1: Replace the text within the [] to the field you wish to enter information into
    //Step 2: Copy the text from any excel cells that you want to be added to the SQL statement
    //Step 3: right click top of bar click edit->paste
    //Step 4: enter ~ and click enter
    //Step 5: right click top of bar click edit->mark
    //Step 6: higligh all text to be copied
    //Step 7: right click top of bar click edit->copy
    //Final Step: Paste SQL statement where you need it
    class Program
    {
        public static void sqlStatment(string[] listSQL)
        {
            string sql = "([FileData.FileName] IN (";
            for (int i = 0; i < listSQL.Length; i++)
            {
                sql += (i == listSQL.Length - 1) ? "\'" + listSQL[i] + "\'" : "\'" + listSQL[i] + "\',";
            }
            sql += "))";

            Console.WriteLine(sql);
        }

        static void Main(string[] args)
        {
           
            string input = "";
            string collect = "";
            string[] sql;
            while(input != "x"||input !="X")
            {
                Console.WriteLine("Enter a string of usernames: ");
                input = Console.ReadLine();      
                if(input=="~")
                {
                    collect.Trim();
                    sql = collect.Split(' ');
                    sqlStatment(sql);
                    collect = "";                                   
                }
                else
                {
                    collect += input + " ";
                }               
            }
        }
    }
}
