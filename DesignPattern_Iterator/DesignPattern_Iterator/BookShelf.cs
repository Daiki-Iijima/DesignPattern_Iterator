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

        //指定した本を取得
        public Book GetBookAt(int index)
        {
            return books[index];
        }
        //本を追加
        public void appendBook(Book book)
        {
            this.books.Add(book);
            Last++;
        }
        //本数を取得
        public int GetLength()
        {
            return this.Last;
        }
        //順番に取得
        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
        //逆順に取得
        public IIterator ReverseIterator()
        {
            return new ReverseBookShelfIterator(this);
        }
    }
}
