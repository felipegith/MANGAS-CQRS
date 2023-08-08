using MYMANGAS.DOMAIN.Entities;

namespace MYMANGAS.APPLICATION.Models
{
    public class MangaViewModel 
    {
        public Guid Id { get; set; }
        public string? User { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Rating { get; set; }
        public bool? Read { get; set; }
    }
}
