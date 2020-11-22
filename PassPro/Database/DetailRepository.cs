using System;
using System.Collections.Generic;
// team
using PassPro1;
using BluewayWinForms.UI.Database;

namespace PassPro.Database
{
    public sealed class DetailRepository
    {
        private static DetailRepository repository = null;
        public static DetailRepository Service
        {
            get
            {
                if (repository == null)
                {
                    repository = new DetailRepository();
                }
                return repository;
            }
        }

        private DetailRepository()
        {
        }

        // write codes below
        MongoCRUD db = new MongoCRUD();

        // define Detail table name
        string DetailTableName = "detail";

        public void InsertDetail(Detail Detail)
        {
            db.InsertRecord(DetailTableName, Detail);
        }

        public List<Detail> LoadDetails()
        {
            return db.LoadRecords<Detail>(DetailTableName);
        }

        public Detail LoadDetailById(Guid id)
        {
            return db.LoadRecordById<Detail>(DetailTableName, id);
        }

        public void DeleteDetailById(Guid id)
        {
            db.DeleteRecordById<Detail>(DetailTableName, id);
        }
    }
}
