﻿using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    ///     نشان دهنده دیده شدن کمپانی
    /// </summary>
    public class CompanyVisit : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual bool IsVisit { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User VisitedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid VisitedById { get; set; }

        /// <summary>
        ///     کد اختصاصی شرکت
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        #endregion
    }
}