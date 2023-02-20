using System.Collections.Generic;

public class Stack<T>
{
    public List<T> list { get; set; }
    public int count { get; set; }
    public int indexer = 0;

    public void Push(T cislo)
    {
        list.Add(cislo);
        indexer++;
    }

    public void Pop()
    {
        if (indexer == 0)
        {
            Console.WriteLine("Zásobník je prázdný");
        }
        else
        {
            list.RemoveAt(indexer);
            indexer--;
        }
    }

    public int CountF()
    {
        count = list.Count();
        return count;
    }
}

public class Dictionary<TKey, TValue>
{
    public Dictionary<TKey, TValue> dict { get; set; }
    
    public int indexer = 0;
    public int count { get; set; }

    public void Add(TKey key, TValue value)
    {
        dict.Add(key, value);
        indexer++;
    }

    public void Remove(TKey key)
    {
        if (dict.ContainsKey(key)) //nevim, proc nefunguje tenhle operator
        {
            dict.Remove(key);
            indexer--;
        }
        else
        {
            Console.WriteLine($"{key} nebyl nalezen");
        }
        
    }

    public int CountF()
    {
        count = dict.Count(); //nevim, proc nefunguje tenhle operator
        return count;
    }

}

public class Queue<T>
{
    public List<T> queue { get; set; }
    public int count { get; set; }

    public void Enqueue(T cislo)
    {
        queue.Add(cislo);
    }

    public void Dequeue(T cislo)
    {
        queue.Remove(cislo);
    }

    public int CountF()
    {
        count = queue.Count();
        return count;
    }
}

