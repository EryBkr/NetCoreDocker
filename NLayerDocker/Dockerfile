#SDK imajımızı aldık ve as diyerek build ismini atadık
FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

#imajın içerisinde app klasörü oluşturuyoruz ve içerisine giriyoruz
WORKDIR /app

#Shared katmanımızda ki uzantısı .csproj ile biten dosyayı seçtik
#ardına (Workdir app dediğimiz için app klasörünün içerisindekiz)
#bu seçtiğimiz dosyayı app içerisinde ki MyBlog.Shared içerisine atıyoruz
#./ app i temsil eder sondaki / ise klasörün içerisini temsil etmektedir
COPY ./MyBlog.Shared/*.csproj ./MyBlog.Shared/

#Test projemiz olsaydı eğer
#COPY ./TestProject/*.csproj ./TestProject/

#Performans amaçlı katmanları ayrı ayrı container a gönderiyoruz.
COPY ./MyBlog.Data/*.csproj ./MyBlog.Data/

#Belirlediğimiz klasör yok ise otomatik oluşturacaktır
COPY ./MyBlog.Services/*.csproj ./MyBlog.Services/
COPY ./MyBlog.Entities/*.csproj ./MyBlog.Entities/
COPY ./MyBlog.Mvc/*.csproj ./MyBlog.Mvc/

#solution'u aldık
COPY *.sln .

#Bütün projedeki dll leri güncelliyor
RUN dotnet restore

#Projenin sol halini app in içerisine kopyaladık
COPY . .

#Test projemiz olsaydı eğer
#RUN dotnet test ./TestProject/*.csproj

#publish edilecek projeyi belirledik ve publish ediyoruz.
#publish app in içerisi anlamına gelir, /publish ise root içerisini tarif eder
RUN dotnet publish ./MyBlog.Mvc/*.csproj -o /publish/

#Run-time için imaj belirliyoruz
FROM mcr.microsoft.com/dotnet/aspnet:5.0

#yeni imajımızın yeni app klasörüne gidiyoruz
WORKDIR /app

#build (SDK) imajımızın publish klasörü içerisindeki verileri yeni imajımıza aktardık
COPY --from=build /publish .

ENV ASPNETCORE_URLS = "http://*:5000"


#imaj üzerinde koşacak komutu ve dll i veriyoruz
ENTRYPOINT ["dotnet","MyBlog.Mvc.dll" ]

