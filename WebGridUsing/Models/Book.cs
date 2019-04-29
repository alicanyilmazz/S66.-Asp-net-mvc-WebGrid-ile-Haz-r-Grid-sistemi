using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGridUsing.Models
{
    public class Book
    {
        public static List<Book> _books { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublishingDate { get; set; }
        public decimal price { get; set; }

        protected Book()
        {

        }
        
        public static  void GenerateFakeData(int count)
        {
            if(_books==null)
            {
                _books = GetFakeData(count);
            }
        }

        private static List<Book> GetFakeData(int count)
        {
            List<Book> _book_list = new List<Book>();

            for (int i = 0; i < count; i++)
            {
                _book_list.Add(new Book()
                {
                    Id = Guid.NewGuid(),
                    Name = FakeData.NameData.GetCompanyName(),
                    Author = FakeData.NameData.GetFullName(),
                    price = FakeData.NumberData.GetNumber(10, 75),
                    PublishingDate = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(2), DateTime.Now)

                });
            }

            return _book_list;
        }
    }
}