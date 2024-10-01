namespace Bank
{

    class Customer
    {
        public string Name { get; private set; }
        private string password;

        public Customer(string name, string password)
        {
            Name = name;
            this.password = password;
        }
    }


}