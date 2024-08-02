using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.Generics.GenericPriorityQueue
{
    public class MyPriorityQueue<TValue, TPriority>
        where TPriority : IComparable<TPriority>
    {
        
        public List<PrioriyQueueItem<TValue, TPriority>> lista;
        public MyPriorityQueue()
        {
            lista = new List<PrioriyQueueItem<TValue, TPriority>>();
        }

        public void Enqueue(TValue item, TPriority priority)
        {
            lista.Add(new PrioriyQueueItem<TValue, TPriority>(item, priority));            
        }

        public PrioriyQueueItem<TValue, TPriority> Dequeue()
        {
            if (!IsEmpty()) 
            {
                var priorityElement = lista[0];
                foreach (var elem in lista) //prentru a a gasi prioritatea
                {
                    if (elem.Priority.CompareTo(priorityElement.Priority) < 1)
                    {
                        priorityElement = elem;
                    }
                }

                var temp = priorityElement;
                lista.RemoveAt(lista.IndexOf(priorityElement));
                return temp;
            }
            else
            {
                return null;
            }
        }
        public PrioriyQueueItem<TValue, TPriority> Peek()
        {
            if (!IsEmpty())
            {
                var priorityElement = lista[0];
                foreach (var elem in lista)
                {
                    if (elem.Priority.CompareTo(priorityElement.Priority) < 1)
                    {
                        priorityElement = elem;
                    }
                }

                return priorityElement;
            }
            else
            {
                return null;
            }
        }
        public bool IsEmpty()
        {
            if (lista.Count == 0) return true;
            return false;
        }
    }

}
