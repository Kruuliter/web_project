using MySql.Data.MySqlClient;

namespace CardGame.Domain
{
    public class CardGameConnectDb
    {
        private readonly string _connectionString;
        private MySqlConnection _connection;

        public CardGameConnectDb(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new MySqlConnection(_connectionString);
                _connection.Open();
            }
            return _connection;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool disposing)
        {
            if (!disposing)
                return;

            if (_connection == null)
                return;

            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }



        ~CardGameConnectDb()
        {
            Dispose();
        }
    }
}