using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz18
{
    public class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            State = state;
        }
    }
}
