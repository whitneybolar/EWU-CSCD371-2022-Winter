namespace GenericsHomework
{
    public class Node
    {
        public object? Value { get; set; }

        public Node Next { get; private set; }
        public Node? Head { get; set; }

        public Node? Tail{ get; set; }

        public int Size;

        public Node(object? value)
        {
            Value = value;
            Next = this;
            Size = 0;
        }

        // properties
        private Node GetNext() { return Next; }

        //private Node SetNext(Node Next) => this.Next = Next;

        public int GetSize() { return Size; }

        // methods 
        public void Append(object? value)
        {

            if (Exists(value))
            {
                throw new ArgumentException(message: "Value exists in list already");
            }

            Node cur = new Node(value);

            if (GetSize() == 0)
            {
                Head = cur;
                Tail = cur;
            }
            else
            {
                Head = cur.Next;
            }

            Size++;

        }

        public Boolean Exists(object? value)
        {
            Node cur = new Node(value);
            Node i = this; // an index

               if (this.Next == this) // wraps around and stops at the current node 
                {
                   if (cur.ToString() == i.Next.ToString()) {
                        return true;
                     }
                 }

            return false ;
        }
           
        
        public void Clear()
        {
            Node i = this; 

            while (i.Size != 1) // there should only be one left everytime 
            {
                this.Next = this;
                Size--;
            } 
        }

        public override string? ToString()
        {
            return Value?.ToString();
        }

        public string GarbageCollection()
        {
            Node cur = this;

            if(cur.GetSize() >= 5)
            {
                return "Worry about garbage collection";
            }
            return "Your list is fine";
        }
    }
}