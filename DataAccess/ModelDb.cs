using System;
using System.Data.Entity;
using System.Linq;
using UrunYonetim.Entites;
using UrunYonetimi.Entites;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace UrunYonetim.DataAccess
{
    public class ModelDb : DbContext
    {
       
        public ModelDb()
            : base("name=ModelDb")
        {
            Database.SetInitializer(new Db�nitializer());

        }

       
        //database'deki tablolar�m�z. 
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Urun>  Urunler { get; set; }
        public virtual DbSet<Marka> Markalar { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {//model olusurken belirli kriterler vermemiz i�in kulland���m�z metotdur.
            //modelbuilder parametresi ile �o�u �eyi yapabilmekteyiz. �rne�im 
            

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //�stteki kod tablolar olu�urken urunlerS gibi sonuna s tak�s� ekleniyor.
            //zaten turkceye cevirince Pluraziling - cogulla�t�rma demek oluyor.
        }

        
        public class Db�nitializer : CreateDatabaseIfNotExists<ModelDb> 
        {
            /*Bizim code first kullanabilmemizi as�l sa�layan yap� budur. 
             Yani e�er veritaban� yoksa bize verilen dbcontext'e g�re , �rne�in burada ModelDb ismindeki dbConteximiz 
            bizim parametremizdir, bu parametreye g�re veritaban� olu�turur. Bunu da dbcontext i�erisindeki 
            db set nesnelerini baz alarak yapar. Bu s�n�f�n 2 as�l �nemli metodu vard�r. Seed ve initialize database metotlar�*/

            /*Seed metodu veritaban� devreye girdikten sonra i�lem yapar. �rne�in ilk 10 adet datay� girmemize olanak sa�layabilir. 
             Di�er initialize metodu ise veritaban�n� olu�tururken de�i�iklikler yapabilmemizi sa�lar.*/ 
            protected override void Seed(ModelDb context)
            {
                //simdi ilk olarak context �zerinden kullan�c�lar db'sine ula��p hi� kullan�c� var m� onu test edelim.
                if (context.Kullanicilar.Any())
                {
                    context.Kullanicilar.Add(new Kullanici
                    {
                        Ad = "Ahmet",
                        AktifMi = true,
                        Email = "ahmetayyildiz.dev@gmail.com , ",
                        kullaniciAdi = "admin",
                        sifre = "123456789",
                        Soyad = "Ayyildiz"
                    });
                }
                context.SaveChanges();
                base.Seed(context);
            }
        }
    }

    
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}