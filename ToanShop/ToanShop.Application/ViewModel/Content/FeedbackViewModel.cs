﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ToanShop.Infrastructure.Enums;

namespace ToanShop.Application.ViewModel.Content
{
    public class FeedbackViewModel
    {
        public Guid Id { set; get; }

        [MaxLength(250, ErrorMessage = "Tên không được quá 250 ký tự")]
        [Required(ErrorMessage = "Tên phải nhập")]
        public string Name { set; get; }

        [MaxLength(250, ErrorMessage = "Email không được quá 250 ký tự")]
        public string Email { set; get; }

        [MaxLength(500, ErrorMessage = "Tin nhắn không được quá 500 ký tự")]
        public string Message { set; get; }

        public DateTime CreatedDate { set; get; }

        [Required(ErrorMessage = "Phải nhập trạng thái")]
        public Status Status { set; get; }

        public ContactDetailViewModel ContactDetail { set; get; }
    }
}
