using ASM_Day7.Models;

namespace ASM_Day7.Interfaces
{
    public interface IPersonService
    {
        List<PersonModel> GetAllPeople();
        PersonModel GetPersonDetail(int personId);
        void AddPerson(PersonModel person);
        void UpdatePerson(PersonModel person);
        void DeletePerson(int id);
    }
}