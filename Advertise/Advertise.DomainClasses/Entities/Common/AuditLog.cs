﻿using System;
using System.Xml.Linq;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Common
{
    /// <summary>
    ///     نشان دهنده لاگ سیستم
    /// </summary>
    public class AuditLog : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     sets or gets description of Log
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        ///     sets or gets when log is operated
        /// </summary>
        public virtual DateTime OperatedOn { get; set; }

        /// <summary>
        ///     sets or gets Type Of Entity
        /// </summary>
        public virtual string Entity { get; set; }

        /// <summary>
        ///     gets or sets  Old value of  Properties before modification
        /// </summary>
        public virtual string XmlOldValue { get; set; }

        /// <summary>
        ///     gets or sets XML Base OldValue of Properties (NotMapped)
        /// </summary>
        public virtual XElement XmlOldValueWrapper
        {
            get { return XElement.Parse(XmlOldValue); }
            set { XmlOldValue = value.ToString(); }
        }

        /// <summary>
        ///     gets or sets new value of  Properties after modification
        /// </summary>
        public virtual string XmlNewValue { get; set; }

        /// <summary>
        ///     gets or sets XML Base NewValue of Properties (NotMapped)
        /// </summary>
        public virtual XElement XmlNewValueWrapper
        {
            get { return XElement.Parse(XmlNewValue); }
            set { XmlNewValue = value.ToString(); }
        }

        /// <summary>
        ///     gets or sets Identifier Of Entity
        /// </summary>
        public virtual string EntityId { get; set; }

        /// <summary>
        ///     gets or sets user agent information
        /// </summary>
        public virtual string Agent { get; set; }

        /// <summary>
        ///     gets or sets user's ip address
        /// </summary>
        public virtual string OperantIp { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     sets or gets log's creator
        /// </summary>
        public virtual User OperantedBy { get; set; }

        /// <summary>
        ///     sets or gets identifier of log's creator
        /// </summary>
        public virtual long OperantedById { get; set; }

        #endregion
    }
}