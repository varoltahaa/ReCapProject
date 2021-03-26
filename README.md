<h1 align="center">ReCapProject | Araba Kiralama Sistemi</h1>

![ReCapproject](https://github.com/varoltahaa/ReCapProject/blob/master/0__oppsTUx797Y9V2e.png?raw=true)

# ⭐ Giriş

**WepAPI, Business, DataAccess, Entities ve Core katmanlarından oluşan SOLID prensipleri dikkate alınarak geliştirilmiş bir projedir.**
**Validation, Cache, Performace, Transaction aspectlerinin implementasyonu gerçekleştirilmiştir**

# ⭐ Katmanlar

<h3> ✔ WepAPI Katmanı</h3>

[WepAPI](https://github.com/varoltahaa/ReCapProject/tree/master/WepAPI)

**Bu katman tarayıcı üzerinden kullanıcının isteklerini karşılayan ilk katmandır. Burada yazılan Controller'lar sayesinde istenilen CRUD operasyonu istenilen Entity'nin Business katmanına yönlendirilir**

<h3> ✔ Business Katmanı</h3>

[Business](https://github.com/varoltahaa/ReCapProject/tree/master/Business)

**Veritabanı ve Api arasında kalan bu katman kullanıcıdan gelen istekleri veritabanına iletmen önce belirlenmiş kurallardan geçmesini sağlar bu kurallar FluentValidation kullanılarak verildi**

<h3> ✔ DataAccess Katmanı</h3>

[DataAccess](https://github.com/varoltahaa/ReCapProject/tree/master/DataAccess)

**EntityFramework yapısını kullandığımız bu katman, Business katmanından geçen isteği veritabanına yönlendirir ve kullanıcı tarayıcı üzerinde istediği operasyonun karşılığını alır**

<h3> ✔ Core Katmanı</h3>

[Core](https://github.com/varoltahaa/ReCapProject/tree/master/Core)

**Bu katman projenin kalbidir. Projeden bagımsız genel kuralları ve işlevler bu katmanda bulunur. Bu yüzden hiçbir katmanla bağlılığı yoktur.**

<h3> ✔ Entities Katmanı</h3>

[Entities](https://github.com/varoltahaa/ReCapProject/tree/master/Entities)

**Veritabanı tabloları için oluşturulan nesneler ve Joın işlemi için oluşturulan DTO'lar bu katmanda bulunur**

# ⭐ Lisans

**Bu proje MIT lisansı ile lisanslanmıştır. Daha fazla bilgi için [lisans](https://github.com/varoltahaa/ReCapProject/blob/master/LICENSE) dosyasını okuyun**

# ⭐ Yazar

**Taha Varol** - [Linkedln](https://www.linkedin.com/in/taha-varol-8027361b4/)
