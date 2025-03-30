using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz18
{
    public class History
    {
        private Stack<Memento> _history = new Stack<Memento>();

        public void Push(Memento memento)
        {
            _history.Push(memento);
        }

        public Memento Pop()
        {
            return _history.Count > 0 ? _history.Pop() : null;
        }

        public bool HasUndo()
        {
            return _history.Count > 0;
        }
    }
}
