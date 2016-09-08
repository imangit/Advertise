﻿using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyReviewService : IBaseService
    {
        #region Create

        /// <summary>
        /// </summary>
        void Create();

        #endregion

        #region Update

        /// <summary>
        /// </summary>
        void Edit();

        /// <summary>
        /// فعال یا غیر فعال کردن نقد و بررسی
        /// </summary>
        /// <returns></returns>
        bool EditForActiveOrUnActive();

        #endregion

        #region Delete

        /// <summary>
        /// </summary>
        void Delete();

        #endregion

        #region Retrieve

        /// <summary>
        /// تعداد کل نقد و بررسی های شرکتها
        /// </summary>
        void GetCountAllReviwe();

        /// <summary>
        /// گرفتن آی دی شرکت برای نمایش نقد و بررسی
        /// </summary>
        void GetIdCompanyForShowReview();

        #endregion
    }
}