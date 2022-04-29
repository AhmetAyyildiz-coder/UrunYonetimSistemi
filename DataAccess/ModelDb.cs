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
            Database.SetInitializer(new DbÝnitializer());

        }

       
        //database'deki tablolarýmýz. 
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Urun>  Urunler { get; set; }
        public virtual DbSet<Marka> Markalar { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {//model olusurken belirli kriterler vermemiz için kullandýðýmýz metotdur.
            //modelbuilder parametresi ile çoðu þeyi yapabilmekteyiz. Örneðim 
            

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //üstteki kod tablolar oluþurken urunlerS gibi sonuna s takýsý ekleniyor.
            //zaten turkceye cevirince Pluraziling - cogullaþtýrma demek oluyor.
        }

        
        public class DbÝnitializer : CreateDatabaseIfNotExists<ModelDb> 
        {
            /*Bizim code first kullanabilmemizi asýl saðlayan yapý budur. 
             Yani eðer veritabaný yoksa bize verilen dbcontext'e göre , örneðin burada ModelDb ismindeki dbConteximiz 
            bizim parametremizdir, bu parametreye göre veritabaný oluþturur. Bunu da dbcontext içerisindeki 
            db set nesnelerini baz alarak yapar. Bu sýnýfýn 2 asýl önemli metodu vardýr. Seed ve initialize database metotlarý*/

            /*Seed metodu veritabaný devreye girdikten sonra iþlem yapar. Örneðin ilk 10 adet datayý girmemize olanak saðlayabilir. 
             Diðer initialize metodu ise veritabanýný oluþtururken deðiþiklikler yapabilmemizi saðlar.*/ 
            protected override void Seed(ModelDb context)
            {
                //simdi ilk olarak context üzerinden kullanýcýlar db'sine ulaþýp hiç kullanýcý var mý onu test edelim.
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