using StackOverFlow.Entities;

namespace StackOverFlow.Strategy
{
    interface ISearchStrategy
    {
        List<Question> Filter(List<Question> questions);
    }
}
