namespace Silas.Models
{
    public class Apply
    {
        public long IdUser { get; set; }
        public string Nie { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gendre { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public long Phone { get; set; }
        public long EmerPhone { get; set; }
        public string Nationality { get; set; }
        public long Car { get; set; }
        public string Address { get; set; }
        public long? Year { get; set; }
        public DateTimeOffset? RegisterDate { get; set; }
        public long? Cv { get; set; }
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requiriments { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Location { get; set; }
        public long IdCompany { get; set; }
        public long IdOffer { get; set; }
        public string Presentation { get; set; }
        public long Status { get; set; }
    }
}
