using StackOverFlow.Entities;

namespace StackOverFlow.Observers
{
    internal interface IPostObserver
    {
        void OnPostEvent(Event postEvent);
    }
}
