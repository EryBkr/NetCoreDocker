# Docker CLI
```sql
Image build işlemin de `-t` parametresi ile image ye isim veriyoruz
.(nokta) ile Dockerfile dosyamızın hangi dizinde olduğunu tanımlıyoruz
.(nokta) işareti mevcut bulunulan dizine işaret eder.
`docker build -t dockertestimage .` 
bazı durumlarda yapılan değişiklikleri göremezsek `--no-cache` parametresi eklememiz gerekebilir
```

```sql
`docker images` 
oluşturulmuş olan image leri listeler
```

```sql
`docker create --name dockertest_container dockertestimage` 
container oluşturuyoruz.container ismini verdikten sonra üzerinde çalışacağı image bilgisini verdik
```

```sql
`docker ps` 
çalışan container ları gösterir.`-a` parametresi ile hepsini görebiliriz.
```

```sql
`docker start [container ismi]` 
komutu ile container'ı ayağa kaldırıyoruz
```

```sql
`docker stop [container ismi]` 
komutu ile çalışan container'ı durdurmuş olduk
```

```sql
console çıktılarını görebilmek için `docker attach [container ismi]` komutunu yazmamız gerekiyor.
```

```sql
`docker run --name docker_container_run dockertestimage` 
ile container oluşturulur ve attach durumunda çalışır
```

```sql
`docker container rm [container ID veya ismi]` 
ile mevcut container ları silebilriz.Çoklu silme yapabiliriz
```

```sql
`docker run --rm --name consolecontainer dockertestimage` 
komutu ile attach modda aktif olur eğer container stop ile durdurulursa otomatik olarak silinir
```

```sql
`docker rmi [image ismi]` 
komutu ile container a bağlı olmayan bir image'ı silebiliriz
```

```sql
`docker build -t myimage:v1 .` 
oluşturduğumuz imaja tag eklemek istersek bu şekilde yazıyoruz
```

```sql
`docker run --name mycontainer myimage:v1` 
şeklinde container'ı ayağa kaldırabiliriz.
```

```sql
`docker rm --force [container ismi]` 
komutu ile durdurulmamış bir containar'ı dahi silebiliyoruz.
```

```sql
`docker rmi --force [image ismi]` 
komutu ile imaja bağlı bir container olsa dahi silebiliyoruz.
```

```sql
`--force` parametresi ile imaj silmek için bağlı container'ın durmuş olması gerekmektedir.
```

```sql
`docker pull mcr.microsoft.com/dotnet/sdk:3.1` 
komutu ile docker-hub tan image çekebiliriz
```

```sql
`docker push image_name:tag_name` 
komutu ile docker-hub'a kendi oluşturduğumuz imajı gönderebiliriz. username/reponame ile local içerisinde ki imaj ismimizin aynı olması gerekmektedir.
```

```sql
`docker run --name mvccontainer -p 5000:80 dockermvc:v1` 
komutu ile docker içerisinde ayağa kalkan uygulamamızın 80 portunu işletim sistemimizin 5000 portuna bağladık.Uygulama default olarak 80 portunda ayağa kalkıyor. `-d` parametresi ile attach modda çalışmasına engel olabiliriz.
```

```sql
` docker run -d -p 5000:4500 --name [container-name] --mount type=bind,source="[fiziksel-adres]",target="/app/wwwroot/img" [image-name]` 
komutu ile docker içerisinde ayağa kalkan uygulamamızın işletim sisteminde hangi klasöre bağlayanacağını (bind-mount) belirliyoruz.Container dursa veya silinse bile klasör içerisinde ki datalar saklanmaya devam edecektir.
```


```sql
`docker volume create [volume name]` 
komutu ile volume (sanal klasör) oluşturuyoruz.
```

```sql
`docker run -d -p 5000:4500 --name [container name] --volume [volume name]:/app/wwwroot/images [image name]` 
komutu ile oluşturduğumuz volume ile containerı birbirine bağlıyoruz.O an bağlanan fiziksel klasör içerisinde ki verilerde sanal klasöre kopyalanır.
Volume kavramı container dan bağımsız bir kavram olduğu için başka bir container ı da bu volume bağlasak güncel kalacaktır.
```

```sql
`docker volume rm [volume name]` 
komutu ile oluşturduğumuz volume silinir
```

```sql
`docker run -d --name mycontainer -p 5000:4500 --env ASPNETCORE_ENVIRONMENT=DEVELOPMENT myimage:v2` 
komutu ile environment tanımlayarak uygulama ayarlarını belirliyebiliriz.
Default olarak Production olarak ayağa kalkacaktır.
```

```sql
`docker run -d --name mycontainer -p 5000:4500 --env ConnectionString="Uzak Sunucu Yolu" myimage` 
komutu ile kendimize ait environment tanımlayabiliriz.appsettings.Production.json dosyamızda böyle bir alan olmamasına rağmen
Container ımız default olarak Production ortamında ayağa kalkacak ve bu ortam değişkenine kendi içerisine ekleyecektir.
appsettings dosyamıza da ekleyebilirdik ama güvenlik için böyle tanımlamak daha uygun olur.
```



# Net Core CLI
```sql
`dotnet build` komutu ile dotnet uygulamamızı build edebiliriz.
```

```sql
`dotnet run` komutu ile dotnet uygulamamızı ayağa kaldırabiliriz.
```


