using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.AutoMapper.Profiles;
using MyBlog.Mvc.Filters;
using MyBlog.Mvc.Helpers.Abstract;
using MyBlog.Mvc.Helpers.Concrete;
using MyBlog.Services.AutoMapper.Profiles;
using MyBlog.Services.Extensions;
using MyBlog.Shared.Utilities.Extensions;
using NToastNotify;
using System;
using System.Text.Json.Serialization;

namespace MyBlog.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //RazorRuntime k�t�phanesi watch gibi �al���r,de�i�iklikleri anl�k olarak g�rebiliriz
            //AddJsonOptions k�sm�nda json iletimi ile ilgili konfig�rasyonlar� tan�ml�yoruz
            //Toastr Mesajlar�n� C# taraf�nda olu�turabilmemizi sa�layan yap�y� konfig�re ettik
            services.AddControllersWithViews(opt =>
            {
                //Null Exception Hatas�n� T�rk�ele�tirdik
                opt.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(val => "Bu Alan Bo� Ge�ilmemelidir");

                //Hata kontrol filter imizi middleware k�sm�m�za ekledik
                opt.Filters.Add<MvcExceptionFilter>();
            }).AddNToastNotifyToastr(new ToastrOptions
            {
                TimeOut = 5000
            }).AddRazorRuntimeCompilation().AddJsonOptions(opt =>
            {
                //Enum kullan�m� i�in ekledik
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                //��i�e json datalar i�in ekledik
                opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            });

            services.AddSession();

            //Hakk�m�zda sayfam�z i�in olu�turdu�umuz modelimize appsettings teki verilerimizi bind edecektir.
            services.Configure<AboutUsPageInfo>(Configuration.GetSection("AboutUsPageInfo"));

            //Layout sayfam�z i�in olu�turdu�umuz modelimize appsettings teki verilerimizi bind edecektir.
            services.Configure<WebSiteInfo>(Configuration.GetSection("WebSiteInfo"));

            //Mail g�ndermek i�in olu�turdu�umuz smtp konfig�rasyonlar�m�z modelimize appsettings teki verilerimizi bind edecektir.
            services.Configure<SmtpSettings>(Configuration.GetSection("SmtpSettings"));

            //Okunan makale ile alakal� sayfada g�sterilecek makalelerin hangi �artlarla ve s�rayla gelece�inizi belirleyen appsettings.json da ki verileri modelimize bind edecektir
            services.Configure<ArticleRightSideBarWidgetOptions>(Configuration.GetSection("ArticleRightSideBarWidgetOptions"));

            //�� Katman�nda ki ba��ml�l�klar� ��zd���m�z ve connection String bilgisini verdi�imiz extension s�n�f�m�z
            services.LoadMyServices(Configuration.GetConnectionString("DefaultConnection"));
            //Resim i�lemleri i�in olu�turdu�umuz class � implemente ettik
            services.AddScoped<IImageHelper, ImageHelper>();

            //Cookie Ayarlar�
            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Admin/Auth/Login");//Yetki yok ise buraya y�nlendiriyoruz
                opt.LogoutPath = new PathString("/Admin/Auth/Logout");
                opt.Cookie = new CookieBuilder
                {
                    Name = "MyBlog",
                    HttpOnly = true,//UI Taraf�ndan cookie lere eri�ilememesi i�in tan�ml�yoruz XSS �nleniyor
                    SameSite = SameSiteMode.Strict,//CRSF Ata��n� �nlemek i�in kullan�l�r.Cookie kendi sitemizden gelmelidir
                    SecurePolicy = CookieSecurePolicy.SameAsRequest,//HTTP den istek gelirse HTTP olarak HTTPS den istek gelirse ona uygun olarak d�n�l�r.Olmas� Gereken Always dir
                };
                opt.SlidingExpiration = true;//S�re s�f�rlamas�n� sa�lar
                opt.ExpireTimeSpan = System.TimeSpan.FromDays(7);
                opt.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied"); //Yetkisi olmayan bir yere girmeye �al��an �yenin y�nlendirelece�i yer
            });

            //appsettings �zerinde ki section � de�i�tirebilmek i�in ekledik
            services.ConfigureWritable<AboutUsPageInfo>(Configuration.GetSection("AboutUsPageInfo"));
            //appsettings �zerinde ki section � de�i�tirebilmek i�in ekledik
            services.ConfigureWritable<WebSiteInfo>(Configuration.GetSection("WebSiteInfo"));
            //appsettings �zerinde ki section � de�i�tirebilmek i�in ekledik
            services.ConfigureWritable<SmtpSettings>(Configuration.GetSection("SmtpSettings"));
            //Okunan makale ile alakal� sayfada g�sterilecek makalelerin hangi �artlarla ve s�rayla gelece�inizi belirleyen appsettings.json da ki verileri de�i�tirmemizi sa�layacakt�r
            services.ConfigureWritable<ArticleRightSideBarWidgetOptions>(Configuration.GetSection("ArticleRightSideBarWidgetOptions"));


            //AutoMappper Profile Class lar�m�z� burada tan�mlad�k.
            services.AddAutoMapper(typeof(CategoryProfile), typeof(ArticleProfile), typeof(UserProfile), typeof(ViewModelsProfile), typeof(CommentProfile));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages(); //404 hata vb... y�nlendirmeler i�in 
            }
            else
            {
                //app.UseExceptionHandler("/Error");
                app.UseDeveloperExceptionPage();
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }



            app.UseSession();
            app.UseStaticFiles();
            app.UseHttpsRedirection();


            app.UseRouting();

            app.UseAuthentication(); //Kimlik kontrol� 
            app.UseAuthorization(); //Yetkilendirme


            //Toastr Mesajlar�n� C# taraf�nda olu�turabilmemizi sa�layan k�t�phaneyi projemize ekledik
            app.UseNToastNotify();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute( //SEO uyumlu makale URL i i�in ekledik
                    name: "article",
                    pattern: "Makaleler/{title}/{articleId}",
                    defaults: new { controller = "Article", action = "Detail" }
                    );
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
