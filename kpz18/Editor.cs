using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz18
{
    public class Editor
    {
        private string _text = "";

        public void SetText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }

        public Memento Save()
        {
            return new Memento(_text);
        }

        public void Restore(Memento memento)
        {
            _text = memento.State;
        }

        public void Print()
        {
            Console.WriteLine($"\nПоточний код:\n{_text}");
        }
    }

}
