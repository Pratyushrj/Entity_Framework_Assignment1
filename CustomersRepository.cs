using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_DB_assingnment_1
{
    internal class CustomersRepository
    {
        public VirtusaDBEntities virtusaDB;
        public CustomersRepository()
        {
            virtusaDB = new VirtusaDBEntities();
        }
        public List<Customer> GetAllCustomer()
        {
            try
            {
                List<Customer> customers = virtusaDB.Customers.ToList(); //return all Customers
                return customers;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Customer> GetCustomerByCustomerId(string id)
        {
            try
            {
                List<Customer> customers = virtusaDB.Customers.Where(c => c.Customerid == id).ToList(); //return employees assigned to deptid
                return customers;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public Customer GetCustomerById(string Customerid)
        {
            try
            {
                Customer customers = virtusaDB.Customers.SingleOrDefault(e => e.Customerid == Customerid);  //Find() is used to fetch record using primary key column
                                                                          // Employee employee = virtusaDB.Employees.SingleOrDefault(e=>e.Eid==employeeId); //SingleOrDefault() used to search record using non primary key columns
                return customers;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddCustomer(Customer customers)
        {
            try
            {
                virtusaDB.Customers.Add(customers); //Add Customer to Customers table
                virtusaDB.SaveChanges(); //to save to record into the Customers table



            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteCustomer(string Customerid)
        {
            try
            {
                Customer customers = virtusaDB.Customers.SingleOrDefault(e=>e.Customerid==Customerid);
                virtusaDB.Customers.Remove(customers); //Delete Employee from the table
                virtusaDB.SaveChanges(); //to save to record into the EMployee table



            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EditCustomer(Customer newCustomer)
        {
            try
            {
                Customer Oldcustomer = virtusaDB.Customers.Find(newCustomer.Customerid);
                Oldcustomer.Town = newCustomer.Town;
                Oldcustomer.CompanyName = newCustomer.CompanyName;
                virtusaDB.SaveChanges(); //to save to record into the EMployee table
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}