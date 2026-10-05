using Model;
using ModelView;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CityTblDB cdb = new();
            //CityTblList cList = cdb.SelectAll();
            //foreach (CityTbl c in cList)
            //    Console.WriteLine(c.CityName);

            DiseaseOrIssuesTblDB ddb = new();
            DiseaseOrIssuesTblList dList = ddb.SelectAll();
            foreach (DiseaseOrIssuesTbl d in dList)
                Console.WriteLine(d.Disease);

        }
    }
}
