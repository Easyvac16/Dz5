namespace Dz5
{
    class ReadingList
    {
        private List<string> books;

        // Властивість, що повертає кількість книг у списку
        public int Count => books.Count;

        // Індексатор для доступу до елементів списку за індексом
        public string this[int index]
        {
            get => books[index];
            set => books[index] = value;
        }

        // Додавання книги до списку
        public static ReadingList operator +(ReadingList list, string book)
        {
            list.books.Add(book);
            return list;
        }

        // Видалення книги зі списку
        public static ReadingList operator -(ReadingList list, string book)
        {
            list.books.Remove(book);
            return list;
        }

        // Перевірка чи є книга у списку
        public static bool operator ==(ReadingList list, string book)
        {
            return list.books.Contains(book);
        }

        public static bool operator !=(ReadingList list, string book)
        {
            return !list.books.Contains(book);
        }

        // Конструктор класу
        public ReadingList()
        {
            books = new List<string>();
        }

        // Метод для додавання книги до списку
        public void AddBook(string book)
        {
            books.Add(book);
        }

        // Метод для видалення книги зі списку
        public void RemoveBook(string book)
        {
            books.Remove(book);
        }

        // Метод для перевірки чи є книга у списку
        public bool Contains(string book)
        {
            return books.Contains(book);
        }

        public void PrintAllBooks()
        {
            Console.WriteLine("All books:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
        }

    }
    internal class cs3
    {
        public static void task_3()
        {
            ReadingList myList = new ReadingList();

            // Додавання книг до списку
            myList += "The Great Gatsby";
            myList += "To Kill a Mockingbird";
            myList += "Pride and Prejudice";

            // Виведення всіх книг у списку
            myList.PrintAllBooks();

            // Видалення книг зі списку
            myList -= "To Kill a Mockingbird";
            myList.PrintAllBooks();

            // Перевірка чи є книга у списку
            if (myList == "The Great Gatsby")
            {
                Console.WriteLine("The Great Gatsby is in the reading list.");
            }
            else
            {
                Console.WriteLine("The Great Gatsby is not in the reading list.");
            }

            // Виведення кількості книг у списку
            Console.WriteLine($"There are {myList.Count} books in the reading list.");

            
        }
    }
}
