using noxORM.src.core.definitions;
using noxORM.src.core.attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace noxORM.src.core.converter
{
    /// <summary>
    /// This class is used to convert a Class into a classic model.
    /// </summary>
    public class ModelConverter
    {
        #region Fields



        #endregion

        #region Singleton 

        private static ModelConverter _instance;

        /// <summary>
        /// Singleton of ModelConverter class.
        /// </summary>
        public static ModelConverter Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ModelConverter();
                }
                return (_instance);
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor of ModelConverter.
        /// </summary>
        private ModelConverter()
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
            return (this.ConvertToModel(typeof(T)));
        }

        /// <summary>
        /// Method that allow the user to convert a type of object into a new Model.
        /// </summary>
        /// <param name="type">Type of the object. Use : typeof(Object)</param>
        /// <returns></returns>
        public Model ConvertToModel(Type type)
        {
            string tableName = "";
            Dictionary<string, ColumnField> allColumns = this.GetAllColumn(type);
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

        /// <summary>
        /// Method that allow the user to get for each field in a class his Column equivalent. 
        /// </summary>
        /// <param name="type">Represent the type of the class you want to use </param>
        /// <returns></returns>
        private Dictionary<string, ColumnField> GetAllColumn(Type type)
        {
            PropertyInfo[] properties = type.GetProperties();
            Dictionary<string, ColumnField> result = new Dictionary<string, ColumnField>();
            foreach(PropertyInfo property in properties)
            {
                result.Add(property.Name, this.GetColumnByProperty(property));

            }
            return result;
        }

        /// <summary>
        /// Method that allow the user to get for a property his Column equivalent.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private ColumnField GetColumnByProperty(PropertyInfo property)
        {
            object[] attributes = property.GetCustomAttributes(true);
            ColumnField newColumnField = new ColumnField();
            ColumnName columnName = new ColumnName();
            ColumnType columnType = new ColumnType();
            foreach(object attribute in attributes)
            {
                if (attribute.GetType().Equals(typeof(ColumnName))){
                    columnName = attribute as ColumnName;
                }
                if (attribute.GetType().Equals(typeof(ColumnType)))
                {
                    columnType = attribute as ColumnType;
                }
                //todo clé primaire ?? clé étrangère ??
            }
            newColumnField.SetColumnName(columnName, property);
            newColumnField.SetColumnType(columnType, property);
            return (newColumnField);
        }

        #endregion
    }
}
