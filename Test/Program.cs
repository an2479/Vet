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

            //DiseaseOrIssuesTblDB ddb = new();
            //DiseaseOrIssuesTblList dList = ddb.SelectAll();
            //foreach (DiseaseOrIssuesTbl d in dList)
            //    Console.WriteLine(d.Disease);

            //AnimalTypeTblDB atdb = new();
            //AnimalTypeTblList atList = atdb.SelectAll();
            //foreach (AnimalTypeTbl at in atList)
            //    Console.WriteLine(at.Type);

            //PersonTblDB pdb = new();
            //PersonTblList pList = pdb.SelectAll();
            //foreach (PersonTbl p in pList)
            //{
            //    Console.WriteLine(p.FirstName);
            //    Console.WriteLine(p.City.CityName);
            //}

            AiTblDB adb = new();
            AiTblList aList = adb.SelectAll();
            foreach (AiTbl a in aList)
            {
                Console.WriteLine(a.PromptTime);//
            }

        }
    }
}
