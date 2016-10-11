﻿using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies.CompanyReview
{
  public   class CompanyReviewCreateViewModel : BaseViewModel

    {

        [DisplayName("متن بررسی")]
        [Required(ErrorMessage = "لطفا متن بررسی را وارد کنید")]
        //[StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string Body { get; set; }
        public bool  Active { get; set; }
    }
}