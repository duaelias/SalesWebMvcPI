using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace SalesWebMvcPI.Models
{
    public class Seller
    {
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} Obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do {0} deve ser entre {2} e {1}")]
        public string Name { get; set; }
        
        
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "{0} Obrigatorio")]
        [EmailAddress(ErrorMessage = "Entra com e-mail valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} Obrigatorio")]
        [Display(Name ="Aniversário")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} Obrigatorio")]
        [Display(Name = "Salario")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} o salario deve ser entre {1} to {2}")]
        public double BaseSalary { get; set; }
        
        public Department Department { get; set; }
        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
