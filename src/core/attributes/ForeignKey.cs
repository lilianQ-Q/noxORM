using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.attributes
{
    /// <summary>
    /// This class is used to create custom attributes about database foreing keys.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ForeignKey : BaseAttribute
    {

        #region Fields

        public string keyName { get; set; }
        public string constraintName { get; set; }
        public string referencesTable { get; set; }
        public string referencesKeyName { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor of ForeignKey class. Use it for test purposes.
        /// </summary>
        public ForeignKey()
        {
            this.keyName = "IdForeign";
            this.constraintName = "fk_IdForeign";
            this.referencesTable = "referenceTable";
            this.referencesKeyName = "referenceKeyName";
        }

        /// <summary>
        /// Auxiliary constructor of ForeignKey class.
        /// </summary>
        /// <param name="referencesTable">Represent the referenced Table.</param>
        /// <param name="referencesKeyName">Represent the referenced primary key.</param>
        public ForeignKey(string referencesTable, string referencesKeyName)
        {
            this.keyName = "IdForeign";
            this.constraintName = "fk_IdForeign";
            this.referencesTable = referencesTable;
            this.referencesKeyName = referencesKeyName;
        }

        /// <summary>
        /// Main constructor of the ForeignKey class.
        /// </summary>
        /// <param name="keyname">Represent key's name.</param>
        /// <param name="constraintName">Represent key's constraint name</param>
        /// <param name="referencesTable">Represent the name of the referenced table.</param>
        /// <param name="referencesKeyName">Represent the name of the referenced primary key.</param>
        public ForeignKey(string keyname, string constraintName, string referencesTable, string referencesKeyName)
        {
            this.keyName = keyName;
            this.constraintName = constraintName;
            this.referencesTable = referencesTable;
            this.referencesKeyName = referencesKeyName;
        }

        #endregion

    }
}
