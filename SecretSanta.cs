namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
            List<string> people_receiving = new List<string>();
            foreach (string names in people){
                people_receiving.Add(names);
            }
            Dictionary<string, string> NamesSet = new Dictionary<string, string>();

            foreach (string giver in people){
                people_receiving.Remove(giver);
                string receiver = people_receiving.ElementAt(new Random().Next(people_receiving.Count-1));
                people_receiving.Remove(receiver);
                people_receiving.Add(giver);
                NamesSet.Add(giver, receiver);
            }
            return NamesSet;
        }
    }
}