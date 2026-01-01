using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.Entities
{
    class Comment : Content
    {
        public Comment(string body, User author)
            : base(Guid.NewGuid().ToString(), body, author)
        {
        }
    }
}
