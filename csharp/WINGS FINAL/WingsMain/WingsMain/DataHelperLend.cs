using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;  //because we are using files

namespace DatabaseConnection
{
    public class DataHelperLend
    {
        public MySqlConnection connection;
        public List<int> log ;
        
        public List<Article> Products;

        public DataHelperLend()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi298536;" +
                                    "user id=dbi298536;" +
                                    "password=SISnLjRGxk;";

            connection = new MySqlConnection(connectionInfo);
            log = new List<int>();
           
            Products = new List<Article>();

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
        
        public void fillArticles()
        {
            String sql = "SELECT * FROM `article_stock`";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();



                
                int nr;
                string name;
                string comp;
                int exist;
                int price;
                string des;
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Article_id"]);
                    name = Convert.ToString(reader["Name"]);
                    des = Convert.ToString(reader["Description"]);
                    comp = Convert.ToString(reader["Company_name"]);
                    price = Convert.ToInt32(reader["Price"]);
                    exist = Convert.ToInt32(reader["lendornot"]);
                    Products.Add(new Article(nr, name, comp, price, exist, des));
                    



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
        public bool SearchArticle(int id)
        {
            String sql = "SELECT * FROM `article_stock`";
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
                MessageBox.Show("error while loading the students");
            }
            finally
            {
                connection.Close();
            }

            return 0;

        }
        public int UpdateAccount(int id,int money)
        {

            String sql = "Update `account` Set `Money_In_Account` = `Money_In_Account`-"+money+"  Where `Customer_Id`=" + id + ";";

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
        public Article GetArticle(int art)
        {
            foreach (Article l in Products)
            {
                if (l.Article_id==art)
                {
                    return l;
                }
            }
            
            return null;

        }
     

        public List<Article> GetLended(int id)
        {
            List<Article> hosters = new List<Article> { };
            String sql = "SELECT * FROM `lending` where `Customer_Id`="+id+ "  And `Return/Lend`=1;";
            MySqlCommand command = new MySqlCommand(sql, connection);



            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int nr;

                int art;
                
                while (reader.Read())
                {

                    nr = Convert.ToInt32(reader["Customer_Id"]);
                    art = Convert.ToInt32(reader["Article_Id"]);
                  
                        Article A = GetArticle(art);
                        hosters.Add(A);
                  



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
            //return 0;

        }
        
     
        public int UpdateArticleLend(int id)
        {   
            
                String sql = "Update `article_stock` Set `lendornot` = 1  Where `Article_Id`="+ id+";" ;
               
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
        public int UpdateCustomer(int id,int art)
        {

            
            String sql2 = "Update `lending` Set `Return/Lend` = 0  Where `Customer_Id`=" + id +" AND `Article_Id`="+art+";";

           
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
        public int InserCustomer(int id, int art,int price)
        {

            String sql = "INSERT INTO `lending`(`Customer_Id`,`Article_Id`,`Date`,`time`,`Price`,`Return/Lend`) VALUES ('" + id + "','" + art + "',Current_Date(),Current_Time(),'" + price + "','1');";
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
        



        }
    }

