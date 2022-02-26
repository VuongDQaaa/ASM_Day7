using ASM_Day7.Models;
using ASM_Day7.Enum;

namespace ASM_Day7.Data
{
    public class PeopleData
    {
        public static List<PersonModel> People = new List<PersonModel>
        {
            new PersonModel(){
                Id = 1,
                FirstName = "Dao",
                LastName = "Vuong1",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(2000,3,29),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0335878777",
                IsGraduated = false,
            },
            new PersonModel(){
                Id = 2,
                FirstName = "Dao",
                LastName = "Vuong2",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(2001,3,29),
                BirthPlace = "Lao Cai",
                PhoneNumber = "0335878777",
                IsGraduated = false
            },
            new PersonModel(){
                Id = 3,
                FirstName = "Dao",
                LastName = "Vuong2",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(2001,3,29),
                BirthPlace = "Lao Cai",
                PhoneNumber = "0335878777",
                IsGraduated = true
            },
            new PersonModel(){
                Id = 4,
                FirstName = "Dao",
                LastName = "Vuong4",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(2001,3,29),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0335878777",
                IsGraduated = true
            },
        };
    }
}