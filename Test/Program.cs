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
            //foreach (CityTbl c in cList)
            //    Console.WriteLine(c.CityName);

            //CityTbl cityToUpdate = cList[0];
            //cityToUpdate.CityName += "kk";
            //cdb.Update(cityToUpdate);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            //CityTbl myCity = new CityTbl() { CityName = "Haifa" };
            //cdb.Insert(myCity);
            //int z = cdb.SaveChanges();
            //Console.WriteLine($"{z} rows inserted");

            //cdb.Delete(cList.Last());
            //int y = cdb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");


            DiseaseOrIssuesTblDB doidb = new();
            DiseaseOrIssuesTblList doiList = doidb.SelectAll();
            //foreach (DiseaseOrIssuesTbl doi in doiList)
            //    Console.WriteLine(doi.Disease);

            //DiseaseOrIssuesTbl diseaseToUpdate = doiList[0];
            //diseaseToUpdate.Disease += "vv";
            //doidb.Update(diseaseToUpdate);
            //int y = doidb.SaveChanges();
            //Console.WriteLine($"{y} rows were updated");
            //DiseaseOrIssuesTbl myD = new DiseaseOrIssuesTbl() { Disease = "fracture" };
            //doidb.Insert(myD);
            //int x = doidb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //foreach (DiseaseOrIssuesTbl doi in doiList)
            //    Console.WriteLine(doi.Disease);

            //doidb.Delete(doiList.Last());
            //int z = doidb.SaveChanges();
            //Console.WriteLine($"{z} rows deleted");



            AnimalTypeTblDB atdb = new();
            AnimalTypeTblList atList = atdb.SelectAll();
            //foreach (AnimalTypeTbl at in atList)
            //    Console.WriteLine(at.Type);

            //AnimalTypeTbl aTypeToUpdate = atList[0];
            //aTypeToUpdate.Type += "vv";
            //atdb.Update(aTypeToUpdate);
            //int q = atdb.SaveChanges();
            //Console.WriteLine($"{q} rows were updated");

            //AnimalTypeTbl myAni = new AnimalTypeTbl() { Type = "snake" };
            //atdb.Insert(myAni);
            //int x = atdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //atdb.Delete(atList.Last());
            //int y = atdb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            PersonTblDB pdb = new();
            PersonTblList pList = pdb.SelectAll();
            foreach (PersonTbl p in pList)
            {
                Console.WriteLine(p.FirstName);
                //Console.WriteLine(p.FamilyName);
                Console.WriteLine(p.City.CityName);
                //Console.WriteLine(p.IsActive);
            }

            //PersonTbl perToUpdate = pList[0];
            //perToUpdate.FirstName += "vv";
            //pdb.Update(perToUpdate);
            //int l = pdb.SaveChanges();
            //Console.WriteLine($"{l} rows were updated");

            //PersonTbl myp = new PersonTbl() { FirstName = "Hadas", FamilyName = "Drori", Tel = "053829666", City = cList[0], Email = "hadas@gmail.com", IsActive = true };
            //pdb.Insert(myp);
            //int x = pdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //pdb.Delete(pList.Last());
            //int y = pdb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            AiTblDB aidb = new();
            AiTblList aiList = aidb.SelectAll();
            //foreach (AiTbl ai in aiList)
            //{
            //    Console.WriteLine(ai.Message);
            //}

            //AiTbl aiToUpdate = aiList[0];
            //aiToUpdate.Message += "vv";
            //aidb.Update(aiToUpdate);
            //int f = aidb.SaveChanges();
            //Console.WriteLine($"{f} rows were updated");

            //AiTbl mya = new AiTbl()
            //{
            //    IdPerson = pList[0],
            //    PromptTime = new DateTime(2026, 1, 12),
            //    Message = "My message",
            //    Response = "My response"
            //};
            //aidb.Insert(mya);
            //int x = aidb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //aidb.Delete(aiList.Last());
            //int y = aidb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            AnimalTblDB adb = new();
            AnimalTblList aList = adb.SelectAll();
            //foreach (AnimalTbl a in aList)
            //{
            //    Console.WriteLine(a.BirthDate);
            //}
            //AnimalTbl aToUpdate = aList[0];
            //aToUpdate.BirthDate = new DateTime(2003, 3, 3);
            //adb.Update(aToUpdate);
            //int p = adb.SaveChanges();
            //Console.WriteLine($"{p} rows were updated");

            //AnimalTbl myan = new AnimalTbl() { AnimalType = atList[1], BirthDate = new DateTime(2025, 1, 1) };
            //adb.Insert(myan);
            //int x = adb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //adb.Delete(aList.Last());
            //int y = adb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            DoctorTblDB ddb = new();
            DoctorTblList dList = ddb.SelectAll();
            //foreach (DoctorTbl d in dList)
            //{
            //    Console.WriteLine(d.FamilyName);
            //}
            //DoctorTbl dToUpdate = dList[0];
            //dToUpdate.FamilyName += "vv";
            //ddb.Update(dToUpdate);
            //int v = ddb.SaveChanges();
            //Console.WriteLine($"{v} rows were updated");

            //DoctorTbl mydoc = new DoctorTbl()
            //{

            //    FirstName = " p.FirstName",
            //    FamilyName = "p.FamilyName",
            //    Tel = "p.Tel",
            //    City = cList[0],
            //    Email = "p.Email"
            //};

            //ddb.Insert(mydoc);
            //int x = ddb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //ddb.Delete(dList.Last());
            //int y = ddb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            OwnerTblDB odb = new();
            OwnerTblList oList = odb.SelectAll();
            //foreach (OwnerTbl o in oList)
            //{
            //    Console.WriteLine(o.FamilyName + " " + o.City.CityName);
            //}

            //OwnerTbl oToUpdate = oList[0];
            //oToUpdate.FamilyName += "vv";
            //odb.Update(oToUpdate);
            //int k = odb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");

            //OwnerTbl myo = new OwnerTbl()
            //{

            //    FirstName = "Elodi",
            //    FamilyName = "Maeev",
            //    Tel = "074918304",
            //    City = cList[1],
            //    Email = "e123@gmail.com",
            //    IsActive = true
            //};

            //odb.Insert(myo);
            //int x = odb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //odb.Delete(oList.Last());
            //int y = odb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            ReviewTblDB rdb = new();
            ReviewTblList rList = rdb.SelectAll();
            //foreach (ReviewTbl r in rList)
            //{
            //    Console.WriteLine(r);
            //}
            //ReviewTbl rToUpdate = rList[0];
            //rToUpdate.Description += "vv";
            //rdb.Update(rToUpdate);
            //int k = rdb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");

            //ReviewTbl myR = new ReviewTbl() { IdOwner = oList[0], Description = "yippie", Stars = 5, DateOfComment = new DateTime(2025, 1, 1) };
            //rdb.Insert(myR);
            //int x = rdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //rdb.Delete(rList.Last());
            //int y = rdb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            OwnersAnimalTblDB oadb = new();
            OwnersAnimalTblList oaList = oadb.SelectAll();
            //foreach (OwnersAnimalTbl oa in oaList)
            //{
            //    Console.WriteLine(oa.Animal.Id);
            //}
            //OwnersAnimalTbl oaToUpdate = oaList[0];
            //oaToUpdate.Animal.Id = 2;
            //oadb.Update(oaToUpdate);
            //int k = oadb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");
            //OwnersAnimalTbl myoa = new OwnersAnimalTbl() { Owner = oList[1], Animal = aList[1] };
            //oadb.Insert(myoa);
            //int x = oadb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //oadb.Delete(oaList.Last());
            //int y = oadb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            QueueTblDB qdb = new();
            QueueTblList qList = qdb.SelectAll();
            //foreach (QueueTbl q in qList)
            //{
            //    Console.WriteLine(q.IssueOrDisease.Id);
            //}
            //QueueTbl qToUpdate = qList[0];
            //qToUpdate.Report += "vv";
            //qdb.Update(qToUpdate);
            //int k = qdb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");

            //QueueTbl myQueue = new QueueTbl()
            //{
            //    IdDoctor = dList[0],
            //    IdOwnersAnimal = oaList[0],
            //    IssueOrDisease = doiList[0],
            //    QueueDate = new DateTime(2026, 7, 7),
            //    QueueHour = "10:30",
            //    Report = "all is well"
            //};
            //qdb.Insert(myQueue);
            //int x = qdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //qdb.Delete(qList.Last());
            //int y = qdb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            ShiftsTblDB sdb = new();
            ShiftsTblList sList = sdb.SelectAll();
            //foreach (ShiftsTbl s in sList)
            //{
            //    Console.WriteLine(s.IdDoctor.Id);
            //}
            //ShiftsTbl sToUpdate = sList[0];
            //sToUpdate.IdDoctor = dList[2];
            //sdb.Update(sToUpdate);
            //int k = sdb.SaveChanges();
            //Console.WriteLine($"{k} rows were updated");
            //ShiftsTbl myShift = new ShiftsTbl()
            //{
            //    IdDoctor = dList[1],
            //    ShiftDate = new DateTime(2024, 4, 4),
            //    StartTime = "08:00",
            //    EndTime = "16:00"
            //};
            //sdb.Insert(myShift);
            //int x = sdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");

            //sdb.Delete(sList.Last());
            //int y = sdb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");



            //עשיתי את השורה עם הליסט רק למי שיש SELECTBYID. זה בסדר??
            //animaltypeDB list?
            //מזה הדבר הזה למעלה בביס דב????????
            // הערה באפדייט בPERSON
            //shift למטה יש הערות
        }
    }
}
