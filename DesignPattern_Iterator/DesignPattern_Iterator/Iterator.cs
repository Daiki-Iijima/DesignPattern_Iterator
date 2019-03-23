using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    // 数え上げ、スキャンを表すインターフェース
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

}
