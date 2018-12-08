using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InputNumber;
using ArrayExceptionHandling;

namespace Program_13
{
    //public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);
    //Класс-издатель, который гинерирует 2 события
    class MyNewCollection : MyCollection
    {
        public event EventHandler<CollectionHandlerEventArgs> CollectionCountChenged; //При изменении кол-ва элементов
        public event EventHandler<CollectionHandlerEventArgs> CollectionReferensCenged; //При изменении элемента

        string NameCollection { get; set; }

        public MyNewCollection(string NameCollection, int Count) : base(Count)
        {
            this.NameCollection = NameCollection;
        }

        //Индексатор
        public TranspSredstv this[int index]
        {
            get
            {
                index = ExceptionHandlingArray.TestIndex(index, Count);
                return arr[index];
            }
            set
            {
                index = ExceptionHandlingArray.TestIndex(index, Count);
                arr[index] = value;
                CollectionReferensCenged?.Invoke(this, new CollectionHandlerEventArgs(NameCollection,
                                                   String.Format("Изменен элемент коллекции с индексом {0}.", index + 1), arr[index]));
            }
        }

        //Добавление элемента в конец
        public void Add()
        {
            TranspSredstv item = RandElem.Rand();
            if (Count < Capasity)
            {
                arr[Count] = item;
                CollectionCountChenged?.Invoke(this, new CollectionHandlerEventArgs(NameCollection, "Добавление 1 элемента в конец коллекции.", arr[Count]));
            }
            else
            {
                Resize();
                arr[Count] = item;
                CollectionCountChenged?.Invoke(this, new CollectionHandlerEventArgs(NameCollection, "Добавление 1 элемента в конец коллекции.", arr[Count]));
            }
            Count++;
        }

        //Удаление элемента по идексу
        public bool RemoveAt(int index)
        {
            if (index > 0 && index < Count)
            {
                TranspSredstv[] buf = new TranspSredstv[Capasity];
                TranspSredstv del_elem = arr[index - 1];
                for (int i = 0, j = 0; i < Count; i++)
                {
                    if (i == index - 1) continue;
                    buf[j] = arr[i];
                    j++;
                }
                Count--;
                arr = buf;
                CollectionCountChenged?.Invoke(this, new CollectionHandlerEventArgs(NameCollection,
                String.Format("Удаление из коллекции элемента с индексом {0}.", index), del_elem));
                return true;
            }
            else return false;
        }
    }
}
