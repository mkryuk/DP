namespace DP.Creational.AbstractFactory
{
    public class SteelCar : IProduct
    {
        public string Name { get; set; }

        public SteelCar()
        {
            Name = "steel car";
        }
    }
}