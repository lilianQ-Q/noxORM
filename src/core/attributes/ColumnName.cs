using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.attributes
{
    /// <summary>
    /// This class is used to create custom attributes about database Column name.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnName : BaseAttribute
    {
        #region Fields

        public string columnName { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor of ColumnName Class. Use it for test purposes. 
        /// </summary>
        public ColumnName()
        {
            this.columnName = "testarea";
        }

        /// <summary>
        /// Main constructor of ColumnName Class. It allows you to create a new ColumnName attribute.
        /// </summary>
        /// <param name="ColumnName">Represent the database Column name.</param>
        public ColumnName(string ColumnName)
        {
            this.columnName = ColumnName;
        }

        #endregion
    }
}
