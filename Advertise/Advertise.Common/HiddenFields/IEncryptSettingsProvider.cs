﻿namespace Advertise.Common.HiddenFields
{
    /// <summary>
    /// </summary>
    public interface IEncryptSettingsProvider
    {
        /// <summary>
        /// </summary>
        byte[] EncryptionKey { get; }

        /// <summary>
        /// </summary>
        string EncryptionPrefix { get; }
    }
}