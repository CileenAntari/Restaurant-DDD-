namespace Contracts
{
    public class FoodDTO
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public static int count = 1;
        public double Price { get; set; }
        public string Category { get; set; }
        public FoodDTO() { }
        public FoodDTO(string Name, string Category, double Price)
        {
            this.Id = count++;
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
        }
    }
}
