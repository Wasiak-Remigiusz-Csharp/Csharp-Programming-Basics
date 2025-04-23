namespace BibliotekaKolekcji
{
    // class X : dziedziczy, implementuje, implementuje, ...
    public class StosWTablicy<T> : Object, IStos<T>
    {
        private List<T> _list = new List<T>();

        //// Konstruktor
        //public StosWTablicy() 
        //{
        //    _list = new List<T>();
        //}

        public T Peek => (!IsEmpty) ?
                            _list[Count - 1]  : throw new StosEmptyException("Stos jest pusty");
        //{
        //    get
        //    {
        //        if (IsEmpty)
        //            throw new StosEmptyException("Stos jest pusty");
        //        return _list[Count - 1];
        //    }
        //}

        public int Count => _list.Count();

        public bool IsEmpty => (_list.Count == 0);

        public void Clear() => _list.Clear();
        public T Pop()
        {
            //if (IsEmpty)
            //    throw new StosEmptyException("Stos jest pusty");
            //var element = _list[Count - 1];
            var element = Peek;
            _list.RemoveAt(Count - 1);
            return element;
        }

        public void Push(T element) => _list.Add(element);
        public T[] ToArray() => _list.ToArray();
    }
}
