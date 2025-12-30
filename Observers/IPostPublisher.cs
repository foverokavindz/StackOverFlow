using StackOverFlow.Entities;

namespace StackOverFlow.Observers
{
    interface IPostPublisher
    {
        void AddObserver(IPostObserver subscriber);
        void RemoveObserver(IPostObserver subscriber);
        void NotifyObservers(Event postEvent);
    }
}
