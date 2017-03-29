using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Services.Providing.Infrastructure;
using Project.Services.Providing.Model;
using Project.Services.Providing.Model.Events;

namespace Project.Test
{
    [TestClass]
    public class PurchaseOrderFixture
    {
        [TestMethod]
        public void StockedPurchaseOrder_ChangeStatus_Stocked()
        {
            var po = new PurchaseOrder();

            //Inject the domain event handler
            //In Application Layer you should use Ninject or SimpleIoC or Castle Windsor 
            IDomainHandler<Stocked> h = new StockedHandler();
            DomainEvent.Register<Stocked>(h.Handle);

            po.FullyStocked();
            Assert.AreEqual("S", po.Status);
        }
    }
}
