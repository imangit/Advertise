﻿using System;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts;
using Microsoft.AspNet.Identity;

namespace Advertise.ServiceLayer.EFServices
{
    public class EmailService : IIdentityMessageService,IEmailService
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(IdentityMessage message)
        {
            return Task.FromResult(0);
        }
    }
}