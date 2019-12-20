using System;
using StatePattern.State;

namespace StatePattern
{
    public class Order
    {
        public string RestaurantName { get; set; }
        public string Food { get; set; }
        private OrderState _state;

      
        public Order()
        {                   
        }

        public void TransitionTo(OrderState state)
        {
            _state = state;
            _state.CheckOrder(this);
        }

        public void DoOrder()
        {
            TransitionTo(new AwaitingConfirmation());
        }

        public void RateOrder()
        {
            Console.WriteLine("Thanks for your order, could you spend a minute to rate your order?");
            var rating = Console.ReadLine();

            Console.WriteLine($"Thanks for your rating: {rating}");
        }

    }
}
