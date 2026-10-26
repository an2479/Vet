using Model;
using ModelView;
using System.Net.Sockets;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CityTblDB cdb = new();
            CityTblList cList = cdb.SelectAll();
            foreach (CityTbl c in cList)
                Console.WriteLine(c.CityName);

            //CityTbl cityToUpdate = cList[0];
            //cityToUpdate.CityName += "aa";
            //cdb.Update(cityToUpdate);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");
            ////
            CityTbl myCity = new CityTbl() { CityName = "Haifa" };
            cdb.Insert(myCity);
            int x = cdb.SaveChanges();
            Console.WriteLine($"{x} rows inserted");


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
            //    Console.WriteLine(p.FamilyName);
            //}

            //PersonTbl perToUpdate = pList[0];
            //perToUpdate.FirstName += "aa";
            //pdb.Update(perToUpdate);
            //int l = pdb.SaveChanges();
            //Console.WriteLine($"{l} rows were updated");



            //AiTblDB aidb = new();
            //AiTblList aiList = aidb.SelectAll();
            //foreach (AiTbl ai in aiList)
            //{
            //    Console.WriteLine(ai.Message);
            //}

            //AiTbl aiToUpdate = aiList[0];
            //aiToUpdate.Message += "aa";
            //aidb.Update(aiToUpdate);
            //int f = aidb.SaveChanges();
            //Console.WriteLine($"{f} rows were updated");



            //AnimalTblDB adb = new();
            //AnimalTblList aList = adb.SelectAll();
            //foreach (AnimalTbl a in aList)
            //{
            //    Console.WriteLine(a.BirthDate);
            //}
            //AnimalTbl aToUpdate = aList[0];
            //aToUpdate.BirthDate = new DateTime(2001, 1, 1);
            //adb.Update(aToUpdate);
            //int p = adb.SaveChanges();
            //Console.WriteLine($"{p} rows were updated");

            //foreach (AnimalTbl a in aList)
            //{
            //    Console.WriteLine(a.BirthDate);
            //}


            //Console.WriteLine("----------");
            //DoctorTblDB ddb = new();
            //DoctorTblList dList = ddb.SelectAll();
            //foreach (DoctorTbl d in dList)
            //{
            //    Console.WriteLine(d.FirstName);
            //}
            //DoctorTbl dToUpdate = dList[0];
            //dToUpdate.FamilyName += "aa";
            //ddb.Update(dToUpdate);
            //int v = ddb.SaveChanges();
            //Console.WriteLine($"{v} rows were updated");
            //foreach (DoctorTbl d in dList)
            //{
            //    Console.WriteLine(d.FamilyName);
            //}



            //Console.WriteLine("Owener:)");
            //OwnerTblDB odb = new();
            //OwnerTblList oList = odb.SelectAll();
            //foreach (OwnerTbl o in oList)
            //{
            //    Console.WriteLine(o.FamilyName + " " + o.City.CityName);
            //}

            //OwnerTbl oToUpdate = oList[0];
            //oToUpdate.FamilyName += "aa";
            //odb.Update(oToUpdate);
            //int k = odb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");



            //ReviewTblDB rdb = new();
            //ReviewTblList rList = rdb.SelectAll();
            //foreach (ReviewTbl r in rList)
            //{
            //    Console.WriteLine(r);
            //}
            //ReviewTbl rToUpdate = rList[0];
            //rToUpdate.Description += "bb";
            //rdb.Update(rToUpdate);
            //int k = rdb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");

            //OwnersAnimalTblDB oadb = new();
            //OwnersAnimalTblList oaList = oadb.SelectAll();
            //foreach (OwnersAnimalTbl oa in oaList)
            //{
            //    Console.WriteLine(oa.Animal.Id);
            //}
            //OwnersAnimalTbl oaToUpdate = oaList[0];
            //oaToUpdate.Animal.Id = 1;
            //oadb.Update(oaToUpdate);
            //int k = oadb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");



            //QueueTblDB qdb = new();
            //QueueTblList qList = qdb.SelectAll();
            //foreach (QueueTbl q in qList)
            //{
            //    Console.WriteLine(q.Report);
            //}
            //QueueTbl qToUpdate = qList[0];
            //qToUpdate.Report += "aa";
            //qdb.Update(qToUpdate);
            //int k = qdb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");



            //ShiftsTblDB sdb = new();
            //ShiftsTblList sList = sdb.SelectAll();
            //foreach (ShiftsTbl s in sList)
            //{
            //    Console.WriteLine(s.IdDoctor.Id);
            //}
            //ShiftsTbl sToUpdate = sList[0];
            //sToUpdate.IdDoctor.Id = 5;
            //sdb.Update(sToUpdate);
            //int k = sdb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");


            //עשיתי את השורה עם הליסט רק למי שיש SELECTBYID. זה בסדר??
            //animaltypeDB list?
            //מזה הדבר הזה למעלה בביס דב????????
            // הערה באפדייט בPERSON
            //shift למטה יש הערות
        }
    }
}
