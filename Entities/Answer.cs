using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.Entities
{
    class Answer : Post
    {
        private bool isAccepted = false;

        public Answer(string body, User author) : base(Guid.NewGuid().ToString(), body, author)
        {
        }

        public void SetAccepted(bool accepted)
        {
            isAccepted = accepted;
        }

        public bool IsAcceptedAnswer() { return isAccepted; }

    }
}
