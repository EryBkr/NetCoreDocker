#Kullanacagımız base imajı aldık.SDK imajını kullanma nedenimiz Net CLI komutlarını kullanabilmek içindir
#as ile bu imaja bir isim veriyorum.
FROM mcr.microsoft.com/dotnet/sdk:3.1 as build

#oluşturduğumuz imajın kopyalanacağı yeri seçtik
WORKDIR /app

#cs.proj dosyasını aldık app a kopyaladık
COPY *.csproj .

#library veya projeyi güncelleme işlemini yapar.Bu işlem sırasına göre static dosyalarla ilgili bir restore oluşmayacağı için docker içerisinde bir performans kaybı olmayacaktır
RUN dotnet restore

#ilk nokta(.) Dockerfile ın içerisinde bulunduğu tüm dizini ifade ediyor,ikinci nokta(.) ise /app dizinini işaret ediyor.
COPY . .


#publish işlemini gerçekleştiriyoruz.Publish metodunu ve publish edilecek klasörü belirliyorum
RUN dotnet publish DockerMVC.csproj -c Release -o out

#bu aşamada dotnet sdk ya ihtiyacım yok.imaj boyutunu kuçultmek için container'ın koşması için yeterli olacak ve boyutu daha küçük olan run time imajını tanımlıyorum
FROM mcr.microsoft.com/dotnet/aspnet:3.1

#yeni imajımıza app klasörü oluşturduk
WORKDIR /app

#dotnet sdk yardımıyla oluşturduğumuz publish datalarını yeni imajımıza kopyalıyoruz.build burada yukarıda ki imajın kısaltmasıdır
COPY --from=build /app/out .

#localhostta çalışmasını önlemek için özellikle bir IP belirtmeden sadece port belirliyoruz.
# -p istenilen_port:burada vermiş olduğumuz port numarası şeklinde belirlemeliyiz
ENV ASPNETCORE_URLS="http://*:4500"

#Container ayağa kalkarken ortam değişkeni belirleyebildiğimiz gibi imaj içerisinde de belirleyebiliyoruz
ENV MySqlCon="Uzak Veri Tabanı Adresi"


ENTRYPOINT  ["dotnet","DockerMVC.dll"]