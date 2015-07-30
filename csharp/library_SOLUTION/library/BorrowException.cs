using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{   //Exercise 3b
    class BorrowException: Exception
    {
        public BorrowException()
            : base()
        { }
        
         public BorrowException(String message)
            : base(message)
         { }
       
    }
}
