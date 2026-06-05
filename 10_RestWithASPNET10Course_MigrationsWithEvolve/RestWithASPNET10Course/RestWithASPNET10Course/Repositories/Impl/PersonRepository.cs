using RestWithASPNET10Course.Model;
using RestWithASPNET10Course.Model.Context;

namespace RestWithASPNET10Course.Repositories.Impl
{
    public class PersonRepository : IPersonRepository
    {

        private MSSQLContext _context;

        public PersonRepository(MSSQLContext context)
        {
            _context = context;
        }

        public List<Book> FindAll()
        {
            return _context.Persons.ToList();
        }
        public Book FindById(long id)
        {
            return _context.Persons.Find(id);
        }

        public Book Create(Book person)
        {
            _context.Add(person);
            _context.SaveChanges();
            return person;
        }

        public Book Update(Book person)
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

