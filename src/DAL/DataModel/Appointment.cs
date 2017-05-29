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
    
    public partial class Appointment
    {
        public long Id { get; set; }
        public long Id_AppointmentType { get; set; }
        public long Id_Doctor { get; set; }
        public long Id_Customer { get; set; }
        public long Id_User { get; set; }
        public long Number { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public string Description { get; set; }
        public decimal ClientDiscount { get; set; }
        public decimal FinanceDiscount { get; set; }
        public string PaymentType { get; set; }
        public string Coin { get; set; }
        public decimal Exchange { get; set; }
        public decimal TotalProducts { get; set; }
        public decimal VATValue { get; set; }
        public decimal ComercialDiscountVal { get; set; }
        public string Report { get; set; }
        public string Comments { get; set; }
    
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual AppointmentType AppointmentType { get; set; }
    }
}