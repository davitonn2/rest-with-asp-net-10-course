using RestWithASPNET10Course.Data.Converter.Impl;
using RestWithASPNET10Course.Data.DTO;
using RestWithASPNET10Course.Model;
using RestWithASPNET10Course.Repositories;

namespace RestWithASPNET10Course.Services.Impl
{
    public class PersonServicesImplV1 : IPersonServices
    {

        private IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonServicesImplV1(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public List<PersonDTO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonDTO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonDTO Create(PersonDTO person)
        {
            var entity = _converter.Parse(person);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        public PersonDTO Update(PersonDTO person)
        {
            var entity = _converter.Parse(person);
            entity = _repository.Update(entity);
            return _converter.Parse(entity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
