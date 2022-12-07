namespace Business.Constants.Messages
{
    public static class Messages
    {
        public static string SuccessAdded = "Ekleme işlemi başarılı";
        public static string SuccessUpdated = "Güncelleme işlemi başarılı.";
        public static string SuccessDeleted = "Silme işlemi başarılı.";
        public static string SuccessListed = "Listeleme başarılı.";
        public static string ErrorCarPrice = "Günlük fiyat 0'dan büyük olmalıdır.";
        public static string ErrorCarNameShort = "Araç açıklaması 2 harften uzun olmalıdır.";
        public static string ErrorCarNameAndPrice = "Günlük fiyat 0'dan büyük ve araç açıklaması 2 harften uzun olmalıdır";
        public static string SuccessCarDetails = "Araç özellikleri getirildi.";
        public static string SuccessRentalDetails = "Kiralama detayları getirildi.";

        public static string SuccessCarFilterByBrand = "Seçmiş olduğunuz markanın araçları listelendi.";
        public static string ErrorCarFilterByBrand = "Seçmiş olduğunuz marka için araç bulunamadı.";
        public static string SuccessCarFilterByColor = "Seçmiş olduğunuz renkteki araçlar listelendi.";
        public static string ErrorCarFilterByColor = "Seçmiş olduğunuz renkte araç bulunamadı.";

        public static string SuccessFilterById = "Seçmiş olduğunuz ID için sonuçlar getirildi: ";
        public static string ErrorFilterById = "Seçmiş olduğunuz ID için veri bulunamadı: ";

        public static string ErrorReturnDateNull = "Araç kiralamada olduğu için kiralanamaz. Farklı bir aracı kiralayabilirsiniz.";
        public static string SuccessImageUpload = "Resim yükleme başarılı";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt olundu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string PasswordError = "Parola hatalı.";
        public static string UserAlreadyExists = "Kullanıcı sistemde mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
