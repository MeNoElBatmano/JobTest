namespace JobTest.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public Product()
        {

        }

    }
}
