using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webServisUygulamaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            urunWebServis.guvenlik webServisGuvenlik = new urunWebServis.guvenlik();
            webServisGuvenlik.privateValue = rnd.Next(0, int.MaxValue);
            webServisGuvenlik.tokenTime = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
            webServisGuvenlik.clientKey = "66841EB5-A583-4AFF-9FB3-00D935D7870A" + webServisGuvenlik.privateValue.ToString() + webServisGuvenlik.tokenTime;
            webServisGuvenlik.clientKey = SHA.SHA256Olustur(webServisGuvenlik.clientKey);
            urunWebServis.urunServis _webServis = new urunWebServis.urunServis();
            urunWebServis.outputType returnType =  _webServis.urunKayitYeni(new urunWebServis.urun() 
            {                
                tanim = "Telefon",
                aciklama = "Akıllı Telefon",
                stokAdet = 100,
                urunKimlik = "abcdefg"
            },webServisGuvenlik);
            Console.ReadLine();
        }
    }
}
