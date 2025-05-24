namespace BusinessLogic.OperationResult.Enums
{
    public enum NotificationType
    {
        UnknownError, // Bilinmeyen hata
        Error,
        Null,//Boş
        ExistingUser, //Zaten var
        Wrong, //Yanlış
        CancelledByUser, //Kullanıcı taraflı işlem iptali (Cancellation Token)
        IDNotFound, //Karşılıksız bir ID gönderilirse
        LockedOut, 
        NotPassive, //Destroy işlemleri için kullanılıyor.
        Success // Başarılı
        
    }
}
