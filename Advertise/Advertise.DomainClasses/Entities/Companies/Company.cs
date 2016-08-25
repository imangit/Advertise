﻿using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    ///     نشان دهنده کمپانی،شرکت یا واحد تولیدی و خدماتی
    /// </summary>
    public class Company : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     کد کمپانی
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        ///     نام شرکت
        /// </summary>
        public virtual string BrandName { get; set; }

        /// <summary>
        ///     توضیحات مربوط به شرکت
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        ///     برند؟
        /// </summary>
        public virtual string LogoFileName { get; set; }

        /// <summary>
        ///     تاریخچه شرکت
        /// </summary>
        public virtual string BackgroundFileName { get; set; }

        /// <summary>
        ///     شماره تلفن(های) شرکت
        /// </summary>
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        ///     شماره همراه
        /// </summary>
        public virtual string MobileNumber { get; set; }

        /// <summary>
        ///     آدرس ایمیل شرکت
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        ///     آدرس وب سایت شرکت
        /// </summary>
        public virtual string WebSite { get; set; }

        /// <summary>
        /// </summary>
        public virtual long EmployeeCount { get; set; }

        /// <summary>
        ///     سال تاسیس
        /// </summary>
        public virtual DateTime EstablishedOn { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد کاربری
        /// </summary>
        public virtual User OwnedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnedById { get; set; }

        /// <summary>
        ///     آدرس شرکت
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid AddressId { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<Category> Categories { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CompanyAttachment> Attachments { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CompanyFollow> Follows { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CompanyImage> Images { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CompanyModerator> Moderators { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CompanyQuestion> Questions { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CompanyReport> Reports { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection< CompanyReview> Reviews { get; set; }

       // public virtual Guid ReviewId { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection< CompanySocial > Socials { get; set; }

     //   public virtual Guid SocialId { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CompanyVisit> Visits { get; set; }

        #endregion
    }
}