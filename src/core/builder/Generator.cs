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
            throw new NotImplementedException();
        }

        public string Select(Model model)
        {
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT ");

            int count = 1;
            foreach(ColumnField field in model.columnsProperties.Values)
            {
                query.Append(field.columnName + ", ");
            }
            return (query.ToString());
        }
    }
}
