using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.exceptions
{
    public class DatabaseTypeError : NoxORMException
    {
        #region Fields

        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor of DatabaseTypeError class. Use it when you are unable to find a .net framework type equivalent in sql server.
        /// </summary>
        /// <param name="message"></param>
        public DatabaseTypeError(string message) : base("DatabaseTypeError", message)
        {

        }

        #endregion
    }
}
