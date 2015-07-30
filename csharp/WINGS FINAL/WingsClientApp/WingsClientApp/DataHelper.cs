using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WingsClientApp
{
    public class DataHelper
    {
        public MySqlConnection connection;
       
        public DataHelper()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi298536;" +
                                    "user id=dbi298536;" +
                                    "password=SISnLjRGxk;";

            connection = new MySqlConnection(connectionInfo);
        }


        public List<string> ListOfProduct()
        {
            List<string> products = new List<string>();
            string sql = "Select Name From product";
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

                    
                    lname = Convert.ToString(reader["Name"]);
                   
                  products.Add(lname);



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

            return products;
        

                
        }
        public List<string> ListOfShops()
        {
            List<string> shops = new List<string>();
            string sql = "Select Name From shop";
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


                    lname = Convert.ToString(reader["Name"]);

                    shops.Add(lname);



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

            return shops;



        }

        public Count NumberOfReservation()
        {
            String sqlReser = "SELECT COUNT(*) FROM user_reservation;";
            String sqlEntree = "SELECT COUNT(*) FROM user_checking_in;";
            String sqlOut = "SELECT COUNT(*) FROM user_checking_in Where `CheckIn/CheckOut` = 'CheckOut';";
            String sqlTMoney = "SELECT Sum(Total_Money_Sent) FROM account;";
           
           
            MySqlCommand command0 = new MySqlCommand(sqlReser, connection);
            MySqlCommand command1 = new MySqlCommand(sqlEntree, connection);
            MySqlCommand command2 = new MySqlCommand(sqlOut, connection);
            MySqlCommand command3 = new MySqlCommand(sqlTMoney, connection);
          
            
            try
            {
                connection.Open();


                int tRerve = Convert.ToInt32(command0.ExecuteScalar());
               
                int tEntree = Convert.ToInt32(command1.ExecuteScalar());

                int tOut = Convert.ToInt32(command2.ExecuteScalar());
                int tMoney = Convert.ToInt32(command3.ExecuteScalar());
              
                Count my1 = new Count(tRerve, tEntree, tOut, tMoney);

                return my1;
               
            }
            catch
            {
                return null;

            }
            finally
            {
                connection.Close();
            }
            
        }
        public Item Nuberofcheckinusers()
         {
             String sqlTInvoice = "SELECT Sum(Total_Money) FROM invoice;";
             String sqlTLending = "SELECT Sum(Price) FROM lending;";
             String sqlCamping = "SELECT Count(Customer_Id) FROM camping;";
             String sqlRent = "SELECT Sum(S.Rent) From camping d join tents  S on d.Tent_Number=S.Tent_Number;";
             String sqlCapacity = "SELECT Count(*) From tents where Isfull=0;";
             MySqlCommand command4 = new MySqlCommand(sqlTInvoice, connection);
            
             MySqlCommand command6 = new MySqlCommand(sqlCamping, connection);
             MySqlCommand command7 = new MySqlCommand(sqlRent, connection);
             MySqlCommand command8 = new MySqlCommand(sqlCapacity, connection);
            try
            {
                connection.Open();
                int tCamping = Convert.ToInt32(command6.ExecuteScalar());
                int tRent = Convert.ToInt32(command7.ExecuteScalar());
                int tCapacity = Convert.ToInt32(command8.ExecuteScalar());
                int tInvoice = Convert.ToInt32(command4.ExecuteScalar());

                Item my = new Item(tInvoice, tCamping, tRent, tCapacity);

                return my;
            }
            catch
            {
                return null;

            }
            finally
            {
                connection.Close();
            }
        }
        public int Nuberofcheckoutusers()
        {
            String sql = "SELECT COUNT(*) FROM user_checkout;";
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
        public int Totaltransferredmoney()
        {
            String sql = "SELECT Sum(Total_Money_Sent) FROM account;";
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
        public int Totalmoneypaidbyuser()
        {
            String sql = "SELECT Sum(Total_Money) FROM invoice;";
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
        public int TotalmoneypaidbyuserLending()
        {
            String sql = "SELECT Sum(Price) FROM lending;";
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
        public int bookeduserforcamping()
        {
            String sql = "SELECT Count(Customer_id) FROM camping;";
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
        public int Totalrent()
        {
            String sql = "SELECT Sum(S.Rent) From camping d join tents  S on d.Tent_Number=S.Tent_Number;" ;
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
        public int TotalUnitsOfProductSold(string code)
        {
            String sql = "SELECT Sum(Quantity) From invoice where Product_Code = (Select Product_Code From product where Name ='" + code + "') GROUP BY Product_Code;";
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
        public int TotalMoneySoldByShops(string code)
        {
            String sql = "SELECT Sum(Total_Money) From invoice where Shop_Id = (Select Shop_Id From shop where Name ='" + code + "') GROUP BY Shop_Id;";
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
        public int TotalFreeTents()
        {
            String sql = "SELECT Count(*) From tents where Isfull=0;";
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
