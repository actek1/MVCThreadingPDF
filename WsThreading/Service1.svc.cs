using MVCThreading.Libraries.BusinessRules.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WsThreading
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public async Task<string> GetDataAsync(string[] array)
        {
            var result = await processingAsync(array);
            //var r = await result;
            return array[0];
        }

        private async Task<int> processingAsync(string[] array)
        {
            await Task.Delay(15000);
            bool result2 = new RealFiles(@"C:\Users\Actek\Documents\test").createNewFile(array, "\\WsArray.txt");

            return 0;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
