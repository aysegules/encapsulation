internal class Program
{
    public static void Main(string[] args)
    {
        Ogrenci o1= new Ogrenci();
        o1.Isim="Ayse";
        o1.Soy_isim="Yilmaz";
        o1.Ogrenci_no=349;
        o1.Sinif=3;

        o1.SinifAtlat();
        o1.OgrenciBilgileri();
       
        Ogrenci o2= new Ogrenci();
        o2.Isim="Deniz";
        o2.Soy_isim="Arda";
        o2.Ogrenci_no=347;
        o2.Sinif=2;
 
        o2.SinifDusur();
        o2.SinifDusur();
        o2.OgrenciBilgileri();

        Ogrenci o3= new Ogrenci("Aysel","Kara",358,1);
        o3.OgrenciBilgileri();

    }
}

class Ogrenci
{
    string isim;
    string soy_isim;
    int ogrenci_no;
    int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soy_isim { get => soy_isim; set => soy_isim = value; }
    public int Ogrenci_no { get => ogrenci_no; set => ogrenci_no = value; }
    public int Sinif 
    { 
        get 
        {
            return sinif;
        }
        set 
        {
            if(value < 1)
            {
                Console.WriteLine("Hata! Bir ogrenci en az 1.sinifta olabilir.");
                sinif=1;
            }
            else
                sinif = value;
            
        } 
    }

    public Ogrenci(){}

    public Ogrenci(string isim, string soy_isim, int ogrenci_no, int sinif)
    {
        Isim = isim;
        Soy_isim = soy_isim;
        Ogrenci_no = ogrenci_no;
        Sinif = sinif;
    }

    public void OgrenciBilgileri()
    {
        Console.WriteLine("Ogrenci Adi              :{0}",Isim);
        Console.WriteLine("Ogrenci Soyadi           :{0}",Soy_isim);
        Console.WriteLine("Ogrenci Numarasi         :{0}",Ogrenci_no);
        Console.WriteLine("Ogrenci Sinifi           :{0}",Sinif);

    }

    public void SinifAtlat()
    {
        Sinif += 1;
    }
    public void SinifDusur()
    {
        Sinif -= 1;
    }
}