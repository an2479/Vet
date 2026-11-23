using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ApiInterface
{
    public class Apiservice : InterA
    {
        string uri;
        public HttpClient client;
        public Apiservice()
        {
            uri = "http://localhost:5054";
            client = new HttpClient();
        }

        public async Task<CityTblList> GetAllCities()
        {
            return await client.GetFromJsonAsync<CityTblList>( uri + "/api/values/SelectAllCities/");
        }

        public async Task<AnimalTypeTblList> GetAllAnimalTypes()
        {
            return await client.GetFromJsonAsync<AnimalTypeTblList>( uri + "/api/values/SelectAllAnimalTypes/");
        }

        public async Task<DiseaseOrIssuesTblList> GetAllDiseaseOrIssues()
        {
            return await client.GetFromJsonAsync<DiseaseOrIssuesTblList>( uri + "/api/values/SelectAllDiseaseOrIssuess/");
        }

        public async Task<PersonTblList> GetAllPersons()
        {
            return await client.GetFromJsonAsync<PersonTblList>( uri + "/api/values/SelectAllPersons/");
        }

        public async Task<AiTblList> GetAllAi()
        {
            return await client.GetFromJsonAsync<AiTblList>( uri + "/api/values/SelectAllAi/");
        }

        public async Task<ReviewTblList> GetAllReviews()
        {
            return await client.GetFromJsonAsync<ReviewTblList>( uri + "/api/values/SelectAllReviews/");
        }

        public async Task<OwnersAnimalTblList> GetAllOwnersAnimals()
        {
            return await client.GetFromJsonAsync<OwnersAnimalTblList>( uri + "/api/values/SelectAllOwnersAnimals/");
        }

        public async Task<QueueTblList> GetAllQueues()
        {
            return await client.GetFromJsonAsync<QueueTblList>( uri + "/api/values/SelectAllQueues/");
        }

        public async Task<ShiftsTblList> GetAllShifts()
        {
            return await client.GetFromJsonAsync<ShiftsTblList>( uri + "/api/values/SelectAllShifts/");
        }

        public async Task<AnimalTblList> GetAllAnimals()
        {
            return await client.GetFromJsonAsync<AnimalTblList>( uri + "/api/values/SelectAllAnimals/");
        }

        public async Task<OwnerTblList> GetAllOwners()
        {
            return await client.GetFromJsonAsync<OwnerTblList>( uri + "/api/values/SelectAllOwners/");
        }

        public async Task<DoctorTblList> GetAllDoctors()
        {
            return await client.GetFromJsonAsync<DoctorTblList>( uri + "/api/values/SelectAllDoctors/");
        }



        public async Task<int> InsertACity(CityTbl c)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertACity/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAnAnimalType(AnimalTypeTbl at)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertAnAnimalType/", at)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertADiseaseOrIssues(DiseaseOrIssuesTbl d)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertADiseaseOrIssues/", d)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPerson(PersonTbl p)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertAPerson/", p)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAnAi(AiTbl ai)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertAnAi/", ai)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAReview(ReviewTbl r)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertAReview/", r)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAnOwnersAnimal(OwnersAnimalTbl oa)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertAnOwnersAnimal/", oa)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAQueue(QueueTbl q)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertAQueue/", q)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAShift(ShiftsTbl s)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertAShift/", s)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAnAnimal(AnimalTbl a)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertAnAnimal/", a)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAnOwner(OwnerTbl o)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertAnOwner/", o)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertADoctor(DoctorTbl d)
        {
            return (await client.PostAsJsonAsync( uri + "/api/values/InsertADoctor/", d)).IsSuccessStatusCode ? 1 : 0;
        }



        public async Task<int> UpdateACity(CityTbl c)
        {
            return (await client.PutAsJsonAsync<CityTbl>( uri + "/api/values/UpdateACity/", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAnAnimalType(AnimalTypeTbl at)
        {
            return (await client.PutAsJsonAsync<AnimalTypeTbl>( uri + "/api/values/UpdateAnAnimalType/", at)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateADiseaseOrIssues(DiseaseOrIssuesTbl d)
        {
            return (await client.PutAsJsonAsync<DiseaseOrIssuesTbl>( uri + "/api/values/UpdateADiseaseOrIssues/", d)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAPerson(PersonTbl p)
        {
            return (await client.PutAsJsonAsync<PersonTbl>( uri + "/api/values/UpdateAPerson/", p)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAnAi(AiTbl ai)
        {
            return (await client.PutAsJsonAsync<AiTbl>( uri + "/api/values/UpdateAnAi/", ai)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAReview(ReviewTbl r)
        {
            return (await client.PutAsJsonAsync<ReviewTbl>( uri + "/api/values/UpdateAReview/", r)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAnOwnersAnimal(OwnersAnimalTbl oa)
        {
            return (await client.PutAsJsonAsync<OwnersAnimalTbl>( uri + "/api/values/UpdateAnOwnersAnimal/", oa)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAQueue(QueueTbl q)
        {
            return (await client.PutAsJsonAsync<QueueTbl>( uri + "/api/values/UpdateAQueue/", q)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAShift(ShiftsTbl s)
        {
            return (await client.PutAsJsonAsync<ShiftsTbl>( uri + "/api/values/UpdateAShift/", s)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAnAnimal(AnimalTbl a)
        {
            return (await client.PutAsJsonAsync<AnimalTbl>( uri + "/api/values/UpdateAnAnimal/", a)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAnOwner(OwnerTbl o)
        {
            return (await client.PutAsJsonAsync<OwnerTbl>( uri + "/api/values/UpdateAnOwner/", o)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateADoctor(DoctorTbl d)
        {
            return (await client.PutAsJsonAsync<DoctorTbl>( uri + "/api/values/UpdateADoctor/", d)).IsSuccessStatusCode ? 1 : 0;
        }



        public async Task<int> DeleteACity(int id)
        {
            return (await client.DeleteAsync( uri + "/api/values/DeleteACity/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAnAnimalType(int id)
        {
            return (await client.DeleteAsync( uri + "/api/values/DeleteAnAnimalType/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteADiseaseOrIssues(int id)
        {
            return (await client.DeleteAsync( uri + "/api/values/DeleteADiseaseOrIssues/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAPerson(int id)
        {
            return (await client.DeleteAsync(  uri + "/api/values/DeleteAPerson/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAnAi(int id)
        {
            return (await client.DeleteAsync( uri + "/api/values/DeleteAnAi/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAReview(int id)
        {
            return (await client.DeleteAsync( uri + "/api/values/DeleteAReview/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAnOwnersAnimal(int id)
        {
            return (await client.DeleteAsync(  uri + "/api/values/DeleteAnOwnersAnimal/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAQueue(int id)
        {
            return (await client.DeleteAsync( uri + "/api/values/DeleteAQueue/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAShift(int id)
        {
            return (await client.DeleteAsync( uri + "/api/values/DeleteAShift/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAnAnimal(int id)
        {
            return (await client.DeleteAsync( uri + "/api/values/DeleteAnAnimal/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAnOwner(int id)
        {
            return (await client.DeleteAsync(  uri + "/api/values/DeleteAnOwner/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteADoctor(int id)
        {
            return (await client.DeleteAsync( uri + "/api/values/DeleteADoctor/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
    }
}

