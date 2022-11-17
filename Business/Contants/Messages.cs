using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
    public static class Messages
    {
        //Buradaki yapıyı cok dil destekli sistemlerlede yapılandırabilirsiniz.
        //Örn bir proprty oluşturup Get bloğunda seçili dile göre karşılığını veri tabanından getirebilirsiniz.
        public static string ProductAdded = "Ürün Başarıyla eklendi";
        public static string ProductDeleted = "Ürün Başarıyla silindi";
        public static string ProductUpdated = "Ürün Başarıyla güncellendi";
        public static string CategoryAdded = "Kategori Başarıyla eklendi";
        public static string CategoryDeleted = "Kategori Başarıyla silindi";
        public static string CategoryUpdated = "Kategori Başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
    }
}
