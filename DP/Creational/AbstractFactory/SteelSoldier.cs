namespace DP.Creational.AbstractFactory
{
    public class SteelSoldier : IProduct
    {
        public string Name { get; set; }

        public SteelSoldier()
        {
            Name = "steel soldier";
        }
    }
}