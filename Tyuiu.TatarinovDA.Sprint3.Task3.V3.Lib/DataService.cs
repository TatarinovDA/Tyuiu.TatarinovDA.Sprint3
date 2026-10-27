using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TatarinovDA.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }

            int minCount = int.MaxValue;
            int currentCount = 0;
            

            
            foreach (char c in value)
            {
                if (c == item)
                {
                    currentCount++;
                    
                }
                else
                {
                    
                    if (currentCount > 0)
                    {
                        if (currentCount >= 2 && currentCount < minCount)
                        {
                            minCount = currentCount;
                        }
                        currentCount = 0; 
                    }
                }
            }

            
            if (currentCount >= 2 && currentCount < minCount)
            {
                
                    minCount = currentCount;
                
            }

            
            return minCount == int.MaxValue ? 0 : minCount;
        }
    }
}
