namespace InspectorLib
{
    public class FunctionInsp
    {
        // создание списка представленого организацией
        private static string AutoInspect = "Автоинспекция г. Чита";
        private static string GlavnInspector = "Васильев В.И.";
        private static List<string> sotrudnic = new List<string>(){"Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И."};
        
        // создание методов строго по ТЗ
        public static string GetInspector() => GlavnInspector;

        public static string GetCarInspection() => AutoInspect;

        public static bool SetInspector(string fullname)
        {
            if (sotrudnic.Contains(fullname))
            {
                GlavnInspector = fullname;
                return true;
            }
            return false;
        }

        public static string GenerateNumber(string symbol, int code = 75)
        {
            Random number_rand= new Random();
            int number = number_rand.Next(1000, 10000);
            return $"{symbol.ToUpper()}{number}_{code}";
        }

        public static List<string> GetWorkers() => sotrudnic;

        public static bool AddWorker(string fullname)
        {
            if (!sotrudnic.Contains(fullname))
            {
                sotrudnic.Add(fullname);
                return true;
            }
            return false;
        }
    }

}
