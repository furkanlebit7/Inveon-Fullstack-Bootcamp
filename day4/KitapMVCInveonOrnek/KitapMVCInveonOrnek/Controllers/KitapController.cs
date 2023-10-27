using KitapMVCInveonOrnek.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace KitapMVCInveonOrnek.Controllers
{
    public class KitapController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Kitap> kitapListesi = new List<Kitap>();
            using (var httpClient =  new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7062/api/Kitap"))
                {
                    string gelenString = await response.Content.ReadAsStringAsync();
                   kitapListesi =  JsonConvert.DeserializeObject<List<Kitap>>(gelenString);
                }
            }
            return View(kitapListesi);
        }

        public async Task<IActionResult> KitapDetay(int id)
        {

            Kitap kitap;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7062/api/Kitap/"+id))
                {
                    string gelenString = await response.Content.ReadAsStringAsync();
                    kitap = JsonConvert.DeserializeObject<Kitap>(gelenString);
                }
            }
            return View(kitap);
        }

        public async Task<IActionResult> KitapEkle(Kitap kitap)
        {

            using (var httpClient = new HttpClient())
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(kitap), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:7062/api/Kitap/" , jsonContent))
                {
                    string gelenString = await response.Content.ReadAsStringAsync();
                    kitap = JsonConvert.DeserializeObject<Kitap>(gelenString);
                }
            }
            return View();
        }

        public async Task<IActionResult> KitapSil(int id)
        {

            Kitap kitap;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:7062/api/Kitap/" + id))
                {
                    string gelenString = await response.Content.ReadAsStringAsync();
                    kitap = JsonConvert.DeserializeObject<Kitap>(gelenString);
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> KitapGuncelle(Kitap kitap)
        {

            using (var httpClient = new HttpClient())
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(kitap), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:7062/api/Kitap/" , jsonContent))
                {
                    string gelenString = await response.Content.ReadAsStringAsync();
                    kitap = JsonConvert.DeserializeObject<Kitap>(gelenString);
                }
            }
            return View();
        }




    }
}
