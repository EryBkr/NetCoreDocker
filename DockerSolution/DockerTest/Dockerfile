#Net Core Runtime Image'ýnýn yüklenmesini saðlýyoruz
FROM mcr.microsoft.com/dotnet/aspnet:3.1

#Image içerisinde App klasörü oluþturuyorum.Publish edilmiþ uygulamayý içerisine atacaðým
#/app klasörü yok ise otomatik oluþturulur
WORKDIR /app

#Dockerfile'ýn konumuna göre kopyalamak istediðimiz Release cýktýlarýný 
#Image içerisinde oluþturduðumuz app klasörüne kopyalýyoruz
COPY /bin/Release/netcoreapp3.1/publish /app/

#Container ayaða kalkarken çalýþmasý gereken komutu veriyorum.
ENTRYPOINT ["dotnet","DockerTest.dll"]

#Image build iþlemin de -t parametresi ile image ye isim veriyoruz
#.(nokta) ile Dockerfile dosyamýzýn hangi dizinde olduðunu tanýmlýyoruz
#.(nokta) iþareti mevcut bulunulan dizine iþaret eder.
#docker build -t dockertestimage .

#"docker images" oluþturulmuþ olan image leri listeler

#container oluþturuyoruz.container ismini verdikten sonra üzerinde çalýþacaðý image bilgisini verdik
#"docker create --name dockertest_container dockertestimage"

#"docker ps" çalýþan container larý gösterir."-a" parametresi ile hepsini görebiliriz.

#"docker start [container ismi]" komutu ile container'ý ayaða kaldýrýyoruz

#"docker stop [container ismi]" komutu ile çalýþan container'ý durdurmuþ olduk

#console çýktýlarýný görebilmek için "docker attach [container ismi]" komutunu yazmamýz gerekiyor.