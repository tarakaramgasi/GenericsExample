namespace Queues
{
    public class Queue1<T>
    {
        private List<T> list = new List<T>();
        public void Enqueue(T item)
        {
            list.Add(item);
        }
        public T Dequeue() 
        {
            T item = list[0];
            list.RemoveAt(0);
            return item;
        }
        public int Count { get { return list.Count; } }

        public void Display()
        {
            foreach (var item in list)
            { 
                Console.WriteLine(item); 
            }
        }
    }
}
