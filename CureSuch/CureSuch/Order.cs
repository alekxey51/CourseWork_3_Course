namespace CureSuch
{
    class Order
    {
        public string IdOrder { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string DescryptionShort { get; set; }
        public string DescryptionLong { get; set; }
        public string Price { get; set; }

        public Order(string idOrder, string name, string date, string descryptionShort, string descryptionLong, string price)
        {
            IdOrder = idOrder;
            Name = name;
            Date = date;
            DescryptionShort = descryptionShort;
            DescryptionLong = descryptionLong;
            Price = price;
        }
    }
}
