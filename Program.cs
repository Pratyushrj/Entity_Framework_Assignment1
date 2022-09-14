using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_DB_assingnment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomersRepository customerRepository = new CustomersRepository();
            do
            {
                Console.WriteLine("1.GetAllCustomer\n2.GetCustomerByCustomerId\n3.GetCustomerById\n4.AddCustomer\n5.DeleteCustomer\n6.EditCustomer");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            List<Customer> customers = customerRepository.GetAllCustomer();
                            foreach (var customer in customers)
                            {
                                Console.WriteLine($"ID:{customer.Customerid} CompanyName:{customer.CompanyName} Name:{customer.contactName} address:{customer.Address} town:{customer.Town} phone_no:{customer.Fax}");
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Id");
                            string deptId = Console.ReadLine();
                            List<Customer> customers = customerRepository.GetCustomerByCustomerId(deptId);
                            foreach (var customer in customers)
                            {
                                Console.WriteLine($"ID:{customer.Customerid} CompanyName:{customer.CompanyName} Name:{customer.contactName} address:{customer.Address} town:{customer.Town} phone_no:{customer.Fax}");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter CustomerID");
                            string Customerid = Console.ReadLine();
                            Customer customer = customerRepository.GetCustomerById(Customerid);
                            if (customer != null)
                            {
                                Console.WriteLine($"ID:{customer.Customerid} CompanyName:{customer.CompanyName} Name:{customer.contactName} address:{customer.Address} town:{customer.Town} phone_no:{customer.Phone} faxno:{customer.Fax}");
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;
                    case 4:
                        {
                            Customer customers = new Customer();
                            Console.WriteLine("Enter CustomerId");
                            customers.Customerid =Console.ReadLine();
                            Console.WriteLine("Enter Your Companyname");
                            customers.CompanyName = Console.ReadLine();
                            Console.WriteLine("Enter Name");
                            customers.contactName = (Console.ReadLine());
                            Console.WriteLine("Enter address");
                            customers.Address =(Console.ReadLine());
                            Console.WriteLine("Enter town ");
                            customers.Town = Console.ReadLine();
                            Console.WriteLine("Enter Phoneno ");
                            customers.Phone = Console.ReadLine();
                            Console.WriteLine("Enter FAXno ");
                            customers.Fax = Console.ReadLine();
                            customerRepository.AddCustomer(customers);

                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter CustomerId");
                            string Customerid = (Console.ReadLine());
                            customerRepository.DeleteCustomer(Customerid);
                        }
                        break;
                    case 6:
                        {
                            Customer customer = new Customer();
                            Console.WriteLine("Enter CustomerId");
                            customer.Customerid = Console.ReadLine();
                            Console.WriteLine("Enter Your Companyname");
                            customer.CompanyName = Console.ReadLine();
                            Console.WriteLine("Enter Name");
                            customer.contactName = (Console.ReadLine());
                            Console.WriteLine("Enter address");
                            customer.Address = (Console.ReadLine());
                            Console.WriteLine("Enter town ");
                            customer.Town = Console.ReadLine();
                            Console.WriteLine("Enter Phoneno ");
                            customer.Phone = Console.ReadLine();
                            Console.WriteLine("Enter FAX no ");
                            customer.Fax = Console.ReadLine();
                            customerRepository.EditCustomer(customer);

                        }
                        break;
                }
            } while (true);
        }
    }
    
}