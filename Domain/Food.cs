namespace Domain
{
    public class Food
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public static int count = 1;
        public string Category { get; set; }
        public double Price { get; set; }
        public Boolean isDeleted { get; set; }
        public Food(string Name, string Category, double Price)
        {
            this.Name = Name;
            this.Id = count++;
            this.Category = Category;
            this.Price = Price;
            this.isDeleted = false;
        }
        public Food(string Name, string Category, double Price, Boolean isUpdated, Boolean isDeleted)
        {
            this.Name = Name;
            this.Id = count++;
            this.Category = Category;
            this.Price = Price;
            this.isDeleted = isDeleted;
        }
    }
}
