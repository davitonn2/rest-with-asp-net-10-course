using RestWithASPNET10Course.Model;
using RestWithASPNET10Course.Services;
using RestWithASPNET10Course.Model;
using Microsoft.EntityFrameworkCore;
using RestWithASPNET10Course.Model.Context;

namespace RestWithASPNET10Course.Services.Impl
{
    public class PersonServicesImpl : IPersonServices
    {

        private MSSQLCcontext _context;

        public PersonServicesImpl(MSSQLCcontext context)
        {
            _context = context;
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }
        public Person FindById(long id)
        {
            return _context.Persons.Find(id);
        }

        public Person Create(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
            return person;
        }

        public Person Update(Person person)
        {
            var existingPerson = _context.Persons.Find(person.Id);
            if (existingPerson == null) return null;
            
            _context.Entry(existingPerson).CurrentValues.SetValues(person);
            _context.SaveChanges();

            return person;
        }
        public void Delete(long id)
        {
            var existingPerson = _context.Persons.Find(id);
            if (existingPerson == null) return;

            _context.Remove(existingPerson);
            _context.SaveChanges();
        }
    }
}