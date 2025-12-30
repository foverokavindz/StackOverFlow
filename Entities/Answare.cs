using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.Entities
{
    class Answare : Post
    {
        private bool isAccepted;

        public void setIsAccepted(bool accepted)
        {
            this.isAccepted = accepted;
        }
    }
}
