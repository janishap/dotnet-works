//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entity_framewk
{
    using System;
    using System.Collections.Generic;
    
    public partial class SALES_ORDER
    {
        public string ORDERNO { get; set; }
        public string CLIENTNO { get; set; }
        public Nullable<System.DateTime> ORDERDATE { get; set; }
        public string DELYADDR { get; set; }
        public string SALESMANNO { get; set; }
        public string DELYTYPE { get; set; }
        public string BILLEDYN { get; set; }
        public Nullable<System.DateTime> DELYDATE { get; set; }
        public string ORDERSTATUS { get; set; }
    
        public virtual client_master client_master { get; set; }
        public virtual SALESMAN_MASTER SALESMAN_MASTER { get; set; }
    }
}
