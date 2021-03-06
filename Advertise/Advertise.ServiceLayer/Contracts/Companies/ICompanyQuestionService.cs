﻿using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyQuestionService : IBaseService
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(CompanyQuestionCreateViewModel viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(CompanyQuestionEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(CompanyQuestionDeleteViewModel viewModel);
        #endregion

        #region Retrieve

        /// <summary>
        /// تعداد پرسش و پاسخهایی که تائید شدن
        /// </summary>
        void GetCountNotApprove();

        /// <summary>
        /// تعداد پرسش و پاسخهایی که تائید نشدن
        /// برای این منظور باید سه مدل باشه
        /// 0- نشان دهنده اینه که نه تائید شده نه تائید نشده
        /// 1- یعنی تائید شده
        /// -1 - یعنی تائید نشده
        /// </summary>
        void GetCountApprove();

        /// <summary>
        /// تعداد پرسش و پاسخهای با وضیعت نامشخص
        /// </summary>
        /// <returns></returns>
        int GetCountUnknown();

        /// <summary>
        /// نمایش پرسش و پاسخهایی که تائید شدن
        /// </summary>
        /// <returns></returns>
        int GetNotApprove();

        /// <summary>
        /// نمایش پرسش و پاسخهایی که تائید نشدن
        /// </summary>
        void GetApprove();

        /// <summary>
        /// نمایش پرسش و پاسخهای با وضیعت نامشخص
        /// </summary>
        /// <returns></returns>
        int GetUnknown();


        #endregion

        #region Read

        Task<CompanyQuestionCreateViewModel> GetForCreateAsync();

        Task<CompanyQuestionEditViewModel> GetForEditAsync(Guid id);

        Task<CompanyQuestionDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<CompanyQuestionListViewModel>> GetListAsync();

        Task<CompanyQuestionDetailViewModel> GetDetailsAsync(Guid id);

        Task<CompanyQuestionListViewModel> FindById(Guid id);

        Task FillCreateViewModel(CompanyQuestionCreateViewModel viewModel);

        #endregion
    }
}