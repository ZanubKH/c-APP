using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveries
{
  public   class Deliverable
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public Person Buyer {get; set;}
        public List<Deliverable> FindP;
        public Deliverable(int id, int weight, Person by)
        {
            Id = id;
            Weight = weight;
            Buyer = by;
            FindP = new List<Deliverable>();

        }
        public override string ToString()
        {
            return " Id " + Id + " weight " + Weight + " to be delivered at " + 
                Buyer.Name  + " - " + Buyer.HouseNumber+  "   "  + Buyer.Street +  " , " + Buyer.PostCode +
                "  " + Buyer.City;
            

        }
        public static List<Deliverable> SearchPerson(List<Deliverable> list, List<Deliverable> listAdd, string name, int leftboud, int rightbound)
        {
            int mid = (leftboud + rightbound) / 2;
            
            if (leftboud == mid || rightbound == mid)
            {
                if (list[mid].Buyer.Name == name)
                {
                    listAdd.Add(list[mid]);
                    return listAdd;
                }
                else
                    return null;
            }
            else
            {
                while ( ((leftboud != mid || rightbound != mid)))
                {
                    if (list[mid].Buyer.Name.CompareTo(name) == -1)
                    {
                        leftboud = mid;
                        return SearchPerson(list,listAdd,name, leftboud, rightbound);
                    }
                    if (list[mid].Buyer.Name.CompareTo(name)==1)
                    {
                        rightbound = mid;
                        return SearchPerson(list, listAdd, name, leftboud, rightbound);
                    }
                    if (list[mid].Buyer.Name.CompareTo(name) == 0)
                    {
                        //listAdd.Add(list[mid]);
                        for (int i = mid; list[mid].Buyer.Name==list[i].Buyer.Name&&  i<=list.Count; i++)
                        {
                            listAdd.Add(list[i]);
                        }
                        for (int i = mid-1
                            ; list[mid].Buyer.Name == list[i].Buyer.Name && i >= 0; i--)
                        {
                            listAdd.Add(list[i]);
                        }
                        return listAdd;
                        
                        
                      
                    }
                       
                      
                    }

                return listAdd;
                }


            }
        }
    }

