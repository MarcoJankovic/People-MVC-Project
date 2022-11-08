using People_MVC_Project.Models.Repos;
using People_MVC_Project.Models.ViewModels;

namespace People_MVC_Project.Models.Services

{
    public class PeopleService : IPeopleService
    {
        IPeoplesRepo _peoplesRepo;

        public PeopleService(IPeoplesRepo peopleRepo)
        {
            _peoplesRepo = peopleRepo;
        }

        public People Create(CreatePeopleViewModel createPeople)
        {
            if (string.IsNullOrWhiteSpace(createPeople.PersonName) || string.IsNullOrWhiteSpace(createPeople.Phone) || string.IsNullOrWhiteSpace(createPeople.City))
            {
                throw new ArgumentException("PersonName, Phone and City. Not allowed whitespace");
            }
            People people = new People()
            {
                PersonName = createPeople.PersonName,
                Phone = createPeople.Phone,
                City = createPeople.City
            };
            people = _peoplesRepo.Create(people);
            return people;
        }

        public People FindById(int id)
        {
            return _peoplesRepo.GetById(id);
        }
        public List<People> GetAll()
        {
            return _peoplesRepo.GettAll();
        }

        public List<People> FindByCity(string city)
        {
            return _peoplesRepo.GetByCity(city);
        }

        public void Edit(int id, CreatePeopleViewModel editPeople)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
