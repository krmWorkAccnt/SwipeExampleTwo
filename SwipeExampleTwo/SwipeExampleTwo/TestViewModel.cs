using SwipeExampleTwo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SwipeExampleTwo
{
    public class TestViewModel
    {
        List<TestItem> items;
        ICommand command;
        object commandParam;

        public List<TestItem> Items
        {
            get => items;
            set => items = value;
        }

        public ICommand Command
        {
            get => command;
            set => command = value;
        }

        public object CommandParameter
        {
            get => commandParam;
            set => commandParam = value;
        }

        public TestViewModel()
        {
            Items = new List<TestItem>()
            {
                new TestItem(){ Name = "Test One" },
                new TestItem(){ Name = "Test Two" },
                new TestItem(){ Name = "Test Three" },
                new TestItem(){ Name = "Test Four" },
                new TestItem(){ Name = "Test Five" },
                new TestItem(){ Name = "Test Six" },
                new TestItem(){ Name = "Test Seven" },
                new TestItem(){ Name = "Test Eight" },
            };
        }
    }
}
