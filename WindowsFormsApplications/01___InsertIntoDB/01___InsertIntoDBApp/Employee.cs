//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _02___InsertIntoDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Identity_Number { get; set; }
        public Nullable<int> TownID { get; set; }
    
        public virtual Town Town { get; set; }
    }
}