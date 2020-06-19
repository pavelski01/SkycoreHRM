using System;
using System.Data;

namespace AdapterDemo.Test
{
    public class StubDbAdapter : IDbDataAdapter
    {
        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public int Fill(DataSet dataSet)
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("Id", typeof (int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof (string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof (string)));

            var myRow = myDataTable.NewRow();
            myRow[0] = 1;
            myRow[1] = "IT";
            myRow[2] = "";
            myDataTable.Rows.Add(myRow);

            myRow = myDataTable.NewRow();
            myRow[0] = 2;
            myRow[1] = "QA";
            myRow[2] = "";
            myDataTable.Rows.Add(myRow);

            myRow = myDataTable.NewRow();
            myRow[0] = 3;
            myRow[1] = "Management";
            myRow[2] = "";
            myDataTable.Rows.Add(myRow);

            myRow = myDataTable.NewRow();
            myRow[0] = 4;
            myRow[1] = "Financial";
            myRow[2] = "";
            myDataTable.Rows.Add(myRow);

            myRow = myDataTable.NewRow();
            myRow[0] = 5;
            myRow[1] = "Cleaning";
            myRow[2] = "";
            myDataTable.Rows.Add(myRow);

            myRow = myDataTable.NewRow();
            myRow[0] = 6;
            myRow[1] = "Staff";
            myRow[2] = "";
            myDataTable.Rows.Add(myRow);

            myRow = myDataTable.NewRow();
            myRow[0] = 7;
            myRow[1] = "Clerk";
            myRow[2] = "";
            myDataTable.Rows.Add(myRow);

            myRow = myDataTable.NewRow();
            myRow[0] = 8;
            myRow[1] = "Research";
            myRow[2] = "";
            myDataTable.Rows.Add(myRow);

            dataSet.Tables.Add(myDataTable);
            dataSet.AcceptChanges();

            return 1;
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        }

        public MissingMappingAction MissingMappingAction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public MissingSchemaAction MissingSchemaAction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ITableMappingCollection TableMappings
        {
            get { throw new NotImplementedException(); }
        }

        public IDbCommand SelectCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IDbCommand InsertCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IDbCommand UpdateCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IDbCommand DeleteCommand
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}