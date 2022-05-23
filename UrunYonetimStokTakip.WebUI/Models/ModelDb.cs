using System;
using System.Data.Entity;
using System.Linq;
using UrunYonetim.Entites;
using UrunYonetimi.Entites;
using System.Data.Entity.ModelConfiguration.Conventions;


    namespace UrunYonetimStokTakip.WebUI.Models
    {
        public class ModelDb : DbContext
        {

            public ModelDb()
                : base("name=ModelDb")
            {
                //Database.SetInitializer(new Dbİnitializer());

            }


            //database'deki tablolarımız. 
            public virtual DbSet<Kategori> Kategoriler { get; set; }
            public virtual DbSet<Kullanici> Kullanicilar { get; set; }
            public virtual DbSet<Urun> Urunler { get; set; }
            public virtual DbSet<Marka> Markalar { get; set; }

            public virtual DbSet<Musteri> Musteriler { get; set; }
            public virtual DbSet<Siparis> Siparisler { get; set; }


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {//model olusurken belirli kriterler vermemiz için kullandığımız metotdur.
             //modelbuilder parametresi ile çoğu şeyi yapabilmekteyiz. Örneğim 

                Database.SetInitializer<ModelDb>(null);
                base.OnModelCreating(modelBuilder);

                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                //üstteki kod tablolar oluşurken urunlerS gibi sonuna s takısı ekleniyor.
                //zaten turkceye cevirince Pluraziling - cogullaştırma demek oluyor.
            }


            //public class Dbİnitializer : CreateDatabaseIfNotExists<ModelDb>
            //{
            //    /*Bizim code first kullanabilmemizi asıl sağlayan yapı budur. 
            //     Yani eğer veritabanı yoksa bize verilen dbcontext'e göre , örneğin burada ModelDb ismindeki dbConteximiz 
            //    bizim parametremizdir, bu parametreye göre veritabanı oluşturur. Bunu da dbcontext içerisindeki 
            //    db set nesnelerini baz alarak yapar. Bu sınıfın 2 asıl önemli metodu vardır. Seed ve initialize database metotları*/

            //    /*Seed metodu veritabanı devreye girdikten sonra işlem yapar. Örneğin ilk 10 adet datayı girmemize olanak sağlayabilir. 
            //     Diğer initialize metodu ise veritabanını oluştururken değişiklikler yapabilmemizi sağlar.*/
            //    protected override void Seed(ModelDb context)
            //    {
            //        //simdi ilk olarak context üzerinden kullanıcılar db'sine ulaşıp hiç kullanıcı var mı onu test edelim.
            //        if (!context.Kullanicilar.Any())
            //        {
            //            //eger kullanici yoksa default olarak bir admin kullanicisi ekleyelim sisteme
            //            context.Kullanicilar.Add(new Kullanici
            //            {
            //                Ad = "Ahmet",
            //                AktifMi = true,
            //                Email = "ahmetayyildiz.dev@gmail.com , ",
            //                kullaniciAdi = "admin",
            //                sifre = "123456789",
            //                Soyad = "Ayyildiz"
            //            });
            //        }
            //        context.SaveChanges();
            //        base.Seed(context);
            //    }
            //}

        }
    } 
