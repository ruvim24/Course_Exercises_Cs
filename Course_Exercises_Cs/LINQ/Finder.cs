using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.LINQ
{
    public static class Finder
    {
        public static List<Book> FindByName(List<Book> books, string author)
        {
            var booksList = books.Where(b => b.Author.Equals(author)&& b.CopiesAvailable > 0)
                .OrderBy(d => d.Year)
                .Select(d => d).ToList();
            return booksList;
        }
        public static int FindNrCopiesByAuthor(List<Book> books, string author)
        {
            var nrOfCopies = books
                .Where(b=>b.Author.Equals(author))
                .Aggregate(0,(acc, a) => acc + a.CopiesAvailable);
            return nrOfCopies;
        }
        public static int FindNrCopiesLibrary(List<Book> books)
        {
            var nrOfCopies = books
                .Aggregate(0, (acc, a) => acc + a.CopiesAvailable);
            return nrOfCopies;
        }
        public static List<Book> FindDistinct(List<Book> books)
        {
            var distinctAuthor = books
                .DistinctBy(a => a.Author);
            return distinctAuthor.ToList();
        }

    }
}
    