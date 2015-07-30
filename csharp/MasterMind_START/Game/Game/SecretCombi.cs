using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
   public class SecretCombi
    {
        public int[] Array = new int[4];
        Random r = new Random();
        public SecretCombi()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                int number = r.Next(0, 11);
                foreach (int j in Array)
                {
                    if (j == number)
                    {
                        number = r.Next(0, 11);
                    }
                }
                Array[i] = number;
            }
          
        }

        public bool Guess(int[] temp,out int RScore, out int LScore,ref int credits)
        {
            RScore = 0;
            LScore = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j =0;j<Array.Length;j++)
                {
                    if (temp[i] == Array[j])
                    {
                        if (i == j)
                        {
                            RScore++;
                        }
                        else { LScore++; } 
                    }
                }
            }
            if (LScore == 0 && RScore == 4)
            {
                return true;
            }
            else
            {
                if (LScore + RScore >= 3)
                {
                    credits = credits - 5;
                }
                if (LScore + RScore <= 2 && LScore + RScore >= 1)
                {
                    credits = credits - 10;
                }
                if (LScore + RScore == 0)
                {
                    credits = credits - 15;
                }
                return false;
               
                }
            
        }
    }
}
