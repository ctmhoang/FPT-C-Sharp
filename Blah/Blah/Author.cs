using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Blah
{
    internal class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; private set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Books.Count}";
        }

        public void AddBooks(Book book)
        {
            Books.Add(book);
        }
    }

    internal class Book
    {
        public string Code { get; set; }

        public string Title { get; set; }

        public ushort Year { get; set; }

        public override string ToString()
        {
            return $"{Code} {Title} {Year}";
        }

        protected bool Equals(Book other)
        {
            return Code == other.Code && Title == other.Title && Year == other.Year;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Book) obj);
        }


        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Code != null ? Code.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Title != null ? Title.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Year.GetHashCode();
                return hashCode;
            }
        }
    }

    internal class Test
    {
        public static void Main()
        {
            var authorData = new List<Author>(5);
            var bookSet = new HashSet<Book>();
            try
            {
                Console.WriteLine("Reading from data.txt ...");
                using (var reader = File.OpenText("data.txt"))
                {
                    if (new StringInfo(reader.ReadToEnd()).LengthInTextElements == 0)
                        throw new InvalidDataException("There are no data in this file");

                    reader.BaseStream.Position = 0;
                    reader.DiscardBufferedData();

                    var rawData = reader.ReadLine();

                    while (!string.IsNullOrEmpty(rawData))
                    {
                        var data = rawData.Split('/');
                        if (data.Length != 2) throw new InvalidDataException("Data not in expected format");
                        var author = new Author {Id = data[0], Name = data[1]};
                        authorData.Add(author);

                        while (!string.IsNullOrEmpty(rawData = reader.ReadLine()) &&
                               (data = rawData.Split('/')).Length == 3)
                        {
                            var book = new Book {Code = data[0], Title = data[1], Year = Convert.ToUInt16(data[2])};
                            author.AddBooks(book);
                            bookSet.Add(book);
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.Error.WriteLine("CANNOT FOUND FILE " + e.Message);
                Environment.Exit(100);
            }
            catch (InvalidDataException e)
            {
                Console.Error.WriteLine("PROVIDED DATA FILE CONTAINS INVALID FORM OF DATA " + e.Message);
                Environment.Exit(200);
            }
            catch (Exception e) when (e is FormatException || e is OverflowException)
            {
                Console.Error.WriteLine("YEAR NUMBER FORMAT IS ILLEGAL " + e.Message);
                Environment.Exit(300);
            }

            Console.WriteLine("Imported Authors are");
            foreach (var author in authorData)
            {
                Console.WriteLine(author);
                author.Books.ForEach(Console.WriteLine);
            }

            Console.WriteLine("Imported Books are");
            foreach (var book in bookSet)
            {
                Console.WriteLine(book);
                List<Author> tmp = authorData.FindAll(a => a.Books.Contains(book));
                Console.WriteLine($"Has total {tmp.Count} authors such as: ");
                tmp.ForEach(Console.WriteLine);
            }
        }
    }
}