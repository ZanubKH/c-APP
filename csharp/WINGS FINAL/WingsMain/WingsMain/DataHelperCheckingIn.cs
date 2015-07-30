using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;  //because we are using files

namespace DatabaseConnection
{
    public class DataHelperCheckingIn
    {
        public MySqlConnection connection;
        public List<Login> log ;
    

        public DataHelperCheckingIn()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi298536;" +
                                    "user id=dbi298536;" +
                                    "password=SISnLjRGxk;";

            connection = new MySqlConnection(connectionInfo);
            log = new List<Login>();
            

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
                int contact;
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
        public int UpdateAccout(int id)
        {

            String sql = "Update `account` Set `Money_In_Account` = 0  Where `Customer_Id`=" + id + ";";

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
            //return 0;

        }
        public int InserCheckin(int id,string rfid)
        {

            String sql = "INSERT INTO `user_checking_in`(`Customer_Id`,`RFID`,`CheckIn/CheckOut`) VALUES ('" + id + "','"+rfid + "','CheckIn');";
            //INSERT INTO `dbi298536`.`user_checking_in` (`Customer_Id`, `Time_In`) VALUES ('25', CURRENT_TIME());
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
        public int InserCheckin1(int id)
        {

            String sql = "INSERT INTO `user_checking_in`(`Customer_Id`,`RFID`,`CheckIn/CheckOut`) VALUES ('" + id + "','','CheckIn');";
            //INSERT INTO `dbi298536`.`user_checking_in` (`Customer_Id`, `Time_In`) VALUES ('25', CURRENT_TIME());
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
        //UPDATE `dbi298536`.`user_checking_in` SET `CheckIn/CheckOut` = 'CheckIn' WHERE `user_checking_in`.`Customer_Id` = 1

        public int UpdateCheckin(int id)
        {

            String sql = "UPDATE `user_checking_in` SET `CheckIn/CheckOut` = 'CheckIn' WHERE `user_checking_in`.`Customer_Id` = " + id + ";";
           
            //INSERT INTO `dbi298536`.`user_checking_in` (`Customer_Id`, `Time_In`) VALUES ('25', CURRENT_TIME());
            MySqlCommand command = new MySqlCommand(sql, connection);
          
            try
            {
                connection.Open();
               
                    //if (CheckIfExistsInChecking(id) == "ALready checked out")
                    //{
                        int nrOfRecordsChanged = command.ExecuteNonQuery();
                        return nrOfRecordsChanged;
                //    }
                //}
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }


            finally
            {
                connection.Close();
            }

            //return -1;
        }
        public int UpdateCheckOut(int id)
        {

             String sql1 = "UPDATE `user_checking_in` SET  `CheckIn/CheckOut` = 'CheckOut' WHERE `user_checking_in`.`Customer_Id` = " + id + ";";

            //INSERT INTO `dbi298536`.`user_checking_in` (`Customer_Id`, `Time_In`) VALUES ('25', CURRENT_TIME());
           
            MySqlCommand command1 = new MySqlCommand(sql1, connection);

            try
            {
                connection.Open();
                //if (CheckIfExistsInChecking(id) == "ALready checked in")
                //{
                    int nrOfRecordsChanged = command1.ExecuteNonQuery();
                    return 1;
                //}
                //else
                //{
                //    if (CheckIfExistsInChecking(id) == "ALready checked out")
                //    {
                //        int nrOfRecordsChanged = command.ExecuteNonQuery();
                //        return 0;
                //    }
                //}
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }


            finally
            {
                connection.Close();
            }

            return -1;
        }
        public bool CheckIfExists(int id)
        {
            String sql = "SELECT * FROM `user_confirmation`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                String name;
                int nr;
                string cr;
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);

                    if (nr == id)
                    {
                        
                        { return true; }
                    }



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

            return false;
        }

       
        public string CheckIfExistsInChecking(int id)
        {
            String sql = "SELECT * FROM `user_checking_in`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

               
                int nr;
                string cr;
                
              
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);

                    if (nr == id)
                    {
                        cr = Convert.ToString(reader["CheckIn/CheckOut"]);
                        if (cr == "CheckIn")
                        { 
                            return "ALready checked in";
                        }
                        else 
                        {
                            return "ALready checked out";
                        }

                    }
                    



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
                return "Not exists"; 
        }


        
      
        public bool CheckRfid(string id)
        {
            String sql = "SELECT * FROM `user_checking_in`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int nr;
                string Rfid;
                string cr;
                while (reader.Read())
                {

                    //nr = Convert.ToInt32(reader["Customer_Id"]);
                    Rfid = Convert.ToString(reader["RFID"]);
                    //cr = Convert.ToString(reader["Time"]);
                    if (Rfid == id)
                        return false;



                }
            }
            catch
            {
                MessageBox.Show("error ");
            }
            finally
            {
                connection.Close();
            }

            return true ;

        }
        public int Accout(int id)
        {


            String sql0 = "Select`Loan` From `account`  Where `Customer_Id`=" + id + ";";

            MySqlCommand command0 = new MySqlCommand(sql0, connection);
            try
            {
                connection.Open();
                int money = Convert.ToInt32(command0.ExecuteScalar());
                
                if (money>0)
                {

                    return -1;
                }

                else { return 1; }
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }





            finally
            {
                connection.Close();
            }
            return 0;

        }

        public bool CheckLending(int id)
        {


            String sql0 = "Select `Customer_Id` ,`Return/Lend` From `lending` ;";

            MySqlCommand command0 = new MySqlCommand(sql0, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command0.ExecuteReader();

                int nr;
                int rOn;
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);
                    rOn = Convert.ToInt32(reader["Return/Lend"]);
                    if (nr == id && rOn == 1)
                    { return false; }

                }
            }
            catch
            {
                return false; //which means the try-block was not executed succesfully, so  . . .
            }





            finally
            {
                connection.Close();
            }
            return true;

        }
        public int InserConfirm(int id)
        {

            String sql = "INSERT INTO `user_confirmation`(`Customer_Id`) VALUES ('" + id + "');";
           
            //INSERT INTO `dbi298536`.`user_checking_in` (`Customer_Id`, `Time_In`) VALUES ('25', CURRENT_TIME());
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


        }
        public int InserLoan(int id)
        {


            String sql1 = "UPDATE `account` SET `Money_In_Account` =10 ,`Loan`=65 Where `Customer_Id`=" + id + ";";
            //INSERT INTO `dbi298536`.`user_checking_in` (`Customer_Id`, `Time_In`) VALUES ('25', CURRENT_TIME());
            
            MySqlCommand command1 = new MySqlCommand(sql1, connection);

            try
            {
                connection.Open();
                

                int nrOfRecordsChanged1 = command1.ExecuteNonQuery();

                return  nrOfRecordsChanged1;
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

    }
}
