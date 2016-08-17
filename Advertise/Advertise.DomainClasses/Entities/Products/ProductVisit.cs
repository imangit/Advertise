﻿using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    ///     نشان دهنده دیده شدن محصول
    /// </summary>
    public class ProductVisit : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual bool IsVisited { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی شرکت
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ProductId { get; set; }

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User Visitor { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid VisitorId { get; set; }

        #endregion
    }
}