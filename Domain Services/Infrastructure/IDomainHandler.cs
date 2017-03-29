namespace Project.Services.Providing.Infrastructure
{
    public interface IDomainHandler<T> where T : IDomainEvent
    {
        void Handle(T @event);
    }
}
