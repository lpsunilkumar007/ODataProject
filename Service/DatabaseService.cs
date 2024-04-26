using ODataProject.Data;

namespace ODataProject.Service
{
    public class DatabaseService
    {
        private readonly MyAppDbContext _context;

        public DatabaseService(MyAppDbContext context)
        {
            _context = context;
        }

        public List<string> GetAllTablesAndViews()
        {
            var result = new List<string>();

            //using var connection = _context.Database.GetDbConnection();
            //connection.Open();

            //var command = connection.CreateCommand();
            //command.CommandText = "SHOW FULL TABLES WHERE Table_type = 'BASE TABLE' OR Table_type = 'VIEW';";

            //using var reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    result.Add(reader.GetString(0));
            //}

            return result;
        }
    }

}
