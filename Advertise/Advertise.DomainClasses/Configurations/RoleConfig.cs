﻿using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class RoleConfig : EntityTypeConfiguration<Role>
    {
        /// <summary>
        /// 
        /// </summary>
        public RoleConfig()
        {
            //ToTable("AD_Role");

            Property(role => role.Code).IsRequired().HasMaxLength(50);
            Property(role => role.Title).IsRequired();
            Property(role => role.RowVersion).IsRowVersion();
        }
    }
}
