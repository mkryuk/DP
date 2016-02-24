namespace DP.Behavioral.Chain_of_responsibility
{
    public enum ResourceType
    {
        Gold,
        Silver,
        Copper
    }
    public class Resource
    {
        public ResourceType Type { get; set; }
        public int Quantity { get; set; }
    }
}