using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Araçlar listelendi";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için teslim edilmesi gerekir";
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string ColorUpdated = "Renk güncelleme işlemi başarılı";
        public static string BrandUpdated = "Marka güncelleme işlemi başarılı";
        public static string ColorDeleted = "Renk silme işlemi başarılı";
        public static string BrandDeleted = "Marka silme işlemi başarılı";
        public static string ColorAddError = "Eklemek istediğiniz renk zaten mevcut.Farklı bir renk giriniz.";
        public static string BrandAddError = "Eklemek istediğiniz marka zaten mevcut.Farklı bir marka giriniz.";
        public static string AddedBrand = "Marka eklendi.";
        public static string BrandUpdatedError = "Marka güncellenemedi";
        public static string ColorAdded = "Renk eklendi";
    }
}
