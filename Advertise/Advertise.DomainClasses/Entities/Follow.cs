﻿using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده علاقه مندی ها
    /// </summary>
    public class Follow : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Follow()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// تاریخ ثبت دسته علاقه مندی
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// نوع علاقه مندی(شرکت یا دسته محصول)
        /// </summary>
        public FollowType Type { get; set; }


        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// کد اختصاصی دسته محصول
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// کد اختصاصی شرکت
        /// </summary>
        public Company Company { get; set; }

        #endregion
    }
}