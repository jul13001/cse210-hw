using System;
using System.Data.Common;

namespace employee_demo
{
    public class Employee
    {
        private string _name;
        private string _id;

        public Employee()
        {

        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetIdNumber()
        {
            return _id;
        }

        public void SetIdNumber(string id)
        {
            _id = id;
        }

        public virtual float GetPay()
        {
            return -1;
        }
        private string _address;
        private string _birthday;


    }
}