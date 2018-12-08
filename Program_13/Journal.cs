using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    //Коллекция экземпляров класса подписчика, содержит в себе данные обо всех событиях на которые был подписан класс JournalEntry
    class Journal
    {
        List<JournalEntry> arr;

        public Journal()
        {
            arr = new List<JournalEntry>();
        }


        //Обработка изменения кол-ва элементов
        public void CollectionCountChanged(object source, CollectionHandlerEventArgs args)
        {
            arr.Add(new JournalEntry(args));
        }

        //Обработка изменения ссылок на элементы коллекции
        public void CollectionReferenceChanged(object source, CollectionHandlerEventArgs args)
        {
            arr.Add(new JournalEntry(args));
        }

        public override string ToString()
        {
            string rez = "Изменений не было зафиксировано.";
                for (int i = 0; i < arr.Count; i++)
                {
                    if (i == 0) rez = "";
                    rez += String.Format("{0}. {1}\n", i + 1, arr[i].ToString());
                }
            return rez;
        }
    }
}
