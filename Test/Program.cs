using Model;
using ModelView;
using System.Net.Sockets;

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
            //cityToUpdate.CityName += "aa";
            //cdb.Update(cityToUpdate);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");
            //////
            //CityTbl myCity = new CityTbl() { CityName = "Haifa" };
            //cdb.Insert(myCity);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");


            //DiseaseOrIssuesTblDB ddb = new();
            //DiseaseOrIssuesTblList dList = ddb.SelectAll();
            //foreach (DiseaseOrIssuesTbl d in dList)
            //    Console.WriteLine(d.Disease);

            //DiseaseOrIssuesTbl diseaseToUpdate = dList[10];
            //diseaseToUpdate.Disease += "ddd";
            //ddb.Update(diseaseToUpdate);
            //int y = ddb.SaveChanges();
            //Console.WriteLine($"{y} rows were updated");
            //DiseaseOrIssuesTbl myD = new DiseaseOrIssuesTbl() { Disease = "Fracture" };
            //ddb.Insert(myD);
            //int x = ddb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //foreach (DiseaseOrIssuesTbl d in dList)
            //    Console.WriteLine(d.Disease);



            //AnimalTypeTblDB atdb = new();
            //AnimalTypeTblList atList = atdb.SelectAll();
            //foreach (AnimalTypeTbl at in atList)
            //    Console.WriteLine(at.Type);

            //AnimalTypeTbl aTypeToUpdate = atList[0];
            //aTypeToUpdate.Type += "aaa";
            //atdb.Update(aTypeToUpdate);
            //int q = atdb.SaveChanges();
            //Console.WriteLine($"{q} rows were updated");

            //AnimalTypeTbl myAni = new AnimalTypeTbl() { Type = "snake" };
            //atdb.Insert(myAni);
            //int x = atdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");



            //PersonTblDB pdb = new();
            //PersonTblList pList = pdb.SelectAll();
            //foreach (PersonTbl p in pList)
            //{
            //    Console.WriteLine(p.FirstName);
            //    Console.WriteLine(p.FamilyName);
            //    Console.WriteLine(p.City.CityName);
            //}

            //PersonTbl perToUpdate = pList[0];
            //perToUpdate.FirstName += "aa";
            //pdb.Update(perToUpdate);
            //int l = pdb.SaveChanges();
            //Console.WriteLine($"{l} rows were updated");

            //PersonTbl myp = new PersonTbl() { FirstName = "Hadas", FamilyName = "Drori", Tel = "053829666", City = new CityTbl() { Id = 1 }, Email = "hadas@gmail.com" };
            //pdb.Insert(myp);
            //int x = pdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");



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

            //AiTbl mya = new AiTbl()
            //{
            //    IdPerson = new PersonTbl() { Id = 1 },////כעקרון היה צריך לעשות עם CITYLIST ולקחת ערך!! אבל בשביל הבדיקה זה בסדר
            //    PromptTime = new DateTime(2026, 1, 12),
            //    Message = "My message",
            //    Response = "My response"
            //};
            //aidb.Insert(mya);
            //int x = aidb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");



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

            //AnimalTbl myan = new AnimalTbl() { AnimalType = new AnimalTypeTbl() { Id = 1 }, BirthDate = new DateTime(2025, 1, 1) };
            //adb.Insert(myan);
            //int x = adb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");



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

            //DoctorTbl mydoc = new DoctorTbl()
            //{

            //    FirstName =" p.FirstName",
            //    FamilyName = "p.FamilyName",
            //    Tel = "p.Tel",
            //    City = new CityTbl() { Id=2},
            //    Email = "p.Email"
            //};

            //ddb.Insert(mydoc);
            //int x = ddb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");



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

            //OwnerTbl myo = new OwnerTbl()
            //{

            //    FirstName = "Elodi",
            //    FamilyName = "Maeev",
            //    Tel = "074918304",
            //    City = new CityTbl() { Id = 2 },
            //    Email = "e123@gmail.com"
            //};

            //odb.Insert(myo);
            //int x = odb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");



            ReviewTblDB rdb = new();
            ReviewTblList rList = rdb.SelectAll();
            foreach (ReviewTbl r in rList)
            {
                Console.WriteLine(r);
            }
            //ReviewTbl rToUpdate = rList[0];
            //rToUpdate.Description += "bb";
            //rdb.Update(rToUpdate);
            //int k = rdb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");
            
            //AiTbl mya = new AiTbl()
            //{
            //    IdPerson = new PersonTbl() { Id = 1 },////כעקרון היה צריך לעשות עם CITYLIST ולקחת ערך!! אבל בשביל הבדיקה זה בסדר
            //    PromptTime = new DateTime(2026, 1, 12),
            //    Message = "My message",
            //    Response = "My response"
            //};
            //aidb.Insert(mya);
            //int x = aidb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");



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

            //DOC INSERT CHECK!!!!!!!!!!!!!
            //עשיתי את השורה עם הליסט רק למי שיש SELECTBYID. זה בסדר??
            //animaltypeDB list?
            //מזה הדבר הזה למעלה בביס דב????????
            // הערה באפדייט בPERSON
            //shift למטה יש הערות
        }
    }
}
