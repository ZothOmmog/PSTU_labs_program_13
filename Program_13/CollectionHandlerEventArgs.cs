using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    //Класс, который предоставляет строку для классов, которые подписываются на события из класса-издателя MyNewCollection
    public class CollectionHandlerEventArgs : System.EventArgs
    {
        public string NameCollection { get; private set; }
        public string TypeChanges { get; private set; }
        public object Reference { get; private set; }

        public CollectionHandlerEventArgs(string NameCollection, string TypeChanges, object Reference)
        {
            this.NameCollection = NameCollection;
            this.TypeChanges = TypeChanges;
            this.Reference = Reference;
        }
    }
}
