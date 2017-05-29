//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NBsoft.Appointment.DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Appointment = new HashSet<Appointment>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string TaxIdNumber { get; set; }
        public string MobilePhone { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string URL { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string IBAN { get; set; }
        public string Contact { get; set; }
        public string DrivingLicense { get; set; }
        public string DrivingLicenseType { get; set; }
        public System.DateTime DrivingLicenseDate { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> NextAppointment { get; set; }
        public string IntegrationRef { get; set; }
        public Nullable<System.DateTime> IntegrationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointment { get; set; }
    }
}