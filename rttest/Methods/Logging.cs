namespace retour.Methods
{
    public class Logging
    {
        public string path = "C:\\Users\\Слава\\source\\repos\\rttest\\rttest\\Methods\\logs\\latest.log";

        public Logging()
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path)))
            {
                outputFile.WriteLine(""); // очистка логов
            }
        }


        public void Log(string Type, string Module, string Text) 
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path), true))
            {
                outputFile.WriteLine($"[{Type}:{Module} : {DateTime.Now.ToString("h:mm:ss.fff tt")}]: {Text}");
            }
        }
    }
}
