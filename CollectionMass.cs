using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9MassCollection
{
    internal class Collection<T>
    {
        private List<T> ListCollection { get; set; }
        public Collection()
        {
            ListCollection = new List<T>();
        }
        public void Add(T[] array) // Добавление элементов
        {
            ListCollection.AddRange(array);
        }
        public void Add(T val) // Добавление элементов
        {
            ListCollection.Add(val);
        }
        public List<T> AsList() // перехват коллекции для другого класса
        {
            return ListCollection;
        }
        public void Remove(T item) // удаление элемента
        {
            ListCollection.Remove(item);
        }
        //public T GetItem(int index)
        //{
        //    return ListCollection[index];
        //}
        public T this[int index] // получение элемента
        {
            get => ListCollection[index];
            set => ListCollection[index] = value;
        }
        public int Count() // получение длинны
        {
            return ListCollection.Count();
        }

    }

    internal class CollectionInt : Collection<int>
    {
        public static CollectionInt operator +(CollectionInt conteiner1, CollectionInt conteiner2)
        {
            var result = new CollectionInt();
            if (conteiner1.Count() != conteiner2.Count())
            {
                throw new Exception("Размеры массива не совпадают");
            }

            for (int i = 0; i < conteiner1.Count(); i++)
            {
                result.Add(conteiner1[i] + conteiner2[i]);
            }
            return result;
        }

        public static bool operator ==(CollectionInt conteiner1, CollectionInt conteiner2)
        {
            if(conteiner1.Count() != conteiner2.Count())
            {
                Console.WriteLine("Размеры массива не совпадают");
            }
            for(int i = 0; i < conteiner1.Count(); i++)
            {
                if (conteiner1[i] != conteiner2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator !=(CollectionInt conteiner1, CollectionInt conteiner2)
        {
            if (conteiner1.Count() != conteiner2.Count())
            {
                Console.WriteLine("Размеры массива не совпадают");
            }
            for (int i = 0; i < conteiner1.Count(); i++)
            {
                if (conteiner1[i] != conteiner2[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
