namespace CSharpDiscovery.Quest02
{
    public class AreEquals_Exercice
    {
        public static bool AreEquals(int[] tab1, int[] tab2)
        {
           if (tab1.SequenceEqual(tab2)) {
            return true; 
           } 
           return false; 
        }
    }
}