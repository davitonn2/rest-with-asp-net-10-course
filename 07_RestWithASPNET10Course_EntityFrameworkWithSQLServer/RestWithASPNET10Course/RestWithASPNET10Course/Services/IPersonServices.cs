using RestWithASPNET10Course.Model;
using RestWithASPNET10Course.Model;

namespace RestWithASPNET10Course.Services
{
    public interface IPersonServices
    {

        Person Create(Person person);

        Person FindById(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);
    }
}