using noxORM.src.core.builder.interfaces;
using noxORM.src.core.definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.builder
{
    /// <summary>
    /// This class is used to generate SQL queries from Nox Models.
    /// </summary>
    public class Generator : IGenerator
    {
        #region Fields

        #endregion

        #region Constructor

        /// <summary>
        /// Default construcot of Generator class.
        /// </summary>
        public Generator()
        {

        }

        #endregion

        public string Insert(Model model)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO " + model.tableName + " ( ");
            int countProperties = model.columnsProperties.Count();
            int i = 1;
            foreach(ColumnField field in model.columnsProperties.Values)
            {
                query.Append(field.columnName);
                if (i < countProperties)
                {
                    query.Append(", ");
                }
                i++;
            }
            query.Append(" ) VALUES ( {0} );");
            return (query.ToString());

            throw new NotImplementedException();
        }

        public string Select(Model model)
        {
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT ");

            int countProperties = model.columnsProperties.Count();
            int i = 1;
            foreach(ColumnField field in model.columnsProperties.Values)
            {
                query.Append(field.columnName);
                if( i < countProperties)
                {
                    query.Append(", ");
                }
                i++;
            }
            query.Append(" FROM " + model.tableName + ";");
            return (query.ToString());
        }

        public string Update(Model model)
        {
            StringBuilder query = new StringBuilder();
            query.Append("UPDATE " + model.tableName + " SET ");

            int countProperties = model.columnsProperties.Count();
            int i = 0;

            foreach(ColumnField field in model.columnsProperties.Values)
            {
                query.Append(field.columnName + " = '{" + i + "}'");
                if(i < countProperties - 1)
                {
                    query.Append(", ");
                }
                i++;
            }
            query.Append(" WHERE {" + i + "}");
            return (query.ToString());
        }

        public string Delete(Model model)
        {
            StringBuilder query = new StringBuilder();
            query.Append("DELETE FROM " + model.tableName + "WHERE {0};");
            return (query.ToString());
        }
    }
}
