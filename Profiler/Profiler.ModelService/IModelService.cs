using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Profiler.ModelService
{
    public interface IModelService
    {
        int Key { get; set; }
        string Name { get; set; }
    }
}
