﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses .Entities ;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations
{
    public  class CompanyConfig :EntityTypeConfiguration< Company >

    {
        public CompanyConfig()
        {
            Property(company => company.Email ).IsOptional().HasMaxLength(75);
            Property(company => company.Address ).IsRequired() .HasMaxLength(500);
            Property(company => company.BackgroundFileName ).IsOptional().HasMaxLength(75);
            Property(company => company.BrandFileName ).IsOptional().HasMaxLength(75);
            Property(company => company.Description  ).IsRequired() .HasMaxLength(5000);
            Property(company => company.MobileNumber ).IsRequired() .HasMaxLength(11);
            Property(company => company.PhoneNumber ).IsRequired() .HasMaxLength(50);
            Property(company => company.Code).IsRequired() .HasMaxLength(75);
            Property(company => company.PostalCode ).IsOptional().HasMaxLength(12);
            Property(company => company.Title ).IsRequired() .HasMaxLength(200);
            Property(company => company.WebSite ).IsOptional().HasMaxLength(100);
            Property(company => company.RowVersion).IsRowVersion();





        }
    }
}
