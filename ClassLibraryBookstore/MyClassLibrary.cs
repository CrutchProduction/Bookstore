using lab3Lib;

namespace ClassLibraryBookstore
{
    public class MyClassLibrary
    {
        // Конструктор
        public MyClassLibrary() {
        }

        // Проверка текст на число
        public static bool isNumber(string text)
        {
            try
            {
                Convert.ToInt32(text);
                return true;
            }
            catch { return false; }
        }
    }
}
