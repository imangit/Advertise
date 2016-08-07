﻿using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده پرسش و پاسخ بین کاربر و کمپانی
    /// </summary>
    public class Question : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Question()
        {
            Id = Guid.NewGuid();
            IsAccepted = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// عنوان پرسش و پاسخ
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// متن پرسش و پاسخ
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// تاریخ ایجاد پرسش و پاسخ
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// تعداد لایک پرسش و پاسخ
        /// </summary>
        public Int32 LikedCount { get; set; }

        /// <summary>
        /// تائید شدن پرسش یا پاسخ توسط اپراتور
        /// </summary>
        public bool IsAccepted { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public Guid ReplyId { get; set; }

        /// <summary>
        /// کد اختصاصی پاسخ
        /// </summary>
        public Question Reply { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// کد اختصاصی کمپانی
        /// </summary>
        public Company Company { get; set; }

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
        public ICollection<Question> Questions { get; set; }

        #endregion
    }
}