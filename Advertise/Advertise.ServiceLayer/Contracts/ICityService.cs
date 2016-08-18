﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts.Common;
namespace Advertise.ServiceLayer.Contracts
{
  public   interface ICityService:IBaseService 
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