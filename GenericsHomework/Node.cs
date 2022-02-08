namespace GenericsHomework
{
    public class Node
    {
        public object? Value { get; set; }
        private Node Next { get; set; }
        public Node? Head { get; set; }

        public int Size;

        public Node(object? value)
        {
            Value = value;
            Next = this;
            Size = 0;
        }

        // properties
        private Node GetNext() { return Next; }

        public Node SetNext(Node Next) => this.Next = Next;

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
            }
            else
            {
                Head?.SetNext(cur);
                Head = cur;
            }

            Size++;

        }

        public Boolean Exists(object? value)
        {
            Node cur = new Node(value);
            Node i = this; // an index

            while (this.Next != this) // wraps around and stops at the current node 
            {
                if (cur.ToString() == i.ToString()) {
                    return true;
                   }
             }
            return false;
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
    }
}