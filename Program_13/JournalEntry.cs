using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    //Класс-подписчик, который обрабатывает события, если они возникают
    class JournalEntry
    {
        public string NameCollection { get; private set; }
        public string TypeChanged { get; private set; }
        public object ReferenceChanged { get; private set; }

        public JournalEntry(CollectionHandlerEventArgs args)
        {
            NameCollection = args.NameCollection;
            TypeChanged = args.TypeChanges;
            ReferenceChanged = args.Reference;
        }

        public override string ToString()
        {
            return String.Format("Коллекция: {0}\n   Изменение: {1}\n   Элемент: {2}\n", NameCollection, TypeChanged, ReferenceChanged.ToString());
        }
    }
}
