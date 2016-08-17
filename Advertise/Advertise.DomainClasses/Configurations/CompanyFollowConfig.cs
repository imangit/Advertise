﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities ;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations
{
    public  class CompanyFollowConfig:EntityTypeConfiguration< CompanyFollow >
    {
        public CompanyFollowConfig()
        {
            Property(follow => follow.RowVersion );
        }
    }
}
