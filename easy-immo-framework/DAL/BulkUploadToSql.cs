using easy_immo_framework.Helper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace easy_immo_framework.DAL
{
    public class BulkUploadToSql
    {
        private int _commitBatchSize;
        private string _connection;

        public BulkUploadToSql(string connection)
        {
            _commitBatchSize = 1000;
            _connection = connection;
        }

        public void Insert<T>(IList<T> datas, string tableName) where T : class, new()
        {
            int numberOfInsertions = (datas.Count / _commitBatchSize) + (datas.Count % _commitBatchSize == 0 ? 0 : 1);
            for (int i = 0; i < numberOfInsertions; i++)
            {
                DataTable dt = datas.Skip(i * _commitBatchSize).Take(_commitBatchSize).ToDataTable();
                BulkInsert(dt, tableName);
            }
        }

        public void BulkInsert(DataTable dt, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                // make sure to enable triggers
                // more on triggers in next post
                SqlBulkCopy bulkCopy =
                    new SqlBulkCopy
                    (
                    connection,
                    SqlBulkCopyOptions.TableLock |
                    SqlBulkCopyOptions.FireTriggers |
                    SqlBulkCopyOptions.UseInternalTransaction,
                    null
                    );
                bulkCopy.BulkCopyTimeout = 0;
                bulkCopy.BatchSize = _commitBatchSize;

                // set the destination table name
                bulkCopy.DestinationTableName = tableName;
                connection.Open();

                // write the data in the "dataTable"
                bulkCopy.WriteToServer(dt);
                connection.Close();
            }
        }
    }
}