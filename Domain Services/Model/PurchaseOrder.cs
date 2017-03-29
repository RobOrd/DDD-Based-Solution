using Project.Services.Providing.Infrastructure;
using Project.Services.Providing.Model.Events;
using System;

namespace Project.Services.Providing.Model
{
    public class PurchaseOrder
    {
        public Guid Id { get; private set; }
        public DateTime StockedDate { get; private set; }
        public string Status { get; set; }

        public PurchaseOrder()
        {
            this.Id = Guid.NewGuid();
        }

        public void FullyStocked()
        {
            StockedDate = DateTime.Now;
            DomainEvent.Raise(new Stocked() { Order = this });
        }
    }
}
