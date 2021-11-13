using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoMemento
{
    public class Caretaker
    {
        List<Memento> history = new List<Memento>();

        // thêm một memento mới vào history
        public void add(Memento memento)
        {
            history.Add(memento);
        }

        // get at index, return memento index
        public Memento get(int index) 
        {
            return history.ElementAt(index);
        }
    }
}
