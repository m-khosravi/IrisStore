﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iris.DomainClasses;

namespace Iris.ViewModels
{
    public class ListFactorViewModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا نام را وارد کنید")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا نام خانوادگی را وارد کنید")]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا شماره تلفن را وارد کنید")]
        public string PhoneNumber { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا آدرس را وارد کنید")]
        public string Address { get; set; }
        public DateTime IssueDate { get; set; } = DateTime.Now;
        [Required]
        public FactorStatus Status { get; set; } = FactorStatus.Paid;
        public IList<ListFactorProductViewModel> Products { get; set; }
    }

    public class ListFactorProductViewModel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int MaxCount { get; set; } = 0;
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }

}
