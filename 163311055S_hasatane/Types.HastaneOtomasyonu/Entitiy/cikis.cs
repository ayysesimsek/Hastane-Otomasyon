using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.HastaneOtomasyonu.Entitiy
{
    public class cikis
    {
        /// <summary>
        /// The File Number Gets or Sets
        /// </summary>
        public string FileNumber { get; set; }
        /// <summary>
        /// The Shipment Date Gets or Sets
        /// </summary>
        public string ShipmentDate { get; set; }
        /// <summary>
        /// The Output Clock Gets or Sets
        /// </summary>
        public DateTime OutputClock { get; set; }
        /// <summary>
        /// The Pay Gets or Sets
        /// </summary>
        public string Pay { get; set; }
        /// <summary>
        /// The Total Amount Gets or Sets
        /// </summary>
        public string TotalAmount { get; set; }
    }
}
