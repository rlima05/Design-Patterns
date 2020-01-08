using static System.Console;

namespace TemplateMethodPattern
{
    public abstract class Traveller
    {
        private void PrepareLuggage() => WriteLine("Preparing my luggage");

        private void BuyTicket() => WriteLine("Buying Ticket to my travel");
        private void HeadToAccommodation() => WriteLine("Heading to my accommodation");
        
        protected abstract void SpecificActions();

        public void Start()
        {
            BuyTicket();
            PrepareLuggage();
            SpecificActions();
            HeadToAccommodation();
        }
    }
}
