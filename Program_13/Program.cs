using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InputNumber;

namespace Program_13
{
    class Program
    {
        static void Menu1()
        {
            int cmd;
            bool sform = false;
            MyCollection collection = null;
            do
            {
                Console.WriteLine("1. Создать коллекцию\n" +
                                  "2. Добавить элемент в конец коллекции.\n" +
                                  "3. Очистка коллекции.\n" +
                                  "4. Проверка, есть ли элемент с заданным ФИО водителя в коллекции.\n" +
                                  "5. Удаление элемента из коллекции(по ФИО).\n" +
                                  "6. Печать коллекции.\n" +
                                  "7. Сортировка коллекии по кол-ву пассажиров.\n" +
                                  "8. Выход.\n");

                cmd = InputNum.Input_int("Выберите действие: ");
                switch (cmd)
                {
                    case 1:
                        Console.Clear();
                        int size = InputNum.Input_int("Введите кол-во элементов коллекции: ");
                        collection = new MyCollection(size);
                        Console.Clear();
                        Console.WriteLine("Коллекция успешно сформирована.\n");
                        sform = true;
                        break;
                    case 2:
                        Console.Clear();
                        if (sform)
                        {
                            collection.Add(RandElem.Rand());
                            Console.WriteLine("Элемент успешно добавлен!\n");
                        }
                        else Console.WriteLine("Коллекция не сформирована!\n");
                        break;
                    case 3:
                        Console.Clear();
                        if (sform)
                        {
                            collection.Clear();
                            Console.WriteLine("Коллекция успешно очищена!\n");
                        }
                        else Console.WriteLine("Коллекция не сформирована!\n");
                        break;
                    case 4:
                        Console.Clear();
                        if (sform)
                        {
                            Console.Write("Введите фио водителя: ");
                            string fio = Console.ReadLine();
                            TranspSredstv[] buf = new TranspSredstv[collection.Count];
                            TranspSredstv elem = null;
                            collection.CopyTo(buf, 0);
                            for(int i = 0; i < collection.Count; i++)
                            {
                                if (buf[i].Name_vod == fio)
                                {
                                    elem = buf[i];
                                    break;
                                }
                            }
                            if (collection.Contains(elem)) Console.WriteLine("Элемент входит в коллекцию.\n");
                            else Console.WriteLine("Элемент не входит в коллекцию\n");
                        }
                        else Console.WriteLine("Коллекция не сформирована!\n");
                        break;
                    case 5:
                        Console.Clear();
                        if (sform)
                        {
                            if (collection.Count == 0) Console.WriteLine("В коллекции нет элементов.\n");
                            else
                            {
                                Console.Write("Введите фио водителя: ");
                                string fio = Console.ReadLine();
                                TranspSredstv[] buf = new TranspSredstv[collection.Count];
                                TranspSredstv elem = null;
                                collection.CopyTo(buf, 0);
                                for (int i = 0; i < collection.Count; i++)
                                {
                                    if (buf[i].Name_vod == fio)
                                    {
                                        elem = buf[i];
                                        break;
                                    }
                                }
                                Console.Clear();
                                if (collection.Remove(elem)) Console.WriteLine("Элемент успешно удален.\n");
                                else Console.WriteLine("Элемент не найден.\n");
                            }
                        }
                        else Console.WriteLine("Коллекция не сформирована!\n");
                        break;
                    case 6:
                        Console.Clear();
                        if (sform)
                        {
                            if (collection.Count == 0) Console.WriteLine("В коллекции нет элементов.\n");
                            else
                            {
                                collection.Show();
                                Console.WriteLine();
                            }
                        }
                        else Console.WriteLine("Коллекция не сформирована!\n");
                        break;
                    case 7:
                        Console.Clear();
                        if (sform)
                        {
                            if (collection.Count == 0) Console.WriteLine("В коллекции нет элементов.\n");
                            else
                            {
                                TranspSredstv[] buf = new TranspSredstv[collection.Count];
                                collection.CopyTo(buf, 0);
                                Array.Sort(buf);
                                collection.Clear();
                                for(int i = 0; i < buf.Length; i++)
                                {
                                    collection.Add(buf[i]);
                                }
                                Console.WriteLine("Коллекция успешно отсортирована.\n");
                            }
                        }
                        else Console.WriteLine("Коллекция не сформирована!\n");
                        break;
                    case 8:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такого действия нет, выберите другое действие!\n");
                        break;
                }
            } while (cmd != 8);
        }

        static void Menu2()
        {
            int cmd = 0;
            bool sform = false;
            bool sform_j_1 = false;
            bool sform_j_2 = false;
            MyNewCollection collection_1 = null;
            MyNewCollection collection_2 = null;
            Journal journal_1 = new Journal();
            Journal journal_2 = new Journal();
            do
            {
                Console.WriteLine("1. Создать 2 коллекции.\n" +
                                  "2. Подписать журнал 1 на события изменения кол-ва элементов и события изменения ссылок на элементы коллекции 1.\n" +
                                  "3. Подписать журнал 2 на события изменения ссылок на элементы из коллекции 1 и коллекции 2.\n" +
                                  "4. Добавить элемент в коллекцию 1.\n" +
                                  "5. Добавить элемент в коллекцию 2.\n" +
                                  "6. Удалить элемент из коллекции 1.\n" +
                                  "7. Удалить элемент из коллекции 2.\n" +
                                  "8. Изменить значение элемента по индексу из коллекции 1.\n" +
                                  "9. Изменить значение элемента по индексу из коллекции 2.\n" +
                                  "10. Вывести данные из обоих журналов в консоль.\n" +
                                  "11. Печать коллекций.\n" +
                                  "12. Выход.\n");
                cmd = InputNum.Input_int("Выберите действие: ");
                switch(cmd)
                {
                    case 1:
                        Console.Clear();
                        if (!sform)
                        {
                            int size_1 = InputNum.Input_int("Введите кол-во элементов 1 коллекции: ");
                            collection_1 = new MyNewCollection("Коллекция 1", size_1);
                            Console.Clear();
                            int size_2 = InputNum.Input_int("Введите кол-во элементов 2 коллекции: ");
                            collection_2 = new MyNewCollection("Коллекция 2", size_2);
                            sform = true;
                            Console.Clear();
                            Console.WriteLine("Коллекции успешно сформированы.\n");
                        }
                        else Console.WriteLine("Коллекции уже сформированы!\n");
                        break;
                    case 2:
                        Console.Clear();
                        if (sform)
                        {
                            if (!sform_j_1)
                            {
                                collection_1.CollectionCountChenged += journal_1.CollectionCountChanged;
                                collection_1.CollectionReferensCenged += journal_1.CollectionReferenceChanged;
                                Console.WriteLine("Журнал 1 успешно подписан на события.\n");
                                sform_j_1 = true;
                            }
                            else Console.WriteLine("Журнал уже подписан на эти события!\n");
                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 3:
                        Console.Clear();
                        if (sform)
                        {
                            if (!sform_j_2)
                            {
                                collection_1.CollectionReferensCenged += journal_2.CollectionReferenceChanged;
                                collection_2.CollectionReferensCenged += journal_2.CollectionReferenceChanged;
                                Console.WriteLine("Журнал 2 успешно подписан на события.\n");
                                sform_j_2 = true;
                            }
                            else Console.WriteLine("Журнал уже подписан на эти события!\n");
                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 4:
                        Console.Clear();
                        if (sform)
                        {
                            collection_1.Add();
                            Console.WriteLine("Элемент успешно добавлен.\n");
                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 5:
                        Console.Clear();
                        if (sform)
                        {
                            collection_2.Add();
                            Console.WriteLine("Элемент успешно добавлен.\n");
                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 6:
                        Console.Clear();
                        if (sform)
                        {
                            if (collection_1.Count != 0)
                            {
                                Console.Clear();
                                if (collection_1.RemoveAt(InputNum.Input_int("Введите индекс удаляемого элемента: ")))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Элемент успешно удален.\n");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Элемента с таким индексом нет в коллекции.\n");
                                }
                            }
                            else Console.WriteLine("В коллекции нет элементов.\n");
                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 7:
                        Console.Clear();
                        if (sform)
                        {
                            if (collection_1.Count != 0)
                            {
                                Console.Clear();
                                if (collection_2.RemoveAt(InputNum.Input_int("Введите индекс удаляемого элемента: ")))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Элемент успешно удален.\n");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Элемента с таким индексом нет в коллекции.\n");
                                }
                            }
                            else Console.WriteLine("В коллекции нет элементов.\n");

                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 8:
                        Console.Clear();
                        if (sform)
                        {
                            if (collection_1.Count == 0) Console.WriteLine("В коллекции нет элементов.\n");
                            else
                            {
                                collection_1[InputNum.Input_int("Введите индекс изменяемого элемента: ") - 1] = RandElem.Rand();
                                Console.Clear();
                                Console.WriteLine("Элемент успешно изменен.\n");
                            }
                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 9:
                        Console.Clear();
                        if (sform)
                        {
                            if (collection_2.Count == 0) Console.WriteLine("В коллекции нет элементов.\n");
                            else
                            {
                                collection_2[InputNum.Input_int("Введите индекс изменяемого элемента: ") - 1] = RandElem.Rand();
                                Console.Clear();
                                Console.WriteLine("Элемент успешно изменен.\n");
                            }
                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 10:
                        Console.Clear();
                        if (sform)
                        {
                            //Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Журнал 1: ");
                            Console.WriteLine(journal_1);
                            Console.WriteLine();
                            Console.WriteLine("Журнал 2: ");
                            Console.WriteLine(journal_2);
                            Console.WriteLine();
                            //Console.ResetColor();
                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 11:
                        Console.Clear();
                        if(sform)
                        {
                            if (collection_1.Count == 0) Console.WriteLine("В коллекции 1 нет элементов.\n");
                            else
                            {
                                Console.WriteLine("Коллекция 1:");
                                collection_1.Show();
                            }
                            Console.WriteLine();
                            if (collection_2.Count == 0) Console.WriteLine("В коллекции 2 нет элементов.\n");
                            else
                            {
                                Console.WriteLine("Коллекция 2:");
                                collection_2.Show();
                                Console.WriteLine();
                            }
                        }
                        else Console.WriteLine("Коллекции не сформированы!\n");
                        break;
                    case 12:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такого действия нет, выберите другое действие!\n");
                        break;
                }
            } while (cmd != 12);
        }

        static void Main(string[] args)
        {
            int cmd;
            do
            {
                Console.WriteLine("1. Часть 1.\n" +
                                  "2. Часть 2.\n" +
                                  "3. Выход.\n");
                cmd = InputNum.Input_int("Выберите действие: ");
                switch (cmd)
                {
                    case 1:
                        Console.Clear();
                        Menu1();
                        break;
                    case 2:
                        Console.Clear();
                        Menu2();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такого действия нет, выберите другое действие!\n");
                        break;
                }
            } while (cmd != 3);


            //MyNewCollection collection = new MyNewCollection("Коллекция 1.", 10);
            //Journal journal = new Journal();
            ////collection.CollectionCountChenged += journal.CollectionCountChanged;
            ////collection.CollectionReferensCenged += journal.CollectionReferenceChanged;

            //collection.Show();

            //collection.RemoveAt(1);
            //Console.WriteLine("\n\n\nУдаление элемента с индексом 1: \n");
            //collection.Show();

            //Console.WriteLine("\n\n\nДобавление в конец коллекции нового элемента:\n");
            //collection.Add();
            //collection.Show();

            //Console.WriteLine("\n\n\nЖурнал изменений: \n");
            //Console.Write(journal.ToString());
        }
    }
}
