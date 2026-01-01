using StackOverFlow.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.Strategy
{
    class UserSearchStrategy : ISearchStrategy
    {
        private readonly User user;

        public UserSearchStrategy(User user)
        {
            this.user = user;
        }

        public List<Question> Filter(List<Question> questions)
        {
            return questions
                .Where(q => q.GetAuthor().GetId().Equals(user.GetId()))
                .ToList();
        }
    }
}
