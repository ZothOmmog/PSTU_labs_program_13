using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InputNumber;
using ArrayExceptionHandling;

namespace Program_13
{
    class MyCollection : ICollection<TranspSredstv>
    {
        

        protected TranspSredstv[] arr;
        public int Count { get; protected set; } //Кол-во элементов
        public int Capasity { get { return arr.Length; } } //Макс. кол-во элементов

        public bool IsReadOnly => throw new NotImplementedException();

        //Создание пустой коллекции
        public MyCollection()
        {

        }

        //Заполнение коллекции рандомными элементами
        public MyCollection(int Count)
        {
            Count = ExceptionHandlingArray.TestSize(Count);
            arr = new TranspSredstv[Count];
            for (int i = 0; i < Count; i++) this.Add(RandElem.Rand());
        }

        

        //Добавление элемента в конец
        public void Add(TranspSredstv item)
        {
            if (Count < Capasity)
            {
                arr[Count] = item;
            }
            else
            {
                Resize();
                arr[Count] = item;
            }
            Count++;
        }

        //Увеличение максимального размера коллекции
        protected void Resize()
        {
            int NewCapasity;
            if(Capasity == 0) NewCapasity = 4;
            else NewCapasity = Capasity * 2;
            TranspSredstv[] buf_arr = new TranspSredstv[NewCapasity];
            arr.CopyTo(buf_arr, 0);
            arr = buf_arr;
        }

        //Очистка коллекции
        public void Clear()
        {
            arr = new TranspSredstv[4];
            Count = 0;
        }

        //Проверка, есть ли этот элемент в коллекции
        public bool Contains(TranspSredstv item)

        {
            for(int i = 0; i < Count; i++) if (arr[i] == item) return true;
            return false;
        }

        //Копирование элементов коллекции в соответствующий масссив
        public void CopyTo(TranspSredstv[] array, int arrayIndex)
        {
            for (int i = 0; i < Count; i++)
            {
                array[i] = arr[i];
            }
        }

        //Для foreach
        public IEnumerator<TranspSredstv> GetEnumerator()
        {
            for (int i = 0; i < Count; i++) yield return arr[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //Удаление первого вхождения, если элемент найден
        public bool Remove(TranspSredstv item)
        {
            bool flag = false;
            TranspSredstv[] buf = new TranspSredstv[Capasity];
            for (int i = 0, j = 0; i < Count; i++)
            {
                if (arr[i] == item && !flag)
                {
                    flag = true;
                    continue;
                }
                buf[j] = arr[i];
                j++;
            }
            arr = buf;
            Count--;
            return flag;
        }

        //Печать коллекции
        public void Show()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, arr[i]);
            }
        }
    }
}
