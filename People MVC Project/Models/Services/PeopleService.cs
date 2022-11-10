using Microsoft.AspNetCore.Identity;
using People_MVC_Project.Models.Repos;
using People_MVC_Project.Models.ViewModels;
using System;

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
            var nullOrWhite = string.IsNullOrWhiteSpace;

            if (nullOrWhite(createPeople.Name) || nullOrWhite(createPeople.Age.ToString()) || nullOrWhite(createPeople.City))
            {
                throw new ArgumentException("Name is not allowed whitespace");
            }
            People people = new People()
            {
                Name = createPeople.Name,
                Age = createPeople.Age,
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
            foreach (People person in InMemoryRepo.peoplesList)
                if (id == person.Id)
                {
                    InMemoryRepo.peoplesList.Remove(person);
                    break;
                }
        }

        public People? LastAdded()
        {
            List<People> people = _peoplesRepo.GettAll();
            if (people.Count < 1)
            {
                return null;
            }
            return people.Last();
        }
    }
}
