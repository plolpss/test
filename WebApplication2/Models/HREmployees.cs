using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class HREmployees
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        [DisplayName("員工編號")]
        public int EmployeeId { get; set; }

        /// <summary>
        /// 員工姓氏
        /// </summary>
        [DisplayName("員工姓氏")]
        public string LastName { get; set; }

        /// <summary>
        /// 員工名字
        /// </summary>
        [DisplayName("員工名字")]
        public string FirstName { get; set; }
    }
}