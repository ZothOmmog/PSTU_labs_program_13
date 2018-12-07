using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    delegate CollectionHandler(object source, CollectionHandlerEventArgs args);
    class CollectionHandlerEventArgs : System.EventArgs
    {

    }
}
