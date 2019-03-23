using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    // 本を表すクラス
    public class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            this.Name = name;
        }
    }
}
