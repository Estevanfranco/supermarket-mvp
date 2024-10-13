﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {
        [DisplayName("Customers_Id")]
        public int Id { get; set; }


       /* [DisplayName("Product_Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay mode name must be between 3 and 50 characters")]*/
        public string Document { get; set; }

        /*[DisplayName("Product_Price")]
        [Required(ErrorMessage = "Pay mode observation is required")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]*/
        public string FirstName { get; set; }

      /*  [DisplayName("Product_Stock")]
        [Required(ErrorMessage = "Pay mode observation is required")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]*/
        public string LastName { get; set; }

        /*  [DisplayName("Product_Stock")]
       [Required(ErrorMessage = "Pay mode observation is required")]
       [StringLength(10, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]*/
        public string Address { get; set; }

        /*  [DisplayName("Product_Stock")]
       [Required(ErrorMessage = "Pay mode observation is required")]
       [StringLength(10, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]*/
        public string Birthday { get; set; }

        /*  [DisplayName("Product_Stock")]
       [Required(ErrorMessage = "Pay mode observation is required")]
       [StringLength(10, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]*/
        public string PhoneNumber { get; set; }

        /*  [DisplayName("Product_Stock")]
      [Required(ErrorMessage = "Pay mode observation is required")]
      [StringLength(10, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]*/
        public string Email { get; set; }

    }
}
