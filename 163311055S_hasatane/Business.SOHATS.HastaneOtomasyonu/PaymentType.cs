using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SOHATS.HastaneOtomasyonu
{
    #region PaymentType enum tanımlaması
    public enum PaymentType
    {
        Nakit,
        Kredi_Kartı_Taksitli,
        Kredi_Kartı_Nakit,
        Çek,
        Senet
    };
    #endregion
}
