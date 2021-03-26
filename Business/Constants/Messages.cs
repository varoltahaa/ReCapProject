using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = " Araç Başarıyla Eklendi ";
        public static string CarDailyPriceInvalid = "Lütfen Sıfırdan Büyük Bir Miktar Giriniz.";
        public static string CarUpdated = " Araç Başarıyla Güncellendi ";
        public static string CarDeleted = " Araç Başarıyla Silindi ";
        public static string CarListed = "Araçlar Başarıyla Listelendi";

        public static string MaintenanceTim = "Sistem Bakımda";

        public static string RentalAdded = "Kiralama İşlemi Başarılı";
        public static string RentalDeleted = "Kiralama İşlemi Silme Başarılı";
        public static string RentalUpdated = "Kiralama İşlemi Güncelleme Başarılı";
        public static string RentalListed = "Kiralanan Araçlar Başarıyla Güncellendi";

        public static string UserAdded = "Kullanıcı Başarıyla Eklendi";
        public static string UserDeleted = "Kullanıcı Başarıyla Silindi";
        public static string UserUpdated = "Kullanıcı Başarıyla Güncellendi";
        public static string UserListed = "Kullanıcılar Başarıyla Listelendi";
        public static string UserPasswordInvalid = "Şifre en az 8 en fazla 24 karakter olmak zorunda en az 1 tane özel karakter(.,?+%-*/=) içermek zorunda ve büyük küçük harflerden oluşmak zorunda!";

        public static string CustomerAdded = "Müşteri Başarıyla Eklendi";
        public static string CustomerDeleted = "Müşteri Başarıyla Silindi";
        public static string CustomerUpdated = "Müşteri Başarıyla Güncellendi";
        public static string CustomerListed = "Müşteriler Başarıyla Listelendi";

        public static string BrandAdded = "Araç Markası Başarıyla Eklendi";
        public static string BrandDeleted = "Araç Markası Başarıyla Silindi";
        public static string BrandUpdated = "Araç Markası Başarıyla Güncellendi";
        public static string BrandListed = "Markalar Başarıyla Listelendi";
        public static string BrandNameAlreadyExists = "Bu İsimde Marka Zaten Kayıtlı";

        public static string ColorAdded = "Renk Başarıyla Eklendi";
        public static string ColorDeleted = "Renk Başarıyla Silindi";
        public static string ColorUpdated = "Renk Başarıyla Güncellendi";
        public static string ColorListed = "Renkler Başarıyla Listelendi";
        public static string ColorNameAlreadyExists = "Bu İsimde Renk Zaten Kayıtlı";

        public static string CarCountOfBrandError = "Bir markadan en fazla 10 tane araç olabilir";

        public static string CarImageCountError = "Bir Aracın En Fazla 5 Tane Resimi Olabilir";

        public static string AuthorizationDenied = "Yetkiniz Yok!";
        public static string UserRegistered = "Kayıt Oldu!";
        public static string UserNotFound = "Kullanıcı Bulunamadı!";
        public static string PasswordError = "Parola Hatalı!";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Giriş Başarılı";
    }
}
