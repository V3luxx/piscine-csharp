namespace CSharpDiscovery.Quest01
{
    public class BeginsWithSpecificCharacter_Exercice
    {
        public static bool BeginsWithSpecificCharacter(string str, char begin)
        {
           if (str.StartsWith(begin) == true) {
            return true; 
           }
           return false; 
        }
    }
}