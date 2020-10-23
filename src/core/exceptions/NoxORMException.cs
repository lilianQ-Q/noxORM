using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.exceptions
{
    [Serializable]
    public class NoxORMException : Exception, ISerializable
    {
        #region Fields

        public string errorCode { get { return this._errorCode; } } 
        private string _errorCode { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor of noxORMException class
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        public NoxORMException(string errorCode, string errorMessage) : base(errorMessage)
        {
            this._errorCode = errorCode;
        }

        #endregion
    }
}
