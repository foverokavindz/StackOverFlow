namespace StackOverFlow.Entities
{
    class User
    {
        private string id;
        private string name;
        private int reputation;

        public User(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.reputation = 0;
        }

        public void updateReputation(int points)
        {
            this.reputation += points;
        }

        public string getName()
        {
            return this.name;
        }

        public int getReputation()
        {
            return this.reputation;
        }

        public string getId()
        {
            return this.id;
        }
    }
}
