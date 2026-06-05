using RestWithASPNET10Course.Model;

namespace RestWithASPNET10Course.Repositories
{
    public interface IBookRepository
    {
        Book Create(Book book);

        Book FindById(long id);

        List<Book> FindAll();

        Book Update(Book book);

        void Delete(long id);
    }
}