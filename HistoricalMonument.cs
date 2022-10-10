namespace CSharpDiscovery.Quest03 
{
    public class HistoricalMonument : PointOfInterest {
        public int BuildYear {get; set;}
        public HistoricalMonument()
        {
        }

        public HistoricalMonument(string name, double latitude, double longitude, int buildYear ) : base()
        { 
            this.Name = name; 
            this.Latitude = latitude; 
            this.Longitude = longitude; 
            this.BuildYear = buildYear; 
        }

         public override string ToString() { 
            return string.Format(Name! + " is a historical monument built in " + BuildYear ); 
        }
    }

    
}
