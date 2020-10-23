# DatabaseTypeErrorException

#### Explications
Cette classe a été conçu dans le but de faire un type d'exception concernant les conversions entre les types primaires vers les types de la base de données.

#### Code
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.exceptions
{
    public class DatabaseTypeErrorException : NoxORMException
    {
        public DatabaseTypeErrorException(string message) : base("DatabaseTypeError", message)
        {
        }
    }
}

```