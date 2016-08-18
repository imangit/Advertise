﻿using Advertise.ServiceLayer.Contracts.Common;
namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyQuestionService :IBaseService 
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        void Create();

        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        void Edit();

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        void Delete();

        #endregion

        #region Retrieve
        /// <summary>
        /// 
        /// </summary>
        void Get();

        #endregion
    }
}