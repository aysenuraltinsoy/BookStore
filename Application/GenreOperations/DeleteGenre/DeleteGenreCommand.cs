using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.DeleteGenre
{
    public class DeleteGenreCommand
    {
        public int GenreID { get; set; }

        private readonly IBookStoreDbContext _context;

        public DeleteGenreCommand(IBookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.Id == GenreID);
            if (genre is null)
            {
                throw new InvalidOperationException("Kitap Türü Bulunamadı");
            }
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }
    }

}