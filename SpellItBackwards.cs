namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
           string reversed = ""; 
           for (int i =str.Length-1; i > -1; i--) {
            reversed += str[i]; 
           }
           return reversed; 
        }
    }
}