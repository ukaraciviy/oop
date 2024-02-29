using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    // Deneme ÜK
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. Nesne Yönelimli Programlama Nedir?
            //Nesne nedir?
            // Araba kalıbı ve farklı arabalar
            // TC Kimik Kartı Şablonu
            #endregion

            #region 2. Sınıf Nedir? Neden Sınıf Yapısı Kullanılır?
            //Bir nesne oluşturulması için önce modellenmesi gerekir.
            //Modelleme yapabilmek için class kullanmalıyım.
            #endregion
            //transkriptHesapla t;
            //OrnekModel m;

            #region 4. Sınıf Modelinden Bir Referans Noktası Oluşturma
            //OrnekModel w;

            #endregion

            #region 5. Class Member

            #region Field
            //myclass m1 = new myclass();

            //m1.a = 1;
            //m1.b = "2";
            #endregion

            #region Property
            //Nesne içerisindeki field ler için bir validasyon katmanıdır.
            //myclass2 m2 = new myclass2();
            //Get blogu tetiklenecek
            //Console.WriteLine(m2.Yasi);

            //Set blogu tetiklenecek
            //m2.Yasi = 3;
            //Get blogu tetiklenecek
            //Console.WriteLine(m2.Yasi);
            //Console.ReadLine();


            #endregion

            #endregion

            #region Ornek1
            gecmeNotuHesapla g = new gecmeNotuHesapla();
            //g.not1 = 70;
            //g.not2 = 100;
            //Console.WriteLine(g.ortalamaHesapla());
            //Console.ReadLine();

            #endregion

            #region 6. Prop Property
            //Prop Property'de field tanımlamaya gerek yoktur.
            //myclass3 m3 = new myclass3();
            //Console.WriteLine(m3.Yasi);
            //Console.WriteLine(m3.Yas2);
            //Console.ReadLine();

            #endregion

            #region 7. Computed Property            
            //myclass4 m4 = new myclass4();
            //Console.WriteLine(m4.Topla);
            //Console.ReadLine();
            #endregion

            #region 8. Expression-Bodied Property
            //Prop'tan sadece değer dönen yapılardır.Sadece readonlydir.
            //myclass5 m5 = new myclass5();
            //Console.WriteLine(m5.Cinsiyet);
            //Console.ReadLine();
            #endregion

            #region 9. Metodlar
            //myclass m9 = new myclass();
            //Parantez ile birlikte çağrılır.
            //Console.WriteLine(m9.x());
            //Console.ReadLine();

            #endregion

            #region 10. Sınıf İçinde Sınıf Kullanımı

            //myclass6 m6 = new myclass6();            
            //myclass6.myclass6_1 m6_1 = new myclass6.myclass6_1();

            #endregion

            #region 11. Sınıf Elemanlarına Açıklama Satırı Ekleme 
            //myclass7 m67 = new myclass7();
            //m67.yas = 7;
            //m67.maasHesapla(4200);
            #endregion

            #region 12. This Keyword'ü
            //Sınıfın nesnesini temsil eder, metod ile field isimlerinin karışmasını engeller.
            myclass8 m8 = new myclass8();
            #endregion

            #region 13. Sorular

            //Soru: Bir Araba Sınıfı Oluşturma
            //Araba sınıfını tanımlayacak ve arabanın markası, modeli, ve hızı gibi özelliklerini içerecek bir C# sınıfı oluşturun.

            //Araba a = new Araba();
            //a.marka = "Fiat";
            //a.model = "Panda";
            //a.maxHiz = 180;

            //Soru: Metotlarla Daire Alanı ve Çevresi Hesaplama
            //Daire sınıfı oluşturun ve bu sınıfta dairenin yarıçapını alarak alanını ve çevresini hesaplayacak metotlar tanımlayın. 

            //Hesaplama dh = new Hesaplama();

            //Console.WriteLine(dh.daireCevreHesaplama(4));
            //Console.WriteLine(dh.daireAlanHesaplama(4));
            //Console.WriteLine(dh.dortgenAlanHesaplama(2, 4));

            //Soru: Bir Müşteri Sınıfı Tasarımı
            //Müşteri sınıfı oluşturun ve müşterinin adı, soyadı, e-posta adresi gibi özelliklerini içerecek şekilde bu sınıfı tasarlayın. Bu sınıfta fieldlara
            //karşılık propertyler olacak
            //musteri mus = new musteri();
            //mus.yas = 3;

            //Soru: Basit Bir Banka Hesabı İşlemleri
            //Banka hesabı adında bir sınıf oluşturun.Bu sınıf, bakiye tutarını saklayacak bir değişken içermeli ve para yatırma ve çekme gibi temel işlemleri gerçekleştirebilmelidir.

            //Banka2 b = new Banka2();

            //Console.WriteLine("Güncel Bakiye:" + b.hesapBakiyesi());

            //b.paraYatir(200);
            //Console.WriteLine("Para Yatırma İşlemi Sonunda Bakiye:" + b.Bakiye);

            //b.paraCek(150);
            //Console.WriteLine("Para Çekme İşlemi Sonunda Bakiye:" + b.Bakiye);

            //Console.ReadLine();

            // Çalışan sınıfı oluşturun. Bu sınıfın çalışan adı, departmanı, aylık maaş bilgileri gibi özellikleri olsun.Ayrıca maaş artışı yapacak bir metod içersin.

            //calisanlar c = new calisanlar();

            //Console.WriteLine("Lütfen Zam Oranını Giriniz:");
            //double oran = double.Parse(Console.ReadLine());
            //Console.WriteLine("Çalışan: " + c.isim);
            //Console.WriteLine("Departman: " + c.departman);
            //Console.WriteLine("Maaş: " + c.maas);
            //Console.WriteLine("Zam Oranı: "+ oran);
            //Console.WriteLine("Zamlı Maaş:" + c.maasArtir(oran));
            //Console.ReadLine();

            //Soru: Girilen sayının faktöriyelini hesaplayan bir sınıf ve metod oluşturun.

            faktoriyelHesaplama f = new faktoriyelHesaplama();
            f.sayi = 6;
            Console.Write("Faktörüyel: " + f.hesapla(f.sayi));
            Console.ReadLine();
            
            #endregion


        }
    }

    #region 3. Sınıf Oluşturma ve Konumları
    // Bir Sınıf name space içinde, dışında yada bir sınıf içinde oluşturulabilir.
    // Aynı yerde aynı isimle 2 sınıf tanımlanamaz.
    class OrnekModel
    {
        int a;
        int b;
        public void X()
        {
            Console.WriteLine(a); Console.WriteLine(b);

        }
        public int Y()
        {
            return 0;
        }
    }
    #endregion

    class transkriptHesapla
    {
        public int a;
        public string b;
    }

    class gecmeNotuHesapla
    {
        public int not1;
        public int not2;

        public double ortalamaHesapla()
        {
            return (not1 + not2)/2;
        }

    }

    class myclass
    {
        public int a;
        public string b;

        public int x()
        {
            return 10;
        }
    }

    class myclass2
    {
        int yasi =5;

        #region Full Property
        //Property hangi field'i temsil ediyorsa onun türünden olmalı.
        //Porperty adı temsil ettiği field'in başı harfi büyük olacak şekilde isimlendirilir..

        public int Yasi
        {
            get
            {
                return yasi;
            }

            set
            {
                yasi = value;
            }
        }
        #endregion
    }

    class myclass3
    {
        //Prop Property'de field tanımlamaya gerek yoktur.
        //int yasi = 5;
        public int Yasi { get; set; }

        //Oluşturacağın filed'in ilk değeri 15 olsun
        public int Yas2 { get; set; } = 15;

    }

    class myclass4
    {
        int sayi1 = 5;
        int sayi2 = 10;

        public int Topla
        {
            get
            {
                return sayi1 + sayi2;

            }

        }
    }

    class myclass5
    {
        public String Cinsiyet => "Erkek";
    }

    class Banka
    {
        int bakiye = 3;

        public int Bakiye
        {
            get
            {
                if (bakiye > 0)
                {
                    return bakiye * 10;
                }
                return 5;
            }
            set
            {
                if (value < 10)
                {
                    bakiye = value;
                }
                else
                {
                    bakiye = value * 95 / 100;
                }
            }
        }

    }

    class myclass6
    {
        int a;

        public int A { get; set; }

        public class myclass6_1
        {

        }

    }
    /// <summary>
    /// Bu sınıf kdv hesaplaması yapmak için oluşturulmuştur.
    /// </summary>
    class myclass7
    {
        int maas;

        /// <summary>
        /// Bu Bir yas propertydir.
        /// </summary>
        public int yas { get; set; }

        /// <summary>
        /// Bu metod ödenecek maaşı hesaplar.
        /// </summary>
        /// <param name="yalinMaas"></param>
        /// <returns>Ek ödemeli maaş bilgisini hesaplar.</returns>
        public double maasHesapla(double yalinMaas)
        {
            return yalinMaas + 100;
        } 
    }

    class myclass8
    {
        int yas;
        public double yasHesapla(int yas)
        {
            return this.yas+yas;
        }
    }

    class Araba
    {
        public string marka;
        public string model;
        public int maxHiz;

    }

    class Hesaplama
    {

        public double daireCevreHesaplama(double yariCap)
        {
            double cevre = 2*3.14 * yariCap;
            return cevre;

        }

        public double daireAlanHesaplama(int yariCap)
        {
            double alan = 3.14 * (yariCap*yariCap);
            return alan;

        }

        public double dortgenAlanHesaplama(int kisaKenar, int uzunKenar)
        {
            return kisaKenar * uzunKenar;
        }

       
    }

    class musteri
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string eposta { get; set; }
        public int yas { get; set; }
    }

    class Banka2
    {
        //double bakiye2 = 100;

        public double Bakiye { get; set; } = 100;

        public double hesapBakiyesi() {

            return Bakiye;
        }

        public void paraCek(double cekilecekTutar)
        {
            if (cekilecekTutar<=Bakiye)
            {
                Bakiye = Bakiye - cekilecekTutar;
            }
            //return bakiye;

        }

        public void paraYatir(double yatirlacakTutar)
        {
            Bakiye = Bakiye + yatirlacakTutar; 
            //return bakiye;
        }

    }

    class calisanlar
    {
        public string isim { get; set; } = "Ali";
        public string departman { get; set; } = "Yılmaz";
        public double maas { get; set; } = 100000;
        public double maasArtir (double zamOrani)
        {
            return maas + ((maas * zamOrani)/100);
        }
    }

    class faktoriyelHesaplama
    {
        public int sayi {get; set;}
        public int hesapla(int deger)
        {
            int sonuc=1;
            for (int i = 1; i<=sayi; i++)
            {
                //sonuc = sonuc *= i; 
                sonuc = (sonuc * i);
            }

            return sonuc;
        }
    }
}
