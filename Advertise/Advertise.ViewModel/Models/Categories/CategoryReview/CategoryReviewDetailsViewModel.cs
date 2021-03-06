﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.ViewModel.Models.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Advertise.ViewModel.Models.Categories.CategoryReview
{
    public  class CategoryReviewDetailsViewModel:BaseViewModel 
    {
        public Guid Id { get; set; }
        [DisplayName("متن نقد و بررسی")]
       // [Required(ErrorMessage = "لطفا محتوای نقد و بررسی را وارد کنید")]
        public string Body { get; set; }

        [DisplayName("فعال")]
        public bool  IsActive { get; set; }
    }
}
