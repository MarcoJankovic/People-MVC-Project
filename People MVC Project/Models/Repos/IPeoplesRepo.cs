using System;
using People_MVC_Project.Models.Repos;


namespace People_MVC_Project.Models.Repos
{
    public interface IPeoplesRepo
    {
        //Crud - Create - Read - Update - Delete

        // C
        People Create(People people);

        // R
        List<People> GettAll();
        List<People> GetByCity(string city);
        People GetById(int id);

        // U
        public void Update(People people)
        {
            People orginalPeople = GetById(people.Id);
            if (orginalPeople != null)
            {
                orginalPeople.Name = people.Name;
                orginalPeople.Age = people.Age;
                orginalPeople.City = people.City;
            }
        }

        // D
        public void Delete(People people)
        {
            foreach (People person in InMemoryRepo.peoplesList)
                if (people.Id == person.Id)
                {
                    InMemoryRepo.peoplesList.Remove(person);
                    break;
                }       
        } 
    }
}
