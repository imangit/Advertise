﻿using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Categories.CategoryFollow
{
    public class CategoryFollowListViewModel : BaseViewModel
    {
        public Guid Id { get; set; }
        public bool IsFollow { get; set; }

    }
}
}
