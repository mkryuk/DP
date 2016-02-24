namespace DP.Creational.AbstractFactory
{
    public class WoodenCar : IProduct
    {
        public string Name { get; set; }

        public WoodenCar()
        {
            Name = "wooden car";
        }
    }
}