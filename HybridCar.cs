namespace CSharpDiscovery.Quest04 {
    
 
    public class HybridCar : Car, IElectricCar, IThermalCar {

        public int FuelLevel {get;set;}
        public int BatteryLevel {get;set;}

        public HybridCar() : base()
        {
            BatteryLevel = 100; 
            FuelLevel = 100; 
        }

        public HybridCar(string model, string brand, string color, int currentSpeed=0) : base()
        {
            this.Model = model; 
            this.Brand = brand; 
            this.Color = color; 
            this.CurrentSpeed = currentSpeed; 
            BatteryLevel = 100; 
            FuelLevel = 100; 
        }

        public void FillUp() {
            FuelLevel = 100; 
        }

        public void Recharge() {
             BatteryLevel = 100; 
        }

        public int GetBatteryLevel()
        {
            return BatteryLevel; 
        }

        public int GetFuelLevel()
        {
            return FuelLevel; 
        }

         public override string ToString() { 
            return Color + " " +  Brand + " " + Model + ", Battery: " + BatteryLevel + "%, Fuel: " + FuelLevel + "%"; 
        }
    }
}