namespace People_MVC_Project.Models.Repos
{
    public class InMemoryRepo : IPeoplesRepo
    {
        static int idCounter = 0;
        static List<People> peoplesList = new List<People>();

        public People Create(People people)
        {
            people.Id = ++idCounter;
            peoplesList.Add(people);
            return people;
        }

        public List<People> GettAll()
        {
            return peoplesList;
        }

        public List<People> GetByCity(string citys)
        {
            List<People> peopleCitys = new List<People>();
            foreach (People aPeople in peoplesList)
            {
                if (aPeople.City == citys)
                {
                    peopleCitys.Add(aPeople);
                }
            }
            return peopleCitys;
        }

        public People GetById(int id)
        {
            People people = null;
            foreach (People aPeople in peoplesList)
            {
                if (aPeople.Id == id)
                {
                    people = aPeople;
                    break;
                }
            }
            return people;
        }

        public void Update(People people)
        {
            People orginalPeople = GetById(people.Id);
            if (orginalPeople != null)
            {
                orginalPeople.PersonName = people.PersonName;
                orginalPeople.Phone = people.Phone;
                orginalPeople.City = people.City;
            }
        }

        public void Delete(People people)
        {
            if (people != null) { peoplesList.Remove(people); }
        }
    }
}
