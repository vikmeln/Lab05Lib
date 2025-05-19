namespace Lab05Lib
{
    public class ClassesLib
    {
        public string Title;
        public string Author;
        public string Publisher;
        public int Year;
        public int Pages;
        public double Price;
        public bool IsHardcover;

        // Додаткова властивість — ціна за одну сторінку
        public double PricePerPage
        {
            get { return GetPricePerPage(); }
        }

        public double GetPricePerPage()
        {
            return Price / Pages;
        }
    }
}
