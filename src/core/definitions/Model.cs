using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.definitions
{
    public class Model
    {
        #region Fields

        public string tableName { get; set; }
        public Dictionary<string, ColumnField> columnsProperties { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor of the Model class.
        /// </summary>
        /// <param name="tableName">Name of the database table</param>
        /// <param name="columnProperties">Key value array which contains name of columns and their properties</param>
        public Model(string tableName, Dictionary<string, ColumnField> columnProperties)
        {
            this.tableName = tableName;
            this.columnsProperties = columnProperties;
        }

        #endregion
    }
}
