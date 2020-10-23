using noxORM.src.core.definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noxORM.src.core.builder.interfaces
{
    public interface IGenerator
    {
        string Select(Model model);
        string Insert(Model model);
    }
}
