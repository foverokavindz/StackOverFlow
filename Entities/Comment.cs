using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.Entities
{
    class Comment : Content
    {
        public Comment(string id, string body, User author) : base(id, body, author)
        {
        }
    }
}
