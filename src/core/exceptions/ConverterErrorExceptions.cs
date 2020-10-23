using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.exceptions
{
    /// <summary>
    /// This class is used to create new exceptions about noxORM converter error
    /// </summary>
    public class ConverterErrorExceptions : NoxORMException
    {
        #region Fields

        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor of the ConverterErrorExceptions class.
        /// </summary>
        /// <param name="message">Describes the error itself</param>
        public ConverterErrorExceptions(string message) : base ("ConverterError", message)
        {

        }

        #endregion
    }
}
