using People_MVC_Project.Models.ViewModels;

namespace People_MVC_Project.Models.Services
{
    public interface IPeopleService
    {
        People Create(CreatePeopleViewModel createPeople);

        List<People> GetAll();

        List<People> FindByCity(string city);

        People FindById(int id);

        public void Edit(int id, CreatePeopleViewModel editPeople) { 

        }
        public bool Remove(int id);

        People LastAdded();
    }
}
