//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PingYourPackage.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public System.Guid Key { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> LastUpdatedOn { get; set; }
    }
}
