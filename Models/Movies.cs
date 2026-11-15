namespace Dodoco.Models
{
    internal class Movies
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Movies(int id, string title, string director, DateTime releaseDate)
        {
            Id = id;
            this.Title = title;
            this.Director = director;
            ReleaseDate = releaseDate;
        }

        public string ToLine()
        {
            return $"{Id}|{Title}|{Director}|{ReleaseDate.ToString()}";

        }
        public override string ToString()
        {
            return $"{Id}:{Title}-{Director}, {ReleaseDate.ToString()}";
        }

    }
}
