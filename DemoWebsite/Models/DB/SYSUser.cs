//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoWebsite.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSUser()
        {
            this.SYSUserProfiles = new HashSet<SYSUserProfile>();
            this.SYSUserRoles = new HashSet<SYSUserRole>();
        }
    
        public int SYSUserID { get; set; }
        public string LoginName { get; set; }
        public string PasswordEncryptedText { get; set; }
        public int RowCreatedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowCreatedDateTime { get; set; }
        public int RowModifiedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowModifiedDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSUserProfile> SYSUserProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSUserRole> SYSUserRoles { get; set; }
    }
}


// USE [DemoDB]
// GO

// CREATE TABLE [dbo].[SYSUser](
//     [SYSUserID] [int] IDENTITY(1,1) NOT NULL,
//     [LoginName] [varchar](50) NOT NULL,
//     [PasswordEncryptedText] [varchar](200) NOT NULL,
//     [RowCreatedSYSUserID] [int] NOT NULL,
//     [RowCreatedDateTime] [datetime] DEFAULT GETDATE(),
//     [RowModifiedSYSUserID] [int] NOT NULL,
//     [RowModifiedDateTime] [datetime] DEFAULT GETDATE(),
//     PRIMARY KEY (SYSUserID)
// )

// GO