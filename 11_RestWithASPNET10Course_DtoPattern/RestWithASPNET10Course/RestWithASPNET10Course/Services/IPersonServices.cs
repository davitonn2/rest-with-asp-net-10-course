using RestWithASPNET10Course.Data.DTO;

namespace RestWithASPNET10Course.Services
{
    public interface IPersonServices
    {

        PersonDTO Create(PersonDTO person);

        PersonDTO FindById(long id);

        List<PersonDTO> FindAll();

        PersonDTO Update(PersonDTO person);

        void Delete(long id);
    }
}
