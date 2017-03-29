using Project.Services.Providing.Model.Events;

namespace Project.Services.Providing.Infrastructure
{
    public class StockedHandler : IDomainHandler<Stocked>
    {
        public void Handle(Stocked @event)
        {
            @event.Order.Status = "S";
            //Send notification to supervisor
        }
    }
}
