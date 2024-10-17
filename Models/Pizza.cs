namespace SWEPP.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();
        public string Crust { get; set; }
        public decimal Price { get; set; }
    }
}