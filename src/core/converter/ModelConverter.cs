using noxORM.src.core.definitions;
using noxORM.src.core.attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.converter
{
    /// <summary>
    /// This class is used to convert a Class into a classic model.
    /// </summary>
    public class ModelConverter
    {
        #region Fields



        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor of ModelConverter.
        /// </summary>
        public ModelConverter()
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Method that allow the user to convert a type of object into a new Model.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Model ConvertToModel<T>()
        {
            return (this.convertToModel(typeof(T)));
        }

        /// <summary>
        /// Method that allow the user to convert a type of object into a new Model.
        /// </summary>
        /// <param name="type">Type of the object. Use : typeof(Object)</param>
        /// <returns></returns>
        public Model ConvertToModel(Type type)
        {
            string tableName = "";
            Dictionary<string, ColumnField> allColumns = null;
            return (new Model(tableName, allColumns));
        }

        /// <summary>
        /// Method that allow the user to get the database table name from a class type.
        /// </summary>
        /// <param name="classType">Name of the class you want to get the table name</param>
        /// <returns></returns>
        private string GetTableNameByType(Type classType)
        {
            TableName tableName = GetTableNameAttributeByType(classType);
            return (tableName == null ? classType.Name : tableName.tableName);
            //Can do it in one line but like this it's easier to understand
        }

        /// <summary>
        /// Method that allow the user to get custom attribute of a class.
        /// </summary>
        /// <param name="classType">Type of the class you want to get the custom attribute</param>
        /// <returns></returns>
        private TableName GetTableNameAttributeByType(Type classType)
        {
            return ((TableName)Attribute.GetCustomAttribute(classType, typeof(TableName)));
        }



        #endregion
    }
}
