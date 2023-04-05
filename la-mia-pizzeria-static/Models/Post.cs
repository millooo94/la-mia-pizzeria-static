namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public Pizza(string imageSrc, string title, string description, float price)
        {
            ImageSrc = imageSrc;
            Name = title;
            Description = description;
            Price = price;
        }

        public string ImageSrc { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
