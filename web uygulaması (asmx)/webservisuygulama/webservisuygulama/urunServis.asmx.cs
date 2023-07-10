using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using webservisuygulama.context;
using webservisuygulama.entities;
using webservisuygulama.guvenlikIslemleri;

namespace webservisuygulama
{
    /// <summary>
    /// urunServis için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class urunServis : System.Web.Services.WebService
    {

        [WebMethod]
        public outputType urunKayitYeni(urun u,guvenlik g)
        {
            string sifrelenmisData = "66841EB5-A583-4AFF-9FB3-00D935D7870A" + g.privateValue.ToString() + g.tokenTime;
            if (g.clientKey == SHA.SHA256Olustur(sifrelenmisData))
            {
                using (databaseLogicLayer dll = new databaseLogicLayer())
                {
                    if (dll.urunKimlikKontrol(u.urunKimlik) == outputType.yeniUrun)
                    {
                        return dll.urunKayitYeni(u);
                    }
                    else
                        return outputType.kayitliUrun;

                }
            }
            else 
            {
                return outputType.guvenlikHatasi;
            }
            
        }
        [WebMethod]
        public outputType urunKayitDuzenle(urun u) 
        {
            using (databaseLogicLayer dll = new databaseLogicLayer())
            {
                if (dll.urunKimlikKontrol(u.urunKimlik) == outputType.kayitliUrun)
                    return dll.urunKayitDuzenle(u);
                else
                    return outputType.urunBulunamadi;
            }
        }

        [WebMethod]

        public outputType urunKayitSil(string urunKimlik) 
        {
            using (databaseLogicLayer dll = new databaseLogicLayer())
            {
                if (dll.urunKimlikKontrol(urunKimlik) == outputType.kayitliUrun)
                    return dll.urunKayitSil(urunKimlik);
                else
                    return outputType.urunBulunamadi;
            }
        }
        [WebMethod]
        public List<urun> urunTumListe() 
        {
            using (databaseLogicLayer dll = new databaseLogicLayer())
            {
                return dll.urunKayitListe();
            }
        }

        [WebMethod]

        public urun urunGetir(string urunKimlik)
        {
            using (databaseLogicLayer dll = new databaseLogicLayer())
            {
                if (dll.urunKimlikKontrol(urunKimlik) == outputType.kayitliUrun)
                    return dll.urunKayitListe(urunKimlik);
                else
                    return new urun();
            }
        }
    }
}
