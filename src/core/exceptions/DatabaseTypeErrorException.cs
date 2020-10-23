using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.exceptions
{
    /// <summary>
    /// This class is used to create new Exceptions about .NET framwork types when the orm didn't find their sql server equivalent.
    /// </summary>
    public class DatabaseTypeErrorException : NoxORMException
    {
        #region Fields

        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor of DatabaseTypeErrorException class. Use it when you are unable to find a .net framework type equivalent in sql server.
        /// </summary>
        /// <param name="message"></param>
        public DatabaseTypeErrorException(string message) : base("DatabaseTypeError", message)
        {

        }

        #endregion
    }
}
