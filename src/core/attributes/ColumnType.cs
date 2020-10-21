using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.attributes
{
    /// <summary>
    /// This class is used to create custom attributes about database Column type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnType : BaseAttribute
    {
        #region Fields

        private DbType databaseType { get; set; }
        private int length { get; set; }
        private bool nullable { get; set; }
        private string comment { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor of the ColumnType class. Use it for test purposes.
        /// </summary>
        public ColumnType()
        {
            this.databaseType = DbType.String;
            this.length = 255;
            this.nullable = true;
            this.comment = "String test column type.";
        }
        
        /// <summary>
        /// Main constructor of the ColumnType class. It allows you to create a new ColumnType attribute.
        /// </summary>
        /// <param name="databaseType">Represent a database type.</param>
        /// <param name="length">Represent the length of the column's value.</param>
        /// <param name="nullable">Boolean that represent if the column's value can be null or not.</param>
        /// <param name="comment">Want to add a special comment ?</param>
        public ColumnType(DbType databaseType, int length, bool nullable, string comment)
        {
            this.databaseType = databaseType;
            this.length = length;
            this.nullable = nullable;
            this.comment = comment;
        }

        #endregion
    }
}
