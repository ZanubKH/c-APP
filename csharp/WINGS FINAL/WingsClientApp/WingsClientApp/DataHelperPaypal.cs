using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;  //because we are using files

namespace WingsClientApp
{
    public class DataHelperPaypal
    {
        public MySqlConnection connection;
        public string Filename { get; set; }
        public DataHelperPaypal( string file)
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi298536;" +
                                    "user id=dbi298536;" +
                                    "password=SISnLjRGxk;";

            connection = new MySqlConnection(connectionInfo);
            Filename = file;
        }


        public List<string> GetAllStudents()
        {
           

            List<string> AllLines = new List<string>();
            FileStream fs = null;
            StreamReader sr = null;


            fs = new FileStream(Filename, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            String s;
            s = sr.ReadLine();
           

            while (s != null)
            {
                AllLines.Add(s);
                s = sr.ReadLine();

            }



           
            return AllLines;  
        }

        public int AddAStudent()
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?=
            string[] words;

            string[] idstroe;

            List<string> AllLines = new List<string>();
            FileStream fs = null;
            StreamReader sr = null;


            fs = new FileStream(Filename, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            String s;
            s = sr.ReadLine();
            s = sr.ReadLine();
           
            s = sr.ReadLine();
            s = sr.ReadLine();
            s = sr.ReadLine();

            while (s != null)
            {
                idstroe = s.Split(' ');
                int i = Convert.ToInt32(idstroe[0]);
                Decimal id = Convert.ToDecimal(idstroe[1]);

                String sql = "Update `account` Set `Money_In_Account` = `Money_In_Account` +" +
                              id + ", `Total_Money_Sent` = `Total_Money_Sent` +" + id + "   Where `Customer_Id` = " + i + ";";
                MySqlCommand command = new MySqlCommand(sql, connection);
                s = sr.ReadLine();

                try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }
                

            }
        
           

                       connection.Close();
                       return 1;
            
        }

        public int NumberOfStudents()
        {
            String sql = "SELECT COUNT(*) FROM StudentTable";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int number = 0;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
