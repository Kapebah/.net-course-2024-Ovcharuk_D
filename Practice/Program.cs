using BankSystem.Domain.Models;
using static System.Console;

Employee employee = new Employee { Name = "Felix", Age = 27, PassportDetails = "1234-567890", Contruct = "Contruct isn't confirm yet"};
Currency currency = new Currency { Type = "RUB" };

void updateContruct (Employee employee)
{
    employee.Contruct = "Contruct is confirm";
}

void updateCurrency (Currency currency)
{
    currency.Type = "EUR";
}

updateContruct(employee);
updateCurrency(currency);

WriteLine($"{employee.Name}'s {employee.Contruct}");
WriteLine($"{currency.Type}");

ReadKey();



