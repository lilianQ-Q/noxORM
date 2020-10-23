using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.attributes
{
    /// <summary>
    /// This class is used to tell to the orm to not generate the targeted column in the database.
    /// </summary>
    public class NotGenerateColumn : BaseAttribute
    {
        #region Fields



        #endregion

        #region Constructor

        /// <summary>
        /// Main constructor of the NotGenerateColumn class
        /// </summary>
        public NotGenerateColumn()
        {

        }

        #endregion
    }
}
