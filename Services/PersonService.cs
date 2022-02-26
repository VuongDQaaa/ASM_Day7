using ASM_Day7.Interfaces;
using ASM_Day7.Models;
using ASM_Day7.Data;

namespace ASM_Day7.Services
{
    public class PersonService : IPersonService
    {
        public void AddPerson(PersonModel person)
        {
            var maxId = PeopleData.People.Max(m => m.Id);
            person.Id = maxId + 1;
            PeopleData.People.Add(person);
        }

        public void DeletePerson(int id)
        {
            var deletePerson = PeopleData.People.FirstOrDefault(m => m.Id == id);
            if (deletePerson != null)
            {
                PeopleData.People.Remove(deletePerson);
            }
        }

        public List<PersonModel> GetAllPeople()
        {
            return PeopleData.People;
        }

        public PersonModel GetPersonDetail(int memberId)
        {
            return PeopleData.People.FirstOrDefault(m => m.Id == memberId);
        }

        public void UpdatePerson(PersonModel member)
        {
            var updatePerson = PeopleData.People.FirstOrDefault(m => m.Id == member.Id);
            if (updatePerson != null)
            {
                updatePerson.FirstName = member.FirstName;
                updatePerson.LastName = member.LastName;
                updatePerson.Gender = member.Gender;
                updatePerson.DateOfBirth = member.DateOfBirth;
                updatePerson.PhoneNumber = member.PhoneNumber;
                updatePerson.BirthPlace = member.BirthPlace;
                updatePerson.IsGraduated = member.IsGraduated;
            }
        }
    }
}