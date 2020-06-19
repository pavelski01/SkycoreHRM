using System.Data;
using System.IO;

namespace AdapterDemo.Model
{
    public class DataRenderer
    {
        private readonly IDbDataAdapter _dataAdapter;

        public DataRenderer(IDbDataAdapter dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }
        public void Render(TextWriter writer)
        {
            var myDataSet = new DataSet();
            _dataAdapter.Fill(myDataSet);
            foreach (DataTable table in myDataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                   writer.Write(row[1]);
                   writer.WriteLine();
                }
            }
        }
    }
}