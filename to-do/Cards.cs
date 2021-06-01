namespace to_do
{
    public class CardData
    {
        private string title;
        private string description;
        private int employee;
        private int size;
        private string status;

        public CardData(string title, string description, int employee, int size, string status)
        {
            this.Title = title;
            this.Description = description;
            this.Employee = employee;
            this.Size = size;
            this.Status = status;
        }

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public int Employee { get => employee; set => employee = value; }
        public int Size { get => size; set => size = value; }
        public string Status { get => status; set => status = value; }
    }
}