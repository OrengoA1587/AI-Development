﻿namespace DataAccessLibrary
{
    public interface ISqlDataAccess
    {
        string connectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
        Task CheckPerson<T>(string sql, T parameters);
    }
}