﻿using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Categories
{
    /// <summary>
    ///     نشان دهنده دسته بندی محصولات
    /// </summary>
    public class Category : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     کد دسته بندی
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        ///     عنوان دسته بندی
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        ///     توضیحات دسته بندی
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// </summary>
        public virtual string ImageFileName { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Path { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     والد دسته بندی
        /// </summary>
        public virtual Category Parent { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ParentId { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<Category> Categories { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CategoryFollow> CategoryFollows { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CategoryReview> CategoryReviews { get; set; }

        #endregion
    }
}