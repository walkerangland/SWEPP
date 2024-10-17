namespace SWEPP.Models
{
    public class Order
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public decimal TotalPrice => Pizzas.Sum(pizza => pizza.Price);
    }
}