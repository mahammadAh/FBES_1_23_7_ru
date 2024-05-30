using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RepositoryProxy
    {
        private Repository repository { get; set; }
        private Logger Logger { get; set; }

        public RepositoryProxy()
        {
            this.repository = new Repository();
            this.Logger = new Logger();
        }

        public Car Get(int index)
        {
            var car = repository.Cars[index];
            Logger.logs.Add(car.ToString());
            return car;
        }

    }
}
