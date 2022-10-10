namespace CSharpDiscovery.Quest04 {
    public class Car : Vehicule {
        public string? Model {get; set;}

        public Car() : base()
        {
            Model="Unknown";
        }

        public Car(string model, string brand, string color, int currentSpeed = 0) : base()
        {
            this.Model = model; 
            this.Brand = brand; 
            this.Color = color; 
            this.CurrentSpeed = currentSpeed; 
        }

        public override string ToString() { 
            return Color + " " +  Brand + " " + Model;
        }

        public override void Accelerate(int Speed)
        {
            int NewSpeed = Speed + CurrentSpeed;
            if (NewSpeed<=180) {
                CurrentSpeed =  NewSpeed; 
            } else {
                CurrentSpeed = 180;
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

