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

            //CityTbl cityToUpdate = cList[0];
            //cityToUpdate.CityName += "aaa";
            //cdb.Update(cityToUpdate);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");



            //DiseaseOrIssuesTblDB ddb = new();
            //DiseaseOrIssuesTblList dList = ddb.SelectAll();
            //foreach (DiseaseOrIssuesTbl d in dList)
            //    Console.WriteLine(d.Disease);

            //DiseaseOrIssuesTbl diseaseToUpdate = dList[0];
            //diseaseToUpdate.Disease += "ddd";
            //ddb.Update(diseaseToUpdate);
            //int y = ddb.SaveChanges();
            //Console.WriteLine($"{y} rows were updated");



            //AnimalTypeTblDB atdb = new();
            //AnimalTypeTblList atList = atdb.SelectAll();
            //foreach (AnimalTypeTbl at in atList)
            //    Console.WriteLine(at.Type);

            //AnimalTypeTbl aTypeToUpdate = atList[0];
            //aTypeToUpdate.Type += "aaa";
            //atdb.Update(aTypeToUpdate);
            //int q = atdb.SaveChanges();
            //Console.WriteLine($"{q} rows were updated");



            //PersonTblDB pdb = new();
            //PersonTblList pList = pdb.SelectAll();
            //foreach (PersonTbl p in pList)
            //{
            //    Console.WriteLine(p.FirstName);
            //}

            //PersonTbl perToUpdate = pList[0];
            //perToUpdate.FirstName += "aa";
            //pdb.Update(perToUpdate);
            //int l = pdb.SaveChanges();
            //Console.WriteLine($"{l} rows were updated");



            AiTblDB aidb = new();
            AiTblList aiList = aidb.SelectAll();
            foreach (AiTbl ai in aiList)
            {
                Console.WriteLine(ai.PromptTime);
            }

            AiTbl aiToUpdate = aiList[0];
            aiToUpdate.FirstName += "aa";
            pdb.Update(perToUpdate);
            int l = pdb.SaveChanges();
            Console.WriteLine($"{l} rows were updated");



            //AnimalTblDB adb = new();
            //AnimalTblList aList = adb.SelectAll();
            //foreach (AnimalTbl a in aList)
            //{
            //    Console.WriteLine(a.BirthDate);
            //}

            //DoctorTblDB ddb = new();
            //DoctorTblList dList = ddb.SelectAll();
            //foreach (DoctorTbl d in dList)
            //{
            //    Console.WriteLine(d.FirstName);
            //}

            //OwnerTblDB odb = new();
            //OwnerTblList oList = odb.SelectAll();
            //foreach (OwnerTbl o in oList)
            //{
            //    Console.WriteLine(o.FirstName);
            //}

            //ReviewTblDB rdb = new();
            //ReviewTblList rList = rdb.SelectAll();
            //foreach (ReviewTbl r in rList)
            //{
            //    Console.WriteLine(r.IdOwner.Id);
            //}

            //OwnersAnimalTblDB oadb = new();
            //OwnersAnimalTblList oaList = oadb.SelectAll();
            //foreach (OwnersAnimalTbl oa in oaList)
            //{
            //    Console.WriteLine(oa.Animal.Id);
            //}

            //QueueTblDB qdb = new();
            //QueueTblList qList = qdb.SelectAll();
            //foreach (QueueTbl q in qList)
            //{
            //    Console.WriteLine(q.QueueDate);
            //}

            //ShiftsTblDB sdb = new();
            //ShiftsTblList sList = sdb.SelectAll();
            //foreach (ShiftsTbl s in sList)
            //{
            //    Console.WriteLine(s.ShiftDate);
            //}



            //עשיתי את השורה עם הליסט רק למי שיש SELECTBYID. זה בסדר??
            //animaltypeDB list?
            //מזה הדבר הזה למעלה בביס דב????????
            // הערה באפדייט בPERSON
        }
    }
}
