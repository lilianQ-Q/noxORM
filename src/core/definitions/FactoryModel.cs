using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.definitions
{
    public class FactoryModel
    {
        #region Singleton
        
        private static FactoryModel _instance;

        /// <summary>
        /// Singleton of FactoryModel Class
        /// </summary>
        public static FactoryModel Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new FactoryModel();
                }
                return (_instance);
            }
        }

        #endregion

        #region Fields

        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor of the FactoryClass
        /// </summary>
        private FactoryModel()
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Main method of the model factory class. It Allows you to create a new noxModel
        /// </summary>
        /// <param name="tableName">Name of the table that you want to create</param>
        /// <param name="columns">Dictionnary of column name and columnField</param>
        /// <returns></returns>
        public Model create(string tableName, Dictionary<string, ColumnField> columns)
        {
            return (new Model(tableName, columns));
        }

        #endregion
    }
}
