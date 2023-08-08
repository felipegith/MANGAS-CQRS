namespace MYMANGAS.DOMAIN.Entities
{
    public class Manga : Entity
    {
        public Manga()
        {

        }
        public Manga(string user, string name, string description, int rating, bool read)
        {
            Name = name;
            Description = description;
            Rating = rating;
            Read = read;
            User = user;
        }

        public string User { get; set; }
        public string Name { get; private set; } 
        public string Description { get; private set; }
        public int Rating { get; private set; }
        public bool Read { get; private set; }

        public void UpdateMangaName(string name)
        {
            Name = name;
        }

        public void UpdateReadManga(bool read)
        {
            Read = read;
        }
    }
}
