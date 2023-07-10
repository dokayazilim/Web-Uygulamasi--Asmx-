using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webservisuygulama.entities
{
    public enum outputType
    {
        islemBasarili = 1,
        islemBasarisiz = 2,
        tanimsiz = 3,
        kayitliUrun = 4,
        yeniUrun = 5,
        urunBulunamadi = 6,
        guvenlikHatasi = 7
    }
}