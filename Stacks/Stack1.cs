namespace Stacks
{
    public class Stack1<T>
    {
        private List<T> list = new List<T>();
        int top;

        public void Push(T item)
        {
            list.Add(item);
            top=list.IndexOf(item);
        }
        public void Pop()
        {
            list.RemoveAt(top);
            top -= 1;
        }
        public int Count
        { get { return list.Count; } }
        public void Display()
        {
            int i = list.Count - 1;
            while (i !=-1)
            {
                Console.WriteLine(list[i]);
                i--;
            }
        }
    }

    
}
