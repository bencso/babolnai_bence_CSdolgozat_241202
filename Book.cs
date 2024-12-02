namespace babolnai_bence_dolgozat_241202
{
    internal class Book
    {
        private long iSBN;
        private string title;
        private int year;
        private string language;
        private int stock;
        private int price;

        public long ISBN
        {
            get => iSBN;
            private set
            {
                iSBN = value;
            }
        }
        public List<Author> Authors { get; private set; }
        public string Title
        {
            get => title; private set
            {
                if (value.Length < 3 && value.Length > 64) throw new Exception("A cím hossza 3nál nagyobb, de 64nél kevesebbnek kell lennie");
                title = value;
            }
        }
        public int Year
        {
            get => year; private set
            {
                if (value < 2007 && value > DateTime.Now.Year) throw new Exception("A könyv kiadási éve 2007 és "
                    + DateTime.Now.Year + " között kell lennie!");
                year = value;
            }
        }
        public string Language
        {
            get => language; private set
            {
                if (value.ToLower() != "német" &&
                    value.ToLower() != "magyar" &&
                    value.ToLower() != "angol") throw new Exception("A könyv nyelve csak " +
                        "magyar/német/angol lehet!");
                language = value;
            }
        }
        public int Stock
        {
            get => stock; set
            {
                if (value < 0) throw new Exception("A készletnek nagyobbnak kell lenniemint 0");
                stock = value;
            }
        }
        public int Price
        {
            get => price; private set
            {
                if(value < 1000 && price > 10000 && value % 100 != 0) throw new Exception("Az árnak 1000 és 10000 között kell lennie, és kerek 100as szám!") ;
                price = value;
            }
        }

        public Book(string title, Author szerzo)
        {
            ISBN = Random.Shared.NextInt64(1000000000,9999999999);
            Title = title;
            Language = "magyar";
            Price = 4500;
            Year = 2024;
            Stock = 0;
            Authors = new List<Author>().ToList();
        }

        public Book(long isbn, string title, int stock, string language, int price, int year,
        params Author[] szerzok) {
            {
                ISBN = isbn;
                Title = title;
                Language = language;
                Price = price;
                Year = year;
                Stock = stock;
                Authors = szerzok.ToList();
            }
        }

        public override string ToString()
        {
            string szoveg = $"ISBN: {ISBN}" +
                $"\nCím: {Title}" +
                $"\nNyelv: {Language}" +
                $"\nKiadás éve: {Year}" +
                $"\nÁr: {price}";
            if (Authors.Count > 1) szoveg += $"\nSzerzők: {Authors.Count} db";
            else szoveg += $"\nSzerző: {Authors.Count} db";
            if (Stock > 0) szoveg += $"\nKészlet: {Stock} db";
            else szoveg += "\nKészlet: beszerzés alatt";
            return szoveg;
        }
    }
}
