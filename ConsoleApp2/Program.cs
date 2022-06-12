using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Customer 
    {
        public string name;
        public bool member=false;
        public string memberType;

        public Customer(string name)
        {
            this.name = name;
        }
        public string GetName() 
        {
            return name;
        }
        public bool isMember() 
        { 
            return member;
        }
        public void SetMember(bool member) 
        {
            this.member= member;
        }
        public string GetMemberType() 
        { 
            return this.memberType;
        }
        public void setMemberType(string type) 
        { 
            memberType = type;
        }
        public override string ToString()
        {
            return "Customer with the name:" + name;
        }
    }
    public class Visit : DiscountRate
    {
        public Customer customer;
        public DateTime date;
        public double serviceExpense;
        public double productExpense;

        public Visit(string name, DateTime date)
        {
            customer = new Customer(name);
        }
        public string GetName() 
        {
            return customer.name;
        }
        public double GetServiceExpense() 
        { 
            return serviceExpense;
        }
        public void SetServiceExpense(double serExpense) 
        {
            serviceExpense = serExpense;
        }
        public double GetProductExpense() 
        { 
            return productExpense;
        }
        public void SetProductExpense(double prodExpense) 
        { 
            productExpense = prodExpense;
        }
        public double GetTotalExpense() 
        {
            return serviceExpense + productExpense;
        }
    }
    public class DiscountRate 
    { 
        public double serviceDiscountPremium=0.2;
        public double serviceDiscountGold = 0.15;
        public double serviceDiscountSilver = 0.1;
        public double productDiscountPremium = 0.1;
        public double productDiscountGold = 0.1;
        public double productDiscountSilver = 0.1;

        public double GetServiceDiscountRate(string type) 
        {
            if (type=="Premium") 
            {
                return serviceDiscountPremium;
            }
            if (type == "Gold")
            {
                return serviceDiscountGold;
            }
            return serviceDiscountSilver;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer("Florenta");
            var visitor = new Visit("Iulian", DateTime.Now);
            visitor.GetName();
            visitor.customer.setMemberType("Premium");
            visitor.SetProductExpense(50.0);
            visitor.SetServiceExpense(30.0);
            visitor.GetServiceDiscountRate("Premium");
            visitor.GetTotalExpense();
            double amount = visitor.GetServiceDiscountRate("Premium") * visitor.GetTotalExpense();
            Console.WriteLine(amount);
            Console.WriteLine("Customer with the name {0} has purchased products with value of {1}",visitor.customer.name,amount);
        }
    }
}
