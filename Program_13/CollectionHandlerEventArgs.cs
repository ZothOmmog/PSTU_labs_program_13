using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    //Класс, экземпляр которого содержит имя коллекции, сведения об изменениях в ней и ссылку на эту коллекцию
    class CollectionHandlerEventArgs : System.EventArgs
    {
        public string NameCollection { get; private set; }
        public string TypeChanges { get; private set; }
        public TranspSredstv Reference { get; private set; }

        public CollectionHandlerEventArgs(string NameCollection, string TypeChenges, TranspSredstv Reference)
        {
            this.NameCollection = NameCollection;
            this.TypeChanges = TypeChanges;
            this.Reference = Reference;
        }
    }
}
