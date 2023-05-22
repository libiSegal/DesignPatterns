
using System.Text;

namespace SuperDrinkMachine.TemplateMethod;
public   class ReportTxtSaver : ReportsSaver
{
    static string PATH = "..\\..\\..\\report.txt";
    public static void WriteReport()
    {
        File.AppendAllText(PATH, $"\n\t{DateTime.Now}\n");
        File.AppendAllText(PATH, Report);
    }
}

