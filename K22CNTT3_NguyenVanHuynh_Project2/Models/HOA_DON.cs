//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K22CNTT3_NguyenVanHuynh_Project2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            this.CT_HOA_DON = new HashSet<CT_HOA_DON>();
        }
    
        public int ID { get; set; }
        public string HoaDonID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> NgayNhan { get; set; }
        public string UserNameMember { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string Diachi { get; set; }
        public Nullable<double> TongTriGia { get; set; }
        public Nullable<byte> TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOA_DON> CT_HOA_DON { get; set; }
        public virtual MEMBER MEMBER { get; set; }
    }
}
