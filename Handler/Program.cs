using static System.Console;

namespace Handler
{
    internal class Program
    {
        private class Abstract_Handler
        {
            protected string type;

            public virtual void Open()
            { WriteLine($"файл {type} открыт"); }

            public virtual void Create()
            { WriteLine($"файл {type} создан"); }

            public virtual void Change()
            { WriteLine($"файл {type} изменён"); }

            public virtual void Save()
            { WriteLine($"файл {type} сохранен"); }
        }

        private class XMLHandler : Abstract_Handler
        {
            public XMLHandler()
            {
                type = "XML";
            }
        }

        private class TXTHandler : Abstract_Handler
        {
            public TXTHandler()
            {
                type = "TXT";
            }
        }

        private class DOCHandler : Abstract_Handler
        {
            public DOCHandler()
            {
                type = "DOC";
            }
        }

        private static void Main(string[] args)
        {
            Abstract_Handler[] handlers = { new TXTHandler(), new XMLHandler(), new DOCHandler() };

            for (int i = 0; i < handlers.Length; i++)
            {
                handlers[i].Create();
                handlers[i].Open();
                handlers[i].Change();
                handlers[i].Save();
                WriteLine();
            }

            ReadLine();
        }
    }
}