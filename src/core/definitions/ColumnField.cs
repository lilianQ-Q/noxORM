using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace noxORM.src.core.definitions
{
    /// <summary>
    /// This class combines column & field.
    /// </summary>
    class ColumnField
    {
        #region Fields

        /// <summary>
        /// Program propertie name
        /// </summary>
        public string propertieName { get; set; }
        /// <summary>
        /// Database column name
        /// </summary>
        public string columnName { get; set; }
        /// <summary>
        /// Database column type
        /// </summary>
        public DbType columnType { get; set; }
        /// <summary>
        /// Database column value length
        /// </summary>
        public string length { get; set; }
        /// <summary>
        /// Is this column nullable ?
        /// </summary>
        public bool nullable { get; set; }
        /// <summary>
        /// Comment of the column
        /// </summary>
        public string comment { get; set; }

        //todo A TESTER

        public string isPrimary { get; set; }
        public string isForeign { get; set; }
        public string foreignPropertieName { get; set; }
        public string foreignTableName { get; set; }

        #endregion
    }
}
