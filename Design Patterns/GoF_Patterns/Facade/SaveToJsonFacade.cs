using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Facade
{
    
    public static class SaveToJsonFacade <T>
    {
        public static void Save(string fileName,T data)
        {
            using (FileStream fs = new FileStream(fileName+".json", FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize<T>(fs, data);
            }
        }
    }
}
