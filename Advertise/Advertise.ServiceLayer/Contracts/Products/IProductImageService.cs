﻿using Advertise.ServiceLayer.Contracts.Common;
namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductImageService:IBaseService 
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