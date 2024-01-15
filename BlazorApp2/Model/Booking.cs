namespace BlazorWeb.Model
{
    public class Booking
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public string image { get; set; } = string.Empty;
    }
}
