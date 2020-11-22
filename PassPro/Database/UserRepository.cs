using System;
using System.Collections.Generic;
// team
using BluewayWinForms.UI.Database;

namespace PassPro.Database
{
    public sealed class UserRepository
    {
        private static UserRepository repository = null;
        public static UserRepository Service
        {
            get
            {
                if (repository == null)
                {
                    repository = new UserRepository();
                }
                return repository;
            }
        }

        private UserRepository()
        {
        }

        // write codes below
        MongoCRUD db = new MongoCRUD();

        // define user table name
        string userTableName = "user";

        public void InsertUser(User user)
        {
            db.InsertRecord(userTableName, user);
        }

        public List<User> LoadUsers()
        {
            return db.LoadRecords<User>(userTableName);
        }

        public User LoadUserById(Guid id)
        {
            return db.LoadRecordById<User>(userTableName, id);
        }

        public void DeleteUserById(Guid id)
        {
            db.DeleteRecordById<User>(userTableName, id);
        }

        public User Login(string name, string password)
        {
            return db.Login<User>(userTableName, name, password);
        }
    }
}