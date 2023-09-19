namespace DataAccessLibrary
{
    public interface IPeopleData
    {
        Task<List<PersonModal>> GetPeople();
        Task InsertPerson(PersonModal person);
        Task CheckPerson(PersonModal person);
    }
}