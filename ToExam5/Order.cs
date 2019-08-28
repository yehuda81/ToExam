using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToExam5
{
    class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsMember { get; set; }
        public float OrderValue { get; set; }
        public Myenum OrderStatus { get; set; }
        public List<string> MyEnumValues = new List<string>
        {
            "None",
            "Shipped",
            "New",
            "Processing",
            "Received"
        };

        public Order(int id, string firstName, string lastName, int age, string email, bool isMember, float orderValue, Myenum orderStatus)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            IsMember = isMember;
            OrderValue = orderValue;
            OrderStatus = orderStatus;
        }
        public enum Myenum
        {
            
            None = 1, Shipped = 2, New = 3, Processing = 4, Received = 5
        }

    }
}
