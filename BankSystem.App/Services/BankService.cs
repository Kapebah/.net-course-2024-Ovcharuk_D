using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Domain.Models;

namespace BankSystem.App.Services
{
    public class BankService
    {
        public static int calculateSalary(int bankProfit, int expenses, int ownerNumber) 
            => (bankProfit - expenses) / ownerNumber;
        

        public static Employee convertClientToEmployee(Client client)
            => new Employee
            {
                Name = client.Name,
                Age = client.Age,
                PassportDetails = client.PassportDetails,
                PhoneNumber = client.PhoneNumber
            };
        
    }
}
