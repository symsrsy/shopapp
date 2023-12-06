using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder) 
        {
            builder.Entity<Product>().HasData(
                new Product(){ProductId=1,Name="İnverter",Url= "İnverter-1", Price=2000,ImageUrl="1.png",Description="iyi ", IsApproved=true},
                new Product(){ProductId=2,Name= "İnverter 2", Url= "İnverter-2", Price=3000,ImageUrl="2.png",Description="iyi ", IsApproved=false},
                new Product(){ProductId=3,Name= "İnverter 3", Url= "İnverter-3", Price=4000,ImageUrl="3.jpg",Description="iyi ", IsApproved=true},
                new Product(){ProductId=4,Name= "İnverter 4", Url= "İnverter-4", Price=5000,ImageUrl="4.png",Description="iyi ", IsApproved=false},
                new Product(){ProductId=5,Name= "İnverter 5", Url= "İnverter-5", Price=6000,ImageUrl="5.jpg",Description="iyi ", IsApproved=true}
            );

            builder.Entity<Category>().HasData(     
                new Category(){CategoryId=1,Name="Güneş Panelleri",Url="gunes-panelleri"},   
                new Category(){CategoryId=2,Name="Solar İnverterler",Url="solar-inverterler"},
                new Category(){CategoryId=3,Name="Solar Jel Akü Lityum Aküler",Url="akuler"},
                new Category(){CategoryId=4,Name="Solar Şarj Kontrol Cihazları",Url="sarj-kontrol"},
                new Category(){CategoryId=5,Name="Solar Taşıyıcı Sistemler",Url="tasiyici-sistemler"},
                new Category(){CategoryId=6,Name="Solar Aydınlatma Ürünleri",Url="aydinlatma"},               
                new Category(){CategoryId=7,Name="Solar Kablo ve MC4 Konnektörler",Url="kablo-konnektor"},  
                new Category(){CategoryId=8,Name="Solar Sulama Sistemleri",Url="sulama-sistemleri"},
                new Category(){CategoryId=9,Name="Solar Paket Sistemleri ",Url="paket-sistemleri"},
                new Category(){CategoryId=10,Name="Elektrikli Araç Şarj İstasyonu",Url="arac-sarj"},
                new Category(){CategoryId=11,Name="Solar Ürünler",Url="solar-urunler"}
            );

            builder.Entity<ProductCategory>().HasData(
                new ProductCategory(){ProductId=1,CategoryId=1},          
                new ProductCategory(){ProductId=1,CategoryId=2},          
                new ProductCategory(){ProductId=1,CategoryId=3},          
                new ProductCategory(){ProductId=2,CategoryId=1},          
                new ProductCategory(){ProductId=2,CategoryId=2},          
                new ProductCategory(){ProductId=2,CategoryId=3},          
                new ProductCategory(){ProductId=3,CategoryId=4},          
                new ProductCategory(){ProductId=4,CategoryId=3},          
                new ProductCategory(){ProductId=5,CategoryId=3},          
                new ProductCategory(){ProductId=5,CategoryId=1}       

           );
        }
    }
}