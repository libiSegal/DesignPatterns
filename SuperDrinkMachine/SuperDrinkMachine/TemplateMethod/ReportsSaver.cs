
namespace SuperDrinkMachine.TemplateMethod;
public abstract class ReportsSaver
{   
        protected static string Report = "";
        public static void AddReport(string item)
        {
            Report += $"item: {item}.\n";       
        }
        public static void WriteReport() { }


}

