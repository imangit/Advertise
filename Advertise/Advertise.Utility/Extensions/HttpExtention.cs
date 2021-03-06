﻿using System;
using System.Linq;
using System.Web;

namespace Advertise.Utility.Extensions
{
    /// <summary>
    /// </summary>
    public static class HttpExtention
    {
        #region PhysicalToVirtualPathConverter

        /// <summary>
        /// </summary>
        /// <param name="utility"></param>
        /// <param name="path"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string PhysicalToVirtualPathConverter(this HttpServerUtilityBase utility, string path,
            HttpRequestBase context)
        {
            return path.Replace(context.ServerVariables["APPL_PHYSICAL_PATH"], "/").Replace(@"\", "/");
        }

        #endregion

        #region User-Agent

        /// <summary>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetBrowser(this HttpRequest request)
        {
            return $"{request.Browser.Browser} - {request.Browser.Version}";
        }

        #endregion

        #region GetIpAddress

        /// <summary>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetIp(this HttpRequestBase request)
        {
            string ip = null;
            try
            {
                if (request.IsSecureConnection)
                {
                    ip = request.ServerVariables["REMOTE_ADDR"];
                }

                if (string.IsNullOrEmpty(ip))
                {
                    ip = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                    if (!string.IsNullOrEmpty(ip))
                    {
                        if (ip.IndexOf(",", StringComparison.Ordinal) > 0)
                        {
                            ip = ip.Split(',').Last();
                        }
                    }
                    else
                    {
                        ip = request.UserHostAddress;
                    }
                }
            }
            catch
            {
                ip = null;
            }

            return ip;
        }

        /// <summary>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetIp(this HttpRequest request)
        {
            string ip = null;
            try
            {
                if (request.IsSecureConnection)
                {
                    ip = request.ServerVariables["REMOTE_ADDR"];
                }

                if (string.IsNullOrEmpty(ip))
                {
                    ip = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                    if (!string.IsNullOrEmpty(ip))
                    {
                        if (ip.IndexOf(",", StringComparison.Ordinal) > 0)
                        {
                            ip = ip.Split(',').Last();
                        }
                    }
                    else
                    {
                        ip = request.UserHostAddress;
                    }
                }
            }
            catch
            {
                ip = null;
            }

            return ip;
        }

        #endregion
    }
}