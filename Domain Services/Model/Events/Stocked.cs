using Project.Services.Providing.Infrastructure;

namespace Project.Services.Providing.Model.Events
{
    public class Stocked : IDomainEvent
    {
        public PurchaseOrder Order { get; set; }
    }
}
