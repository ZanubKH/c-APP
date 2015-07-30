using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;  //because we are using files

namespace DatabaseConnection
{
    public class DataHelperShop
    {
        public MySqlConnection connection;
        public List<int> log ;
        public List<Product> Sweets;
        public List<Product> colddrinks;
        public List<Product> Chocklates;
        public List<Product >Fish;


        public DataHelperShop()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi298536;" +
                                    "user id=dbi298536;" +
                                    "password=SISnLjRGxk;";

            connection = new MySqlConnection(connectionInfo);
            log = new List<int>();
           Sweets = new List<   Product>();
            colddrinks = new List<Product>();
            Chocklates = new List<Product>();
            Fish = new List<Product>();

        }
        public bool InserInvoice(int id, int price)
        {

            String sql = "INSERT INTO `invoiceno`(`Customer_Id`, `Total_Money`) VALUES ('" + id + "','" + price + "');";
            //INSERT INTO `dbi298536`.`user_checking_in` (`Customer_Id`, `Shop_Id`,'Product_Code,'Time','Date','Quantity','Total_Money) VALUES ('25', CURRENT_TIME());
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                if (nrOfRecordsChanged == 0)
                { return false; }


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

        public int GetOrderNumber(int id)
        {
            String sql = "Select Max(`Invoice`) FROM `invoiceno` Where `Customer_Id` = '" + id + "';";
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
        public List<int> filllog()
        {
            String sql = "SELECT * FROM `user_checking_in`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();



                
                int nr;

                
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);
                   
                    log.Add(nr);



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
        
        public void fillProducts()
        {
            String sql = "SELECT * FROM  `product`;";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                string nr;
                string name;
              
                double price;
                string type;
                while (reader.Read())
                {

                   
                    name = Convert.ToString(reader["Name"]);
                    price = Convert.ToDouble(reader["Price"]);
                   type = Convert.ToString(reader["Type"]);
                   nr = Convert.ToString(reader["Product_Code"]);



                   if (type == "Sweet")
                    { Sweets.Add(new Product(nr, name,price)); }
                   if (type == "Cold Drink")
                    { colddrinks.Add(new Product(nr, name,  price)); }
                   if (type == "Choclate")
                    { Chocklates.Add(new Product(nr, name,  price)); }
                   if (type == "Fish")
                    {
                        Fish.Add (new Product(nr,name,price));
                    }

                

                }
            }
            catch
            {
                MessageBox.Show("error while loading the products");
            }
            finally
            {
                connection.Close();
            }

            
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
        public bool SearchProduct(int id)
        {
            String sql = "SELECT * FROM `Product`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                
                int nr;
                
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Article_Id"]);
                    if (nr == id)
                    {
                        int s = Convert.ToInt32(reader["lendornot"]);
                        if (s != 1)
                        { return true; }
                        else
                        { return false; }
                    }


                    else
                    { return false; }

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


      
        public int SearchMoney(int id)
        {
            String sql = "SELECT * FROM `account`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                
                int nr;
                
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);
                   
                   /// cr = Convert.ToString(reader["Date"]);
                    if (nr == id)
                    {
                        int money = Convert.ToInt32(reader["Money_In_Account"]);
                        return money;
                    }



                }
            }
            catch
            {
                MessageBox.Show("error while loading the money");
            }
            finally
            {
                connection.Close();
            }

            return 0;

        }

        public Product  Getproduct(string pro)
        {
            foreach (Product s in Sweets)
            {
             if(s.Productid==pro)
                {
                    return s;
                }
            }
            foreach (Product s in colddrinks)
            {
                if (s.Productid ==pro)
                {
                    return s ;
                }
            }
            foreach (Product s in Chocklates)
            {
                if (s.Productid==pro)
                {
                    return s;
                }
            }
            foreach (Product s in Fish)
            {
                if (s.Productid == pro)
                {
                    return s;
                }
            }
            return null;

        }
     

       
        public int UpdateArticleReturn(int id)
        {

            String sql = "Update `article_stock` Set `lendornot` = 0  Where `Article_Id`=" + id + ";";

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
            return 0;

        }
       
        public int UpdateAccount(int id,int money)
        {


            String sql2 = "Update `account` Set `Money_In_Account` =`Money_In_Account`-"+ money+"  Where `Customer_Id`=" + id + ";";

           
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
            return 0;

        }
        public bool Inserproduct(List<Invoice >data,int id,string shopid)
        {
            try
                {
                   
            foreach (Invoice d in data)
            {
                connection.Open();
                String sql = "INSERT INTO `invoice`(`Customer_Id`, `Shop_Id`,`Product_Code`,`Time`,`Date`,`Quantity`,`Total_Money`) VALUES ('" + id + "','" + shopid + "','" + d.Pro.Productid + "',Current_Time(),Current_Date(),'" + d.Quantity + "','" + d.totalprice() + "');";
                //INSERT INTO `dbi298536`.`user_checking_in` (`Customer_Id`, `Shop_Id`,'Product_Code,'Time','Date','Quantity','Total_Money) VALUES ('25', CURRENT_TIME());
                MySqlCommand command = new MySqlCommand(sql, connection);

                
                    int nrOfRecordsChanged = command.ExecuteNonQuery();
                    if (nrOfRecordsChanged == 0)
                    { return false; }
                    connection.Close();
                    
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
        



        }
    }

