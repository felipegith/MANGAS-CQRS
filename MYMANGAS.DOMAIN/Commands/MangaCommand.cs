namespace MYMANGAS.DOMAIN.Commands
{
    public abstract class MangaCommand
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public int Rating { get; private set; }
        public bool Read { get; private set; }
    }
}
