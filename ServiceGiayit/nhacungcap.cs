//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceGiayit
{
    using System;
    using System.Collections.Generic;
    
    public partial class nhacungcap
    {
        public nhacungcap()
        {
            this.sanphams = new HashSet<sanpham>();
        }
    
        public int manhacungcap { get; set; }
        public string tennhacungcap { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<sanpham> sanphams { get; set; }
    }
}