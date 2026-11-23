using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ModelView;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public CityTblList SelectAllCities()
        {
            CityTblDB db = new CityTblDB();
            CityTblList c = db.SelectAll();
            return c;
        }

        [HttpGet]
        public AnimalTypeTblList SelectAllAnimalTypes()
        {
            AnimalTypeTblDB db = new AnimalTypeTblDB();
            AnimalTypeTblList at = db.SelectAll();
            return at;
        }

        [HttpGet]
        public DiseaseOrIssuesTblList SelectAllDiseaseOrIssuess()
        {
            DiseaseOrIssuesTblDB db = new DiseaseOrIssuesTblDB();
            DiseaseOrIssuesTblList doi = db.SelectAll();
            return doi;
        }

        [HttpGet]
        public PersonTblList SelectAllPersons()
        {
            PersonTblDB db = new PersonTblDB();
            PersonTblList p = db.SelectAll();
            return p;
        }

        [HttpGet]
        public AiTblList SelectAllAi()
        {
            AiTblDB db = new AiTblDB();
            AiTblList ai = db.SelectAll();
            return ai;
        }

        [HttpGet]
        public ReviewTblList SelectAllReviews()
        {
            ReviewTblDB db = new ReviewTblDB();
            ReviewTblList r = db.SelectAll();
            return r;
        }

        [HttpGet]
        public OwnersAnimalTblList SelectAllOwnersAnimals()
        {
            OwnersAnimalTblDB db = new OwnersAnimalTblDB();
            OwnersAnimalTblList oA = db.SelectAll();
            return oA;
        }

        [HttpGet]
        public QueueTblList SelectAllQueues()
        {
            QueueTblDB db = new QueueTblDB();
            QueueTblList q = db.SelectAll();
            return q;
        }

        [HttpGet]
        public ShiftsTblList SelectAllShifts()
        {
            ShiftsTblDB db = new ShiftsTblDB();
            ShiftsTblList s = db.SelectAll();
            return s;
        }

        [HttpGet]
        public AnimalTblList SelectAllAnimals()
        {
            AnimalTblDB db = new AnimalTblDB();
            AnimalTblList an = db.SelectAll();
            return an;
        }

        [HttpGet]
        public OwnerTblList SelectAllOwners()
        {
            OwnerTblDB db = new OwnerTblDB();
            OwnerTblList o = db.SelectAll();
            return o;
        }

        [HttpGet]
        public DoctorTblList SelectAllDoctors()
        {
            DoctorTblDB db = new DoctorTblDB();
            DoctorTblList d = db.SelectAll();
            return d;
        }

        [HttpPost]
        public int InsertACity([FromBody] CityTbl city)
        {
            CityTblDB db = new CityTblDB();
            db.Insert(city);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAnAnimalType([FromBody] AnimalTypeTbl at)
        {
            AnimalTypeTblDB db = new AnimalTypeTblDB();
            db.Insert(at);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertADiseaseOrIssues([FromBody] DiseaseOrIssuesTbl at)
        {
            DiseaseOrIssuesTblDB db = new DiseaseOrIssuesTblDB();
            db.Insert(at);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAPerson([FromBody] PersonTbl person)
        {
            PersonTblDB db = new PersonTblDB();
            db.Insert(person);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAnAi([FromBody] AiTbl ai)
        {
            AiTblDB db = new AiTblDB();
            db.Insert(ai);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAReview([FromBody] ReviewTbl review)
        {
            ReviewTblDB db = new ReviewTblDB();
            db.Insert(review);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAnOwnersAnimal([FromBody] OwnersAnimalTbl ownersA)
        {
            OwnersAnimalTblDB db = new OwnersAnimalTblDB();
            db.Insert(ownersA);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAQueue([FromBody] QueueTbl queue)
        {
            QueueTblDB db = new QueueTblDB();
            db.Insert(queue);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAShift([FromBody] ShiftsTbl shift)
        {
            ShiftsTblDB db = new ShiftsTblDB();
            db.Insert(shift);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAnAnimal([FromBody] AnimalTbl animal)
        {
            AnimalTblDB db = new AnimalTblDB();
            db.Insert(animal);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAnOwner([FromBody] OwnerTbl owner)
        {
            OwnerTblDB db = new OwnerTblDB();
            db.Insert(owner);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertADoctor([FromBody] DoctorTbl doc)
        {
            DoctorTblDB db = new DoctorTblDB();
            db.Insert(doc);
            int x = db.SaveChanges();
            return x;
        }

        [HttpDelete("{x}")]
        public int DeleteACity(int x)
        {
            CityTblDB db = new CityTblDB();
            db.Delete(new CityTbl() { Id = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAnAnimalType(int x)
        {
            AnimalTypeTblDB db = new AnimalTypeTblDB();
            db.Delete(new AnimalTbl() { Id = x});
            int y = db.SaveChanges();
            return y;
        }
 
        [HttpDelete("{x}")]
        public int DeleteADiseaseOrIssues(int x)
        {
            DiseaseOrIssuesTblDB db = new DiseaseOrIssuesTblDB();
            db.Delete(new DiseaseOrIssuesTbl() { Id = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAPerson(int x)
        {
            PersonTblDB db = new PersonTblDB();
            PersonTbl p = db.SelectAll().Find(z => z.Id == x);
            db.Delete(p);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAnAi(int x)
        {
            AiTblDB db = new AiTblDB();
            db.Delete(new AiTbl() { Id = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAReview(int x)
        {
            ReviewTblDB db = new ReviewTblDB();
            db.Delete(new ReviewTbl() { Id = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAnOwnersAnimal(int x)
        {
            OwnersAnimalTblDB db = new OwnersAnimalTblDB();
            db.Delete(new OwnersAnimalTbl() { Id = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAQueue(int x)
        {
            QueueTblDB db = new QueueTblDB();
            db.Delete(new QueueTbl() { Id = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAShift(int x)
        {
            ShiftsTblDB db = new ShiftsTblDB();
            db.Delete(new ShiftsTbl() { Id = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAnAnimal(int x)
        {
            AnimalTblDB db = new AnimalTblDB();
            db.Delete(new AnimalTbl() { Id = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAnOwner(int x)
        {
            OwnerTblDB db = new OwnerTblDB();
            OwnerTbl o = db.SelectAll().Find(z => z.Id == x);
            db.Delete(o);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteADoctor(int x)
        {
            DoctorTblDB db = new DoctorTblDB();
            DoctorTbl d = db.SelectAll().Find(z => z.Id == x);
            db.Delete(d);
            int y = db.SaveChanges();
            return y;
        }
    }
}
