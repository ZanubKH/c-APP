using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;  //because we are using files

namespace DatabaseConnection
{
    public class DataHelperCamp
    {
        public MySqlConnection connection;
        public List<Login> log ;
        public List<Tent> tent ;

        public DataHelperCamp()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi298536;" +
                                    "user id=dbi298536;" +
                                    "password=SISnLjRGxk;";

            connection = new MySqlConnection(connectionInfo);
            log = new List<Login>();
            tent = new List<Tent>();

        }

        public List<Login> filllog()
        {
            String sql = "SELECT * FROM `user_reservation`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();



                String lname;
                String fname;
                int nr;

                string dob;
               
                string gender;
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);
                    lname = Convert.ToString(reader["Last_Name"]);
                    fname = Convert.ToString(reader["First_Name"]);
                   
                  
                    gender = Convert.ToString(reader["Gender"]);
                    dob = Convert.ToString(reader["Email"]);
                    log.Add(new Login(lname, fname, nr, dob, gender));



                }
            }
            catch
            {
                MessageBox.Show("error while connection");
            }
            finally
            {
                connection.Close();
            }

            return log;
        }
        public void InserPending(List<Guests> guests)
        {
            foreach (Guests s in guests)
            {
                connection.Open();
                String sql = "INSERT INTO `pendinghosts`(`Customer_Id`,`Hoster`,`Tent`) VALUES ('" + s.guestid + "','" + s.hostid + "','" + s.tentid + " ');";
                String sql1 = "DELETE FROM `camping` Where `Customer_Id` = " + s.guestid + " AND `Hoster`=" + s.hostid + " AND `Tent_Number` = " + s.tentid + ";";
               
                //INSERT INTO `dbi298536`.`user_checking_in` (`Customer_Id`, `Time_In`) VALUES ('25', CURRENT_TIME());
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlCommand command1 = new MySqlCommand(sql1, connection);


             
                 command.ExecuteNonQuery();
                 command1.ExecuteNonQuery();
               

                


                connection.Close();

            }
           

        }
        public List<Tent> fillTent()
        {
            String sql = "SELECT * FROM `tents`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();



                
                int nr;
                int nrOfPeople;

                String location;
                decimal rent;
                int f;
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Tent_Number"]);
                    nrOfPeople = Convert.ToInt32(reader["No_Of_People"]);
                    location = Convert.ToString(reader["Location"]);
                    rent = Convert.ToDecimal(reader["Rent"]);
                    f = Convert.ToInt32(reader["Isfull"]);
                    tent.Add(new Tent(nr, nrOfPeople, location, rent, f));



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

            return tent;
        }
        public int GetCustomerId(string value)
        {
            String sql = "Select `Customer_Id` FROM `user_checking_in` Where `RFID` = '" + value + "';";
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
                MessageBox.Show("error in DB Connection");
            }
            finally
            {
                connection.Close();
            }

            return 0;
        }
        public string CheckIfExists(int id)
        {
            String sql = "SELECT * FROM `camping`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String name;
                int nr;
                int host;
                int confirm;
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);
                    name = Convert.ToString(reader["Tent_Number"]);
                    host = Convert.ToInt32(reader["Hoster"]);
                    confirm = Convert.ToInt32(reader["Confirmed"]);
                    if (nr == id && host == nr && confirm == 0)
                    { return "no host"; }
                    if (nr == id && host != nr && confirm == 0) { return "hosts"; }
                    if (nr==id&&confirm == 1)
                    { return "alchin"; }
                    




                }
            }
            catch
            {
                MessageBox.Show("error in DB Connection");
            }
            finally
            {
                connection.Close();
            }

            return "not";
        }


      
        public int Tent(int id)
        {
            String sql = "SELECT * FROM `camping`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int name;
                int nr;
               
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);
                    name = Convert.ToInt32(reader["Tent_Number"]);
                   /// cr = Convert.ToString(reader["Date"]);
                    if (nr == id)
                        return name;



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

            return 0;

        }


        public List<Guests> GetHosts(int id)
        {
            List<Guests> hosters = new List<Guests> { };
            String sql = "SELECT * FROM `camping`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int nr;

                int tent;
                int host;
                
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);
                    if (nr == id)
                    {
                        tent = Convert.ToInt32(reader["Tent_Number"]);
                        host = Convert.ToInt32(reader["Hoster"]);
                        Guests g = new Guests(nr, tent, host);
                        hosters.Add(g);
                    }



                }
            }
            catch
            {
                MessageBox.Show("error while connection");
            }
            finally
            {
                connection.Close();
            }

            return hosters;
        }

        public int UpdateHostAccout(int id)
        {   
            
                String sql = "Update `account` Set `Money_In_Account` = `Money_In_Account`-20  Where `Customer_Id`="+ id+";" ;
               
                MySqlCommand command = new MySqlCommand(sql, connection);
               
               
                try
                {
                    connection.Open();
                    
                        int nrOfRecordsChanged = command.ExecuteNonQuery();
                        
                      

                        return nrOfRecordsChanged ;
                    
                }
                catch
                {
                    return -1; //which means the try-block was not executed succesfully, so  . . .
                }





                finally
                {
                    connection.Close();
                }
            //return 0;

        }
        public int UpdateConfirm(int id,int id2)
        {

            
            String sql2 = "Update `camping` Set `Confirmed` = 1  Where `Customer_Id`=" + id2 +";";

           
            MySqlCommand command1 = new MySqlCommand(sql2, connection);


            try
            {
                connection.Open();

                
                int nrOfRecordsChanged1 = Convert.ToInt32(command1.ExecuteScalar());

                return nrOfRecordsChanged1;

            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }





            finally
            {
                connection.Close();
            }
            //return 0;

        }
        public int UpdateTents(int tentid)
        {

            String sql = "Update `tents` Set `No_Of_People` = `No_Of_People`-1   Where `Tent_Number`=" + tentid + " and `No_Of_People` >0;";
            String sql2 = "Update `tents` Set `Isfull`=0  Where  `No_Of_People<6;";
           

            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlCommand command1 = new MySqlCommand(sql2, connection);

           
            try
            {
                connection.Open();
                
                    int nrOfRecordsChanged = command.ExecuteNonQuery();
                    int nrOfRecordsChanged1 = command1.ExecuteNonQuery();

                    return nrOfRecordsChanged + nrOfRecordsChanged1;
                
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }





            finally
            {
                connection.Close();
            }
            //return 0;

        }
        public int  Accout(int id)
        {

           
            String sql0 = "Select`Money_In_Account` From `account`  Where `Customer_Id`=" + id + ";";

            MySqlCommand command0 = new MySqlCommand(sql0, connection);
            try
            {
                connection.Open();
                int money = Convert.ToInt32(command0.ExecuteScalar());
                if (money >= 20)
                {
                   
                    return 1;
                }

                else { return 0; }
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }





            finally
            {
                connection.Close();
            }
            //return 0;

        }
    }
}
