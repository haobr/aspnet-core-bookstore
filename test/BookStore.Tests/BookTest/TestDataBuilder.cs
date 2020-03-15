using BookStore.Books;
using BookStore.EntityFrameworkCore;

namespace BookStore.Tests.BookTest
{
    public class TestDataBuilder
    {
        private readonly BookStoreDbContext _context;

        public TestDataBuilder(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.BookInfos.AddRange(
               new BookInfo("Follow the white rabbit", "Hello", "Nothing"),
               new BookInfo("Follow the white rabbit", "Hello", "Nothing"));
        }
    }
}
