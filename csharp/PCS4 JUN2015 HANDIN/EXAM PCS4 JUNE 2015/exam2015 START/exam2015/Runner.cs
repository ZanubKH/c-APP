using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2015
{
    public class Runner
    {  
        public int IdNr { get; private set; }
        public string Name { get; private set; }
        public List<int> MyTimes { get; private set; }
        public List<int> Temp { get; private set; }
        public LinkedTimeList L;

        private static int nextIdNr = 100;
        public int[] Best5 { get; private set; }
         public int leftbound ;
         public int rightbound;

        public Runner(string name)
        {
            IdNr = nextIdNr++;
            this.Name = name;
            MyTimes = new List<int>();
            Temp = new List<int>();
            leftbound = 0;
            L = new LinkedTimeList();

            Best5 = new int[5];
            rightbound = Best5.Length - 1;
            for (int i = 0; i < 5; i++)
            {
                Best5[i] = 1000;
            }
        }
        public delegate void NewRecord(Runner sender, int newrecord);
        public event NewRecord NewRecords;
        public bool CheckNewTime(int t)
        {
            foreach (int i in MyTimes)
            {
                if (i < t)
                { return false; }
            }
            return true;
        }
        public void AddNewTIme(int t)
        {   
            MyTimes.Add(t);
            if (NewRecords != null)
            {
                if (CheckNewTime(t) == true)
                {
                    NewRecords(this, t);
                }
            }
        }

        public override string ToString()
        {
            string s = IdNr + ": " + Name + " with times: ";
            foreach (int i in MyTimes)
                s += i + " - ";
            return s;
        }
          private int IndexOfTheSmallestOfTheRest(int firstIndexOfRest)
        {
            int indexOfSmallest = firstIndexOfRest;

            for (int j = firstIndexOfRest + 1; j < Temp.Count; j++)
            {
                if (Temp[j] < Temp[indexOfSmallest])
                {
                    indexOfSmallest = j;
                }
            }
            return indexOfSmallest;
        }
      
        private void Swap(int i, int j)
        {
            int temp = Temp[i];
            Temp[i] = Temp[j];
            Temp[j] = temp;



        }
        public void FillBest5()
        {

            Temp = MyTimes;
            for (int i = 0; i <Temp.Count; i++)
            {
                //find where is the smallest number of the rest


                //find where is the smallest number of the rest
                int index = IndexOfTheSmallestOfTheRest(i);

                //swap it with the first of the rest
                Swap(index, i);
            }

            for (int i = 0; i < 5; i++)
            {

                //find where is the smallest number of the rest
                if (Temp.Count > i)
                {
                    Best5[i] = Temp[i];
                }
                else
                {
                    Best5[i] = 1000;
                }
            }

        }
        public  bool SearhInBest5( int time)
        {
            int mid = (leftbound + rightbound) / 2;
            if (leftbound == mid || rightbound == mid)
            {
                if (Best5[mid] == time)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                while (Best5[mid] != time)
                {
                    if (Best5[mid] < time)
                    {
                        leftbound = mid;
                        return SearhInBest5( time);
                    }
                    if (Best5[mid] > time)
                    {
                        rightbound = mid;
                        return SearhInBest5(time);
                    }
                    if (Best5[mid] == time)
                    {
                        return true;

                    }
                }

                return false;

            }
        }
    }
}
