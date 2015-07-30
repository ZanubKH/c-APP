using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace DatabaseConnection
{
    public class DataHelper
    {
        public MySqlConnection connection;

        public DataHelper()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=????;" +
                                    "user id=???;" +
                                    "password=???;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }


        public List<Student> GetAllStudents()
        {
            String sql = "SELECT * FROM studenttable";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Student> temp;
            temp = new List<Student>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String name;
                int nr;
                int cr;
                while (reader.Read())
                {
                    name = Convert.ToString(reader["Studentname"]);
                    nr = Convert.ToInt32(reader["Studentnumber"]);
                    cr = Convert.ToInt32(reader["NrOfCredits"]);
                    temp.Add(new Student(nr, name, cr));
                }
            }
            catch
            {
                MessageBox.Show("error while loading the students");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public int AddAStudent(int number, string name, int creditpoints)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?
            String sql = "INSERT INTO StudentTable VALUES (" + number + ",'" + name + "'" + "," + creditpoints + ")";
            MySqlCommand command = new MySqlCommand(sql, connection);

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
            finally
            {
                connection.Close();
            }
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
