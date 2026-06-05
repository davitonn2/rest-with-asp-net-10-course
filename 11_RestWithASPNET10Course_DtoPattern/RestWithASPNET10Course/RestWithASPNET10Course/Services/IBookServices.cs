using RestWithASPNET10Course.Data.DTO;
using RestWithASPNET10Course.Model;

namespace RestWithASPNET10Course.Services
{
    public interface IBookServices
    {

        BookDTO Create(BookDTO book);

        BookDTO FindById(long id);

        List<BookDTO> FindAll();

        BookDTO Update(BookDTO book);

        void Delete(long id);
    }
}
