using SWEPP.Models;

namespace SWEPP.Services
{
    public class OrderService
    {
        public Order CurrentOrder { get; private set; } = new Order();

        public void AddToOrder(Pizza pizza)
        {
            CurrentOrder.Pizzas.Add(pizza);
        }

        public void ClearOrder()
        {
            CurrentOrder = new Order();
        }
    }
}