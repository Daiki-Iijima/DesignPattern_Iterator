using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    // 本棚を表すクラス
    public class BookShelf : IAggregate
    {
        List<Book> books = new List<Book>();
        int Last { get; set; } = 0;
        public Book GetBookAt(int index)
        {
            return books[index];
        }
        public void appendBook(Book book)
        {
            this.books.Add(book);
            Last++;
        }
        public int GetLength()
        {
            return this.Last;
        }
        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
