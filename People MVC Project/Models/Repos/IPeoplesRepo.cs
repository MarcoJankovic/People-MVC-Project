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
        void Update(People people);

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
