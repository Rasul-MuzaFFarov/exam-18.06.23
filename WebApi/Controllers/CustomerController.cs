using Domain.Dtos.Employee;
using Domain.Dtos.Employee.Customer;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController :ControllerBase
{
    private readonly CustomerServices _customerServices;

    public CustomerController(CustomerServices customerService)
    {
        _customerServices = customerService;
    }

    [HttpGet("GetCustommer")]
    public async Task<List<CustomerDto>> GetEmployee()
    {
        return await _customerServices.GetCustomers();
    }
    [HttpGet("GetCustomerById")]
    public async Task<Customer> GetCustomerById(int id)
    {
        return await _customerServices.GetCustomerById(id);
    }
    
    [HttpPost("AddCustomer")]
    public AddCustomerDto AddCustomer(Customer customer) 
    {
        return _customerServices.AddCustomer(customer);
    }
    
    [HttpPut("UpdateCustomer")]
    public Customer UpdateCustomer(Customer customer)
    {
        return _customerServices.UpdateCustomer(customer);
    }
    
    [HttpDelete("DeleteCustomer")]
    public bool DeleteCustomer(int id)
    {
        return _customerServices.DeleteCustomer(id);
    }
    
    
}