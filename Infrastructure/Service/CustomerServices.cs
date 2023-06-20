using Domain.Dtos.Employee;
using Domain.Dtos.Employee.Customer;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class CustomerServices
{
    private readonly DataContext _context;
    
    public CustomerServices(DataContext context)
    {
        _context = context;
    }
    
    public async Task<List<CustomerDto>> GetCustomers()
    {
        return await _context.Customers.Select(e=> new CustomerDto()
        {
            Id = e.Id,
            FirstName = e.FirstName,
            LastName = e.LastName,
            Address = e.Address,
            Phone = e.Phone,
            Email = e.Email
            
        }).ToListAsync();
    }
    
    public async Task<Customer> GetCustomerById(int id)
    {
        return await _context.Customers.FindAsync(id);
    }
    
    public async Task<Customer> AddCustomer(Customer customer)
    {
        await _context.Customers.AddAsync(customer); 
        await _context.SaveChangesAsync();
        return customer;
        
    }

    public async Task<Customer> AddCustomerById(int id)
    {
        
        return await _context.Customers.FindAsync(id);
    }

    public Customer UpdateCustomer(Customer customer)
    {
        _context.Customers.Update(customer);
        _context.SaveChanges();
        return customer;
    }

    public bool DeleteCustomer(int id)
    {
        var book =  _context.Customers.Find(id);
        _context.Customers.Remove(book);
        var result =  _context.SaveChanges();
        return result == 1;
    }
}

