using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InputNumber;
using ArrayExceptionHandling;

namespace Program_13
{
    delegate void CollectionHandler(MyNewCollection source, CollectionHandlerEventArgs args);

    class MyNewCollection : MyCollection
    {
        event CollectionHandler CollectionCountChenged; //При изменении кол-ва элементов
        event CollectionHandler CollectionReferensCenged; //При изменении элемента

        string NameCollection { get; set; }

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
                CollectionReferensCenged(this, new CollectionHandlerEventArgs(NameCollection,
                String.Format("Изменен элемент коллекции с индексом {0}.", index), arr[index]));
            }
        }

        //Добавление элемента в конец
        public override void Add(TranspSredstv item)
        {
            if (Count < Capasity)
            {
                arr[Count] = item;
                CollectionCountChenged(this, new CollectionHandlerEventArgs(NameCollection, "Добавление 1 элемента в конец массива.", arr[Count]));
            }
            else
            {
                Resize();
                arr[Count] = item;
            }
            Count++;
        }

        //Добавление нескольких элементов в конец массива
        public void AddNew(TranspSredstv[] item)
        {
            for(int i = Count; i < Capasity + item.Length; i++)
            {
                this.Add(RandElem.Rand());
            }
            CollectionCountChenged(this, new CollectionHandlerEventArgs(NameCollection, 
                String.Format("Добавление {0} элементов в конец массива.",item.Length), arr[Count]));
        }

        //Удаление элемента по идексу
        public bool RemoveAt(int index)
        {
            if (index > 0 && index < Count)
            {
                TranspSredstv[] buf = new TranspSredstv[Capasity];
                for (int i = 0, j = 0; i < Count; i++)
                {
                    if (i == index) continue;
                    buf[j] = arr[i];
                    j++;
                }
                Count--;
                CollectionCountChenged(this, new CollectionHandlerEventArgs(NameCollection,
                String.Format("Удаление из коллекции элемента с индексом {0}.", index), arr[index]));
                return true;
            }
            else return false;
        }


    }
}
