using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.attributes
{
    /// <summary>
    /// This class is used to define which attribute is a primary key.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKey : BaseAttribute
    {

        #region Fields

        public string keyName { get; set; }
        public string constraintName { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor of PrimaryKey Class. Use it for test purposes.
        /// </summary>
        public PrimaryKey()
        {
            this.keyName = "IdPrimary";
            this.constraintName = "pk_IdPrimary";

        }

        /// <summary>
        /// Main constructor of PrimaryKey Class.
        /// </summary>
        /// <param name="keyName">Represent the name of the attribute.</param>
        /// <param name="constraintName">Represent the constraint name of the primary key.</param>
        public PrimaryKey(string keyName, string constraintName)
        {
            this.keyName = keyName;
            this.constraintName = constraintName;
        }

        #endregion

    }
}
