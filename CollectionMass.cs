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
}
