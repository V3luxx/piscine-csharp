namespace CSharpDiscovery.Quest01
{
    public class ConcatEverything_Exercice
    {
        public static string ConcatEverything(params string[] str)
        {
            string res = ""; 
            for (int i =0; i < str.Length; i++) {
                res += str[i]; 
            }
            return res; 
            }
    }
}