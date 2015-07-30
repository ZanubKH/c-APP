using System;
using System.Collections.Generic;

using System.Text;


namespace DatabaseConnection
{
 public   class Login
    {
    public    string Lastname { get; set; }
     public   string Firstname { get; set; }
        public int Customerid {get;set;}
   public    string Dateofbirth { get; set; }
   
   public string Gender { get; set; }
   public Login(string lname, string fname, int cus, string dateb, string gen)
   {
       Lastname = lname;
       Firstname = fname;
       Customerid = cus;
       Dateofbirth = dateb;
       
       Gender = gen;
   }
   public override string ToString()
   {
       string s;
       s= "" + Lastname + " , " + Firstname + "  Customer_Id : " + Customerid + " Dob  :  " + Dateofbirth + " Gender:  " + Gender;
       return s;
   }
    
 

    }
}
