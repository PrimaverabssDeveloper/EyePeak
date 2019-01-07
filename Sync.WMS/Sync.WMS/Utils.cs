using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Sync.WMS.WMSDataImportWS;

namespace Sync.WMS
{
    public static class Utils
    {
        //Open web service configuration
        private static string URL = String.Format(@"{0}/{1}", "http://localhost:9999", "WMSDataImport");
        //private static string URL = String.Format(@"{0}/{1}", "http://localhost:8089", "WMSDataImport");
        private static BasicHttpBinding GetBasicHttpBinding()
        {
            int maxStringContentLenght = 2147483647; //2097152;

            TimeSpan SendReceiveTimeout = new TimeSpan(0, 20, 0);
            TimeSpan openTimeout = new TimeSpan(0, 0, 15);

            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            binding.OpenTimeout = openTimeout;
            binding.ReaderQuotas.MaxStringContentLength = maxStringContentLenght;
            binding.MaxReceivedMessageSize = maxStringContentLenght;
            binding.MaxBufferPoolSize = maxStringContentLenght;
            binding.MaxBufferSize = maxStringContentLenght;
            binding.BypassProxyOnLocal = true;
            binding.ReceiveTimeout = SendReceiveTimeout;
            binding.SendTimeout = SendReceiveTimeout;
            return binding;
        }

        public static WMSDataImportClient WS_CLIENT()
        {
            return new WMSDataImportClient(GetBasicHttpBinding(), new EndpointAddress(URL));
        }

    }
}
