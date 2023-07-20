using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace builder
{
    public class NotebookBuilder : ComputerBuilder
    {
        Computer Computer;
        public NotebookBuilder()
        {
            Computer = new Computer("Notebook");
        }

        public override void Devices()
        {
            System.Console.WriteLine("Devices builded on Notebook... ");
        }

        public override void Os()
        {
            System.Console.WriteLine("Os Builded on Notebook... ");
        }

        public Computer ComputerType
        {
            get{return Computer;}
        }
        
    }
}