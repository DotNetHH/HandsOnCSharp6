using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnCSharp6.Helper;

namespace HandsOnCSharp6.Await
{
    public class CatchAwait
    {
        private readonly Logger _logger = new Logger();

        public async Task DoAnotherCoolThing()
        {
            var sqlConnection = new SqlConnection();
            var sqlCommand = new SqlCommand();
            try
            {
                await sqlConnection.OpenAsync();
                sqlCommand.Connection = sqlConnection;
                await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                await _logger.LogAsync(ex);
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                    await sqlConnection.CloseAsync();
            }
        }
    }
}
