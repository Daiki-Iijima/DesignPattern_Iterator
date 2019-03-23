using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    // 集合体を表すインターフェース
    // IAggregate = 集約する
    public interface IAggregate
    {
        IIterator Iterator();

        //逆順取得
        IIterator ReverseIterator();
    }
}
