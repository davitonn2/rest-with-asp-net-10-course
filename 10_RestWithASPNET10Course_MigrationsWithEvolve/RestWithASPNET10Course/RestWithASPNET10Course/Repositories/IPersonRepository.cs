using RestWithASPNET10Course.Model;

namespace RestWithASPNET10Course.Repositories
{
    public interface IPersonRepository
    {
        Book Create(Book person);

        Book FindById(long id);

        List<Book> FindAll();

        Book Update(Book person);

        void Delete(long id);

    }
}
