using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistrationUsingAnnotations
{
    class User
    {
        /// <summary>
        /// Getter and Setter of firstName
        /// </summary>
        [Required(ErrorMessage = "User {0} is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name should be minimum 3 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string firstName { get; set; }

        /// <summary>
        /// Getter and Setter of LastName
        /// </summary>
        [Required(ErrorMessage = "User {0} is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name should be minimum 3 characters and a maximum of 20 characters")]
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        /// <summary>
        /// Getter and Setter of Email
        /// </summary>
        [Required(ErrorMessage = "User {0} is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; }

        /// <summary>
        /// Getter and Setter of PhoneNumber
        /// </summary>
        [Required(ErrorMessage = "User {0} is required")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string phoneNumber { get; set; }

        /// <summary>
        /// Getter and Setter of Password
        /// </summary>
        [Required(ErrorMessage = "User {0} is required")]
        [DataType(DataType.Password)]
        [PasswordPropertyText]
        public string password { get; set; }
    }
}
