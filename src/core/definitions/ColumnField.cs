using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using noxORM.src.core.attributes;
using System.Reflection;
using noxORM.src.core.converter;
using noxORM.src.core.mapper;

namespace noxORM.src.core.definitions
{
    /// <summary>
    /// This class combines column & field.
    /// </summary>
    public class ColumnField
    {
        #region Fields

        /// <summary>
        /// Program propertie name
        /// </summary>
        public string propertieName { get; set; }
        /// <summary>
        /// Database column name
        /// </summary>
        public string columnName { get; private set; }
        /// <summary>
        /// Database column type
        /// </summary>
        public DbType columnType { get; private set; }
        /// <summary>
        /// Database column value length
        /// </summary>
        public int length { get; private set; }
        /// <summary>
        /// Is this column nullable ?
        /// </summary>
        public bool nullable { get; private set; }
        /// <summary>
        /// Comment of the column
        /// </summary>
        public string comment { get; set; }

        //todo A TESTER

        public bool isPrimary { get; set; }
        public bool isForeign { get; set; }
        public string foreignPropertieName { get; set; }
        public string foreignTableName { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor of the ColumnField class
        /// </summary>
        public ColumnField()
        {
            this.propertieName = "none";
            this.columnName = "none";
            this.columnType = DbType.String;
            this.length = 255;
            this.nullable = true;
            this.comment = "An error has occured";
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method that allow the user to set the name of the column.
        /// </summary>
        /// <param name="columnName">Custom attribute that represent the column's name</param>
        /// <param name="property">Name of the original class property</param>
        public void SetColumnName(ColumnName columnName, PropertyInfo property)
        {
            this.columnName = columnName.columnName == "noname" ? property.Name : columnName.columnName;
            this.propertieName = property.Name;
        }

        /// <summary>
        /// Method that allow the user to set column's type properties. (type, length, nullable, comment)
        /// </summary>
        /// <param name="columnType">Represent the type of the column</param>
        /// <param name="property">Name of the original class property</param>
        public void SetColumnType(ColumnType columnType, PropertyInfo property)
        {

            if(!columnType.isDefaultObject)
            {
                this.columnType = columnType.databaseType;
                this.length = columnType.length;
                this.nullable = columnType.nullable;
                this.comment = columnType.comment;
            }
            else
            {
                this.columnType = SqlData.Instance.GetDbTypeByType(property.PropertyType, property.Name);
            }
        }

        #endregion
    }
}
