using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public interface IService
    {
        int Foo { get; }
    }

    public class Service : IService
    {
        public int Foo { get; } = 5;
    }
}
