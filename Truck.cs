namespace CSharpDiscovery.Quest04
{
    public class Truck : Vehicule
    {
        public int Tonnage {get;set;}
        public Truck() : base()
        {
            Tonnage = 0; 
        }

        public Truck(int tonnage, string brand, string color, int currentSpeed=0) : base() {
            this.Tonnage = tonnage; 
            this.Brand = brand; 
            this.Color = color; 
            this.CurrentSpeed = currentSpeed; 
        } 

        public override string ToString() { 
            return Color + " " + Brand + " " + Tonnage + "T Truck"; 
        }
        public override void Accelerate(int Speed)
        {
            int NewSpeed = Speed + CurrentSpeed;
            if (NewSpeed<=100) {
                CurrentSpeed =  NewSpeed; 
            } else {
                CurrentSpeed = 100;
            }
        }

        public override void Brake(int BrakePower)
        {
            int NewSpeed = CurrentSpeed - BrakePower; 
            if (NewSpeed>=0) {
                CurrentSpeed = NewSpeed; 
            } else {
                CurrentSpeed = 0; 
            }
        }
    }
}