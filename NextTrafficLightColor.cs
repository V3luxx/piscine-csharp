using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            if (currentColor == TrafficLightColor.None) {
                return TrafficLightColor.None;
            }
            int length = Enum.GetNames(typeof(TrafficLightColor)).Length;

           int index = (int) currentColor;

           if (index == length-1) {
            return (TrafficLightColor) 1;
           } else {
                return (TrafficLightColor) index+1;
           }
        }
    }
}