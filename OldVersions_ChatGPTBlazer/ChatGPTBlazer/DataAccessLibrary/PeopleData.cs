using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _dataAccess;
        public PeopleData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<List<PersonModal>> GetPeople()
        {
            string sql = "select * from dbo.PeopleTest";
            return _dataAccess.LoadData<PersonModal, dynamic>(sql, new { });
        }
        public Task InsertPerson(PersonModal person)
        {
            string sql = @"insert into dbo.People (FirstName, LastName, EmailAddress) values (@FirstName, @LastName, @EmailAddress);";
            return _dataAccess.SaveData(sql, person);
        }
        public Task CheckPerson(PersonModal person)
        {
            string sql = @"SELECT * FROM dbo.People WHERE Username = @Username AND Password = @Password;";
            return _dataAccess.CheckPerson(sql, person);
        }

         
    }
}
