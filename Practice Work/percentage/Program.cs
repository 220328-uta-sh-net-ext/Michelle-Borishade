using System.Collections;  
    namespace percentage
{
    public class Percentage
    {
        public decimal Calculator(List<decimal> ratings)
        {
            //store the count & initialize
            int count = ratings.Count();
            //initialize another variable for the sum; default 0
            decimal sum = 0;
            //get the sum of all elements in the list
            foreach (var item in ratings)
            {
                //increment the sum by items in the list
                //get total sum of all values
                sum += item;
            }
            //calculate the average (sum div elem)
            decimal average = sum / count;
            System.Console.WriteLine("The Average is " + average);
            //return the average
            return average;
        }
    }
    public class Program
    {
        public static void Main() 
        {
            List<decimal> list2 = new List<decimal>();
            list2.Add(7.5M);
            list2.Add(8.2M);
            list2.Add(9.6M);
            //Initialize a new object
            Percentage today = new Percentage();
            decimal result = today.Calculator(list2);
        
        }


    }
       
}
