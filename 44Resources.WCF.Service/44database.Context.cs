﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _44Resources.WCF.Service
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_BA_BankDetail> tbl_BA_BankDetail { get; set; }
        public virtual DbSet<tblBusinessAssociate> tblBusinessAssociates { get; set; }
    
        public virtual ObjectResult<usp_BA_Signup_Result> usp_BA_Signup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BA_Signup_Result>("usp_BA_Signup");
        }
    
        public virtual int usp_BA_Signup1(string firstName, string lastName, string email, string mobile, string password, string address, string pincode, string city, string memberId)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var pincodeParameter = pincode != null ?
                new ObjectParameter("Pincode", pincode) :
                new ObjectParameter("Pincode", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var memberIdParameter = memberId != null ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_BA_Signup1", firstNameParameter, lastNameParameter, emailParameter, mobileParameter, passwordParameter, addressParameter, pincodeParameter, cityParameter, memberIdParameter);
        }
    
        public virtual ObjectResult<usp_Get_All_BA_List_Result> usp_Get_All_BA_List()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_All_BA_List_Result>("usp_Get_All_BA_List");
        }
    }
}
