using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    public class ReverseBookShelfIterator : IIterator
    {
        BookShelf BookShelf { get; set; }
        int Index { get; set; }
        public ReverseBookShelfIterator(BookShelf bookShelf)
        {
            this.BookShelf = bookShelf;
            this.Index = bookShelf.GetLength()-1;
            Console.WriteLine("今の数" + this.Index);
        }
        public bool HasNext()
        {
            if (0 <= this.Index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public object Next()
        {
            Book book = BookShelf.GetBookAt(this.Index);
            this.Index--;
            return book;
        }
    }
}
