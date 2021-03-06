﻿using System.Threading.Tasks;

namespace ToanShop.WebApp.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}