#Net Core Runtime Image'�n�n y�klenmesini sa�l�yoruz
FROM mcr.microsoft.com/dotnet/aspnet:3.1

#Image i�erisinde App klas�r� olu�turuyorum.Publish edilmi� uygulamay� i�erisine ataca��m
#/app klas�r� yok ise otomatik olu�turulur
WORKDIR /app

#Dockerfile'�n konumuna g�re kopyalamak istedi�imiz Release c�kt�lar�n� 
#Image i�erisinde olu�turdu�umuz app klas�r�ne kopyal�yoruz
COPY /bin/Release/netcoreapp3.1/publish /app/

#Container aya�a kalkarken �al��mas� gereken komutu veriyorum.
ENTRYPOINT ["dotnet","DockerTest.dll"]

#Image build i�lemin de -t parametresi ile image ye isim veriyoruz
#.(nokta) ile Dockerfile dosyam�z�n hangi dizinde oldu�unu tan�ml�yoruz
#.(nokta) i�areti mevcut bulunulan dizine i�aret eder.
#docker build -t dockertestimage .

#"docker images" olu�turulmu� olan image leri listeler

#container olu�turuyoruz.container ismini verdikten sonra �zerinde �al��aca�� image bilgisini verdik
#"docker create --name dockertest_container dockertestimage"

#"docker ps" �al��an container lar� g�sterir."-a" parametresi ile hepsini g�rebiliriz.

#"docker start [container ismi]" komutu ile container'� aya�a kald�r�yoruz

#"docker stop [container ismi]" komutu ile �al��an container'� durdurmu� olduk

#console ��kt�lar�n� g�rebilmek i�in "docker attach [container ismi]" komutunu yazmam�z gerekiyor.