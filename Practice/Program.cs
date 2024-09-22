﻿using BankSystem.Domain.Models;
using BankSystem.App.Services;
using static System.Console;
using System.Security;

//Practice 1

Employee _employee = new Employee
{
    Name = "Felix",
    Age = 27,
    PassportDetails = "1234-567890",
    Contruct = "Contruct isn't confirm yet"
};
Currency _currency = new Currency { Type = "RUB" };

void UpdateContruct(Employee employee)
{
    employee.Contruct = "Contruct is confirm";
}

void UpdateCurrencyWithoutChanges(Currency currency)
{
    currency.Type = "EUR";
}

UpdateContruct(_employee);
UpdateCurrencyWithoutChanges(_currency);

//Значение в employee.Contruct поменялось, а в currency.Type нет,
//т.к. при передаче объекта класса мы ссылаемся на одну и ту же ссылку,
//вследствие чего у нас обновляются данные и вне метода,
//а при передаче структуры у нас создается копия (новый объект),
//и изменения в копии не влияют на оригинал
WriteLine($"{_employee.Name}'s {_employee.Contruct}");
WriteLine($"Without changes: {_currency.Type}");

//В таком случае мы сможем изменить значение валюты
Currency UpdateCurrencyWithChanges(Currency currency)
{
    currency.Type = "USD";
    return currency;
}

_currency = UpdateCurrencyWithChanges(_currency);

WriteLine($"With changes: {_currency.Type}");

//Practice 2

Client client = new Client
{
    Name = "Eugene",
    Age = 23,
    PhoneNumber = "123456789",
    PassportDetails = "1234-567890"
};

List<Employee> _employees = new List<Employee>()
{
    _employee,
    BankService.ConvertClientToEmployee(client)
};

WriteLine($"Salary: {BankService.CalculateSalary(60000, 20000, _employees.Count)}");

ReadKey();