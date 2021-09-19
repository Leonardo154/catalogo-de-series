namespace Catalogo_series.Application.Model
{
    public class Serie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public bool Excluded { get; set; }

        public Serie(int id, string name, int year, string description, string genre, bool excluded)
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
            this.Description = description;
            this.Genre = genre;
            this.Excluded = excluded;
        }
    }
}
