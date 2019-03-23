using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    class MainProcess
    {
        static void Main(string[] args)
        {
            //本棚(BookShelf)を作成
            BookShelf bookShelf = new BookShelf();

            //本棚(BookShelf)に本(Book)を追加
            bookShelf.appendBook(new Book("あいうえお"));
            bookShelf.appendBook(new Book("かきくけこ"));
            bookShelf.appendBook(new Book("さしすせそ"));
            bookShelf.appendBook(new Book("たちつてと"));
            
            IIterator it = bookShelf.Iterator();
            IIterator rit = bookShelf.ReverseIterator();

            Console.WriteLine("====順番に取得====");
            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.Name);
            }

            Console.WriteLine("====逆順で取得====");
            while (rit.HasNext())
            {
                Book book = (Book)rit.Next();
                Console.WriteLine(book.Name);
            }

            // 実行が一瞬で終わって確認できないので、キーの入力を待ちます
            Console.ReadLine();
        }
        
    }
}