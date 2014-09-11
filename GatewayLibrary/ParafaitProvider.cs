using ParafaitPaymentGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GatewayLibrary
{
    class ParafaitProvider
    {
        public static void Connect(GatewayControl gw)
        {
            gw.Invoke(gw.delegateUpdateServerStatus, "Connecting...", null);
            Gateway parafaitPaymentGateway = new Gateway();
            parafaitPaymentGateway = new Gateway();
            if (!parafaitPaymentGateway.InitializeDllMode())
            {
                gw.Invoke(gw.delegateUpdateServerStatus, "Could not connect", null);
                //throw new Exception("Error initializing Parafait External Gateway: " + parafaitPaymentGateway.LastMessageDetails());
                //MessageBox.Show("Error initializing Parafait External Gateway", "Init Gateway");
                //MessageBox.Show(parafaitPaymentGateway.LastMessageDetails(), "Init Gateway");        
            }
            else
            {
                gw.Invoke(gw.delegateUpdateServerStatus, "Connected", parafaitPaymentGateway);
            }
        }
    }
}
