namespace _00016003_api_back_end.Models
{
    public class Newspaper
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty; // Name of the newspaper
        public string Publisher { get; set; } = string.Empty; // Name of the publisher
        public DateTime PublicationDate { get; set; } // Date of publication
    }
}
