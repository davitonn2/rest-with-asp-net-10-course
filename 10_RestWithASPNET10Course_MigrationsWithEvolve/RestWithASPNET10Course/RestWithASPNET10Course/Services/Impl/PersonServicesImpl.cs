using RestWithASPNET10Course.Model;
using RestWithASPNET10Course.Repositories;

namespace RestWithASPNET10Course.Services.Impl
{
    public class PersonServicesImpl : IPersonServices
    {

        private IPersonRepository _repository;

        public PersonServicesImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Book Create(Book person)
        {
            return _repository.Create(person);
        }

        public Book Update(Book person)
        {
            return _repository.Update(person);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}