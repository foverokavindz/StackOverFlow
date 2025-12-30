namespace StackOverFlow.Entities
{
    class Question
    {
        private string title;
        private List<Tag> tag;
        private List<Answare> answares;
        private Answare acceptedAnsware;

        public void AddAnsware(Answare answare)
        {
            answares.Add(answare);
        }

        public void SetAcceptedAnsware(Answare answare)
        {
            this.acceptedAnsware = answare;
        }
    }
}
