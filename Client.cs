namespace ObjectBank
{
    internal class Client
    {
        private string _name;
        private int _id;
        private string _profession;

        public string Name { get; set; }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _id = value;
            }
        }

        public string Profession { get; set; }

        public Client(string name, int id, string profession)
        {
            Name = name;
            Id = id;
            Profession = profession;
        }
    }
}