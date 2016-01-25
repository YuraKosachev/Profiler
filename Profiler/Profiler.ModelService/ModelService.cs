using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profiler.ModelService
{
   public abstract class ModelService:IModelService
    {
       public int Key { get; set; }

       public string Name { get; set; }
    }
}
