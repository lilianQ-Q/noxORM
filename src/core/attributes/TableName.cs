using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.attributes
{
    /// <summary>
    /// This class is used to create custom attributes about database Table name.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class TableName : BaseAttribute
    {
        #region Fields

        public string tableName { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor of the TableName class. Use it for test purposes.
        /// </summary>
        public TableName()
        {
            this.tableName = "test";
        }

        /// <summary>
        /// Main constructor of the TableName class.
        /// </summary>
        /// <param name="tableName">Represent the name of the table.</param>
        public TableName(string tableName)
        {
            this.tableName = tableName;
        }

        #endregion
    }
}
