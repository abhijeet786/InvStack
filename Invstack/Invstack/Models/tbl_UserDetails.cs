//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invstack.Models
{
    using System;
    using System.Collections.Generic;

    public partial class tbl_UserDetails
    {
        public tbl_UserDetails()
        {
            this.tbl_Articles = new HashSet<tbl_Articles>();
            this.tbl_Comments = new HashSet<tbl_Comments>();
            this.tbl_Questions = new HashSet<tbl_Questions>();
        }

        public int Id { get; set; }
        public string Employee_Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Contact_no { get; set; }
        public string Designation { get; set; }
        public string About_Yourself { get; set; }
        public string Keyskills { get; set; }
        public byte[] Image { get; set; }
        public string Entry_By { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }

        public virtual ICollection<tbl_Articles> tbl_Articles { get; set; }
        public virtual ICollection<tbl_Comments> tbl_Comments { get; set; }
        public virtual ICollection<tbl_Questions> tbl_Questions { get; set; }
    }

}
