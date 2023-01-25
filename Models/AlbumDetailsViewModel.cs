namespace MusicStore.Models
{
    public class AlbumDetailsViewModel
    {
        public string Titre { get; init; }
        public string CoverUrl { get; init; }
        public IEnumerable<PisteViewModel> Pistes { get; init; }
    }
}
