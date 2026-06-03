using RestWithASPNET10Course.Model;
using RestWithASPNET10Course.Services;
using RestWithASPNET10Course.Model;
using Microsoft.EntityFrameworkCore;
using RestWithASPNET10Course.Model.Context;
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

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }
        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
        public void Delete(long id)
        {
           _repository.Delete(id);
        }
    }
}