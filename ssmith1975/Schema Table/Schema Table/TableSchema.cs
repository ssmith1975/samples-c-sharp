using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Simple_SQL
{

    /*

        SqlDataReader.GetSchemaTable()

        ColumnName			String
        ColumnOrdinal			int
        ColumnSize			int
        NumericPrecision		short
        NumericScale			short
        IsUnique			Boolean
        IsKey				Boolean
        BaseServerName			String
        BaseCatalogName			String
        BaseColumnName			String
        BaseSchemaName			String
        BaseTableName			String
        DataType			Type
        AllowDBNull			Boolean
        ProviderType			int
        IsAliased			Boolean
        IsExpression			Boolean
        IsIdentity			Boolean
        IsAutoIncrement			Boolean
        IsRowVersion			Boolean
        IsHidden			Boolean
        IsLong				Boolean
        IsReadOnly			Boolean
        ProviderSpecificDataType	Type
        DataTypeName			String
        XmlSchemaCollectionDatabase	String
        XmlSchemaCollectionOwningSchema	    String
        XmlSchemaCollectionName		String
        UdtAssemblyQulifiedName		String
        NonVersionedProviderType	int
        IsColumnSet			Boolean

    */
    class TableSchema
    {
       

        public List<DataRow> List = new List<DataRow>();



        public TableSchema(DataTable schemaTable)
        {

                PopulateList(schemaTable);
        }

        protected void PopulateList(DataTable dt)
        {
            // Iterate through schema table
            // Each row represents a field in a result set
            foreach (DataRow row in dt.Rows)
            {

                // Add field metadata to list
                List.Add(row);

            }
        }



        // Dispaly meta data for each field
        public  void ShowSchemaList()
        {
            foreach (DataRow field in List)
            {

                Console.WriteLine(" FIELD: {0}  ({1} => {2})", field["BaseColumnName"], field["DataTypeName"], field["DataType"]);
                Console.WriteLine();
            }



        }



    }
}
