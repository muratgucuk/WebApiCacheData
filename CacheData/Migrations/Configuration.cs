namespace CacheData.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MainDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MainDBContext context)
        {
            context.Authors.AddOrUpdate(f => f.Id,
                new Authors { Id = 1, Name = "Necip Fazıl Kısakürek" },
                new Authors { Id = 2, Name = "Mehmet Akif Ersoy" },
                new Authors { Id = 3, Name = "Nazım Hikmet" },
                new Authors { Id = 4, Name = "Yahya Kemal Beyatlı" },
                new Authors { Id = 5, Name = "Arif Nihat Asya" });

            context.Books.AddOrUpdate(f => f.Id,
                new Books { Id = 1, Name = "İbrahim Ethem", ISBN = "9758180042", Author_Id = 1 },
                new Books { Id = 2, Name = "Çile", ISBN = "975-8180-12-7", Author_Id = 1 },
                new Books { Id = 3, Name = "Sabır Taşı", ISBN = "9758180011", Author_Id = 1 },
                new Books { Id = 4, Name = "Püf Noktası", ISBN = "9758180827", Author_Id = 1 },
                new Books { Id = 5, Name = "Yeniçeri", ISBN = "9758180554", Author_Id = 1 },
                new Books { Id = 6, Name = "Yunus Emre", ISBN = "9758180080", Author_Id = 1 },
                new Books { Id = 7, Name = "Moskof", ISBN = "9758180282", Author_Id = 1 },
                new Books { Id = 8, Name = "Künye", ISBN = "9944144070", Author_Id = 1 },
                new Books { Id = 9, Name = "Canım İstanbul", ISBN = "9944144179", Author_Id = 1 },
                new Books { Id = 10, Name = "Safahat", ISBN = "93242542694", Author_Id = 2 },
                new Books { Id = 11, Name = "Asım", ISBN = "234235254353", Author_Id = 2 },
                new Books { Id = 12, Name = "Hakkın Sesleri", ISBN = "2342355435435", Author_Id = 2 },
                new Books { Id = 13, Name = "Süleymaniye Kürsüsünde", ISBN = "6457347465", Author_Id = 2 },
                new Books { Id = 14, Name = "Hatıralar", ISBN = "32425234543543", Author_Id = 2 },
                new Books { Id = 15, Name = "Firaklı nâmeler: Âkif'in gurbet mektupları", ISBN = "224234325454", Author_Id = 2 },
                new Books { Id = 16, Name = "Memleketimden İnsan Manzaraları", ISBN = "746583572546432", Author_Id = 3 },
                new Books { Id = 17, Name = "Yaşamak Güzel Şey Be Kardeşim", ISBN = "4363453454", Author_Id = 3 },
                new Books { Id = 18, Name = "Taranta Babu'ya Mektuplar", ISBN = "5474879765", Author_Id = 3 },
                new Books { Id = 19, Name = "Kuvâyi Milliye", ISBN = "43547486775", Author_Id = 3 },
                new Books { Id = 20, Name = "Yatar Bursa Kalesinde", ISBN = "455475676576", Author_Id = 3 },
                new Books { Id = 21, Name = "Kurtuluş Savaşı Destanı", ISBN = "234325435454", Author_Id = 3 },
                new Books { Id = 22, Name = "Yeşil Elmalar", ISBN = "342354355445", Author_Id = 3 },
                new Books { Id = 23, Name = "Piraye'ye Mektuplar", ISBN = "23423543554", Author_Id = 3 },
                new Books { Id = 24, Name = "Unutulan Adam", ISBN = "53454354334343", Author_Id = 3 },
                new Books { Id = 25, Name = "Kendi Gök Kubbemiz", ISBN = "352354242", Author_Id = 4 },
                new Books { Id = 26, Name = "Aziz İstanbul", ISBN = "43645643223", Author_Id = 4 },
                new Books { Id = 27, Name = "Eğil Dağlar", ISBN = "867897978976576", Author_Id = 4 },
                new Books { Id = 28, Name = "Edebiyata Dair", ISBN = "5785643543565", Author_Id = 4 },
                new Books { Id = 29, Name = "Eski Şiirin Rüzgârıyla", ISBN = "5678687464353", Author_Id = 4 },
                new Books { Id = 30, Name = "Bitmemiş Şiirler", ISBN = "346546745643", Author_Id = 4 },
                new Books { Id = 31, Name = "Çocukluğum, Gençliğim, Siyasi ve Edebi Hatıralarım", ISBN = "456465754", Author_Id = 4 },
                new Books { Id = 32, Name = "Tarih Müsahabeleri", ISBN = "9807865643543", Author_Id = 4 },
                new Books { Id = 33, Name = "Bir Bayrak Rüzgar Bekliyor", ISBN = "3243543545", Author_Id = 5 },
                new Books { Id = 34, Name = "Kökler ve Dallar", ISBN = "785675443", Author_Id = 5 },
                new Books { Id = 35, Name = "Dualar ve Aminler", ISBN = "7876545t5465", Author_Id = 5 },
                new Books { Id = 36, Name = "Fatihler Ölmez ve Takvimler", ISBN = "5657657676", Author_Id = 5 }
                );
        }
    }
}
