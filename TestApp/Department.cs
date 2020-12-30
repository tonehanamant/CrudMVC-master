namespace CrudMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public class Department
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Departments { get; set; }

        [StringLength(50)]
        public string Qualification { get; set; }

        [StringLength(50)]
        public string Salary { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }
    }

    public enum DepartmentData
    {
        IT,
        
    }
}
