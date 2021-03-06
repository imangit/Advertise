﻿using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Categories.CategoryFollow;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Categories
{
    public interface ICategoryFollowService : IBaseService
    {
        #region Create

                Task CreateAsync(CategoryFollowCreateViewModel  viewModel);

        #endregion

        #region Update

        /// <summary>
        ///     فالو کردن یا پس کرفتن فالو
        ///     ممکنه کاربر فالو کنه دوباره آن فالو و بازم فالو به همین دلیل نباید یک کاربر بافالو یک محصول در دیتابیس دوتا ذخیره
        ///     بشه
        /// </summary>
        bool EditFollowOrUnFollow();

        Task EditAsync(CategoryFollowEditViewModel viewModel);
        #endregion

        #region Retrieve

        /// <summary>
        ///     گرفتن تعداد لایک های یک محصول
        /// </summary>
        /// <returns></returns>
        int GetCount(Guid idCategory);

        /// <summary>
        ///     گرفتن تعداد لایکهایی که پس گرفته شدن
        /// </summary>
        /// <returns></returns>
        int GetUnCount(Guid idCategory);

        /// <summary>
        ///     آیا کاربر محصول را لایک کرده،جهت نمایش در صفحه کاربر
        /// </summary>
        /// <returns></returns>
        bool GetUserFollowCategory(Guid idUser, Guid idCategory);

        /// <summary>
        ///     گرفتن تعداد فالورهای خود کاربر
        /// </summary>
        /// <returns></returns>
        int GetUserFollowCount(Guid idUser);

        /// <summary>
        ///     گرفتن تعداد فالور محصولات یک شهر
        /// </summary>
        /// <returns></returns>
        int GetCountFollowUserInCity(Guid idAddress);

        /// <summary>
        ///     گرفتن تعداد آن فالور محصولات یک شهر
        /// </summary>
        /// <returns></returns>
        int GetCountUnFollowUserInCity(Guid idAddress);

        /// <summary>
        ///     گرفتن بیشترین یا کمترین محصول فالو شده
        /// </summary>
        /// <returns></returns>
        long GetMaxCategory();
        long GetMinCategory();

        #endregion

        #region Read
        Task<CategoryFollowCreateViewModel> GetForCreateAsync();

        Task<CategoryFollowEditViewModel > GetForEditAsync(Guid id);

        Task<IEnumerable<CategoryFollowListViewModel>> GetListAsync();
        #endregion
    }
}