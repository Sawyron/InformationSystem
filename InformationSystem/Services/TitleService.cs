using InformationSystem.Models;
using System.Data;
using System.Data.Common;

namespace InformationSystem.Services
{
    public class TitleService : ITitleService
    {
        public IDbConnection? DbConnection { get; set; }

        public IEnumerable<Title> GetAll()
        {
            List<Title> titles = new List<Title>();
            if (DbConnection != null)
            {
                try
                {
                    IDbCommand command = DbConnection.CreateCommand();
                    command.CommandText = "SELECT * FROM titles";
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            titles.Add(new Title(
                                (int)reader["id"],
                                (string)reader["name"],
                                (DateTime)reader["release"]
                                ));
                        }
                    }
                }
                catch (DbException)
                {

                }
            }
            return titles;
        }
    }
}
