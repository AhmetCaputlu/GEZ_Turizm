namespace BusinessLogic.Enums
{
    public enum Notifications
    {
        UnknownError, // Bilinmeyen Hata
        Null,//Boş
        NullUser, // Boş kullanıcı
        ExistingUser, //Kullanıcı ismi zaten kullanılıyor
        NullPassWord, // Boş şifre bilgisi
        WrongPassword, //Kriterlere uygun olmayan parola
        CancelledByUser, //Kullanıcı taraflı işlem iptali (Cancellation Token)
        IDNotFound,//Karışılıksız bir ID gönderilirse
        LockedOut,
        NotPassive,//Destroy işlemleri için kullanılıyor.
        Success, // Başarılı
        Error
    }
}
