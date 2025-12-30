using StackOverFlow.Entities;

namespace StackOverFlow
{
    class StackOverFlowService
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private Dictionary<string, Question> questions = new Dictionary<string, Question>();
    }
}
