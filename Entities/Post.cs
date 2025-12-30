using StackOverFlow.Enum;
using StackOverFlow.Observers;
using StackOverFlow.Entities;

namespace StackOverFlow.Entities
{
    abstract class Post : IPostPublisher
    {
        protected Dictionary<string, VoteType> votes = new Dictionary<string, VoteType>();
        protected int voteCount;
        protected Comment[] comments;
        protected List<IPostObserver> observers = new List<IPostObserver>();

        public Post()
        {
            this.voteCount = 0;
            this.comments = Array.Empty<Comment>();
        }

        public void AddObserver(IPostObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IPostObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(Event postEvent)
        {
            foreach(var observer in observers)
            {
                observer.OnPostEvent(postEvent);
            }
        }
}
