using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public interface IRunable
    {
        void Run();
    }

    public interface ISwimable
    {
        void Swim();
    }
    public interface ISportable:IRunable,ISwimable
    {

    }
}
