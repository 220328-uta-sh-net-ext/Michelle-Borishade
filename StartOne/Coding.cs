
namespace StartOne
{

    public class Coding
    {
        public static bool Palidrone(string word)
        {
          // get the word length and store value in integer
                int min = 0;
                int max = word.Length - 1;
                while (true)
                {
                    if (min > max)
                    {
                        Console.WriteLine(true);
                        return true;
                    }
                    char a = word[min];
                    char b = word[max];
                    //convert chars to lower for comparison
                    if (char.ToLower(a) != char.ToLower(b))
                    {
                        Console.WriteLine(false);
                        return false;
                    }
                    //increment minimum 
                    min++;
                    //decrement maximum
                    max--;
                }
  

        }

     }
    
        
}