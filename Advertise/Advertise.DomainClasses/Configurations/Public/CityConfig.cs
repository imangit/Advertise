﻿using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class CityConfig : EntityTypeConfiguration<City>
    {
        /// <summary>
        /// </summary>
        public CityConfig()
        {
            //ToTable("AD_City");

            Property(city => city.Name).IsRequired().HasMaxLength(100);
            Property(city => city.RowVersion).IsRowVersion();
        }
    }
}