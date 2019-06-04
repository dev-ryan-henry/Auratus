//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuratusData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public int OrganizationId { get; set; }
        public int DepartmentId { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> DateOfJoining { get; set; }
        public Nullable<System.DateTime> DateOfLeaving { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Organization Organization { get; set; }
    }
}