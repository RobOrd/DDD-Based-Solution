namespace Project.Services.Providing.Infrastructure
{
    public interface IEventDispatcher
    {
        void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent;
    }
}
