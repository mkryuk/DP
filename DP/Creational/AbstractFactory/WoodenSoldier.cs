namespace DP.Creational.AbstractFactory
{
    public class WoodenSoldier : IProduct
    {
        public string Name { get; set; }

        public WoodenSoldier()
        {
            Name = "wooden soldier";
        }
    }
}