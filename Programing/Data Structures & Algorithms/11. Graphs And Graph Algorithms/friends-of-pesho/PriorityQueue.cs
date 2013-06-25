using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
class PriorityQueue<P, V> : IEnumerable<Tuple<P, V>>
{
    readonly SortedSet<Tuple<P, V>> set;
    readonly Dictionary<V, Tuple<P, V>> entries;



    public PriorityQueue(Comparison<P> comparison)
    {
        comparison.ThrowIfNull();

        set = new SortedSet<Tuple<P, V>>(new EntryComparer(comparison));
        entries = new Dictionary<V, Tuple<P, V>>();
    }
    
    class EntryComparer : IComparer<Tuple<P, V>>
    {
        readonly Comparison<P> comparison;
        
        public EntryComparer(Comparison<P> comparison) {
            this.comparison = comparison;
        }
        
        public int Compare(Tuple<P, V> e1, Tuple<P, V>e2)
        {
            var ret = comparison(e1.Item1, e2.Item1);
            if (ret == 0)
                ret = Comparer<V>.Default.Compare(e1.Item2, e2.Item2);
            return ret;
        }
    }

    public PriorityQueue()
        : this(Comparer<P>.Default.Compare)
    {
    }

    public void Enqueue(P priority, V item)
    {
        var e = new Tuple<P, V>(priority, item);
        this.entries.Add(item, e);
        this.set.Add(e);

        // Debug.Assert(this.set.Count == this.entries.Count);
    }

    public bool Delete(V item)
    {
        Tuple<P, V> e;
        if (this.entries.TryGetValue(item, out e))
        {
            this.set.Remove(e);
            this.entries.Remove(item);
            return true;
        }

        return false;
    }
    public void ChangePriority(V item, P newPriority)
    {
        this.Delete(item);
        this.Enqueue(newPriority, item);
    }
    public P Priority(V item)
    {
        return this.entries[item].Item1;
    }
    public P PriorityOrDefault(V item, P def)
    {
        Tuple<P, V> e;
        if (this.entries.TryGetValue(item, out e))
        {
            return e.Item1;
        }
        return def;
    }
    public V Dequeue()
    {
        var retValue = this.DequeueWithPriority().Item2;
        return retValue;
    }

    public Tuple<P, V> DequeueWithPriority()
    {
        if (this.Count == 0)
            throw new InvalidOperationException("PriorityQueue is empty.");

        var value = this.set.Min;
        this.set.Remove(value);
        entries.Remove(value.Item2);
        return value;
    }

    public int Count
    {
        get { return this.entries.Count; }
    }

    public bool IsEmpty
    {
        get { return this.Count == 0; }
    }

    public IEnumerator<Tuple<P, V>> GetEnumerator()
    {
        return this.set.GetEnumerator();
    }

    public IEnumerable<V> Values
    {
        get
        {
            return this.set.Select(e => e.Item2);
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }


}