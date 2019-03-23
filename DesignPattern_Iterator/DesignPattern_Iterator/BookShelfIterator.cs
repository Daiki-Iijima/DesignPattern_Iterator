using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    // 本棚をスキャンするクラス
    public class BookShelfIterator : IIterator
    {
        BookShelf BookShelf { get; set; }
        int Index { get; set; }
        public BookShelfIterator(BookShelf bookShelf)
        {
            this.BookShelf = bookShelf;
            this.Index = 0;
        }
        public bool HasNext()
        {
            if (Index < BookShelf.GetLength())
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
            Book book = BookShelf.GetBookAt(Index);
            this.Index++;
            return book;
        }
    }
}
