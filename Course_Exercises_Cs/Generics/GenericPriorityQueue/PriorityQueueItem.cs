using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.Generics.GenericPriorityQueue
{
    public class PrioriyQueueItem<TValue, TPriority> : IComparable<PrioriyQueueItem<TValue, TPriority>>
        where TPriority : IComparable<TPriority>

    {
        public TValue Item { get; set; }
        public TPriority Priority { get; set; }

        public PrioriyQueueItem(TValue item, TPriority priority)
        {
            Item = item;
            Priority = priority;
        }

        public int CompareTo(PrioriyQueueItem<TValue, TPriority> other)
        {
            return this.Priority.CompareTo(other.Priority);
        }

        public override string ToString()
        {
            return $"Value: {Item} -> Priority: {Priority}";
        }
    }
}
