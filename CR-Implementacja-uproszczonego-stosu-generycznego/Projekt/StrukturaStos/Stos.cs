namespace StrukturaStos
{
    // class X : dziedziczy, implementuje, implementuje, ...
    public class Stos<T> : Object, IStos<T>
    {
        private List<T> _list = new List<T>();


        public T Peek => (!IsEmpty) ?
                            _list[Count - 1] : throw new StosEmptyException("Stos jest pusty");
     

        public int Count => _list.Count();

        public bool IsEmpty => (_list.Count == 0);

        public void Clear() => _list.Clear();
        public T Pop()
        {
            var element = Peek;
            _list.RemoveAt(Count - 1);
            return element;
        }

        public void Push(T element) => _list.Add(element);
        public T[] ToArray() => _list.ToArray();
    }
}
