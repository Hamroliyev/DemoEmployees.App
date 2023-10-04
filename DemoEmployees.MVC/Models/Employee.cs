using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEmployees.MVC.Models
{
    public class Employee
    {
        /// <summary>
        /// Fields for PayrollNumber.
        /// </summary>
        public string PayrollNumber { get; set; }
        /// <summary>
        /// Fields for Forenames.
        /// </summary>
        public string Forenames { get; set; }
        /// <summary>
        /// Fields for Surname.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Fields for Dateofbirth.
        /// </summary>
        public DateTime Dateofbirth { get; set; }
        /// <summary>
        /// Fields for Telephone.
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// Fields for Mobile.
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// Fields for Address.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Fields for SecondAdress.
        /// </summary>
        public string SecondAdress { get; set; }
        /// <summary>
        /// Fields for PostCode.
        /// </summary>
        public string PostCode { get; set; }
        /// <summary>
        /// Fields for EmailHome.
        /// </summary>
        public string EmailHome { get; set; }
        /// <summary>
        /// Fields for StartDate.
        /// </summary>
        public DateTime StartDate { get; set; }

    }
}
