using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToExam3
{
    public class CheckDataError : IDataErrorInfo
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string this[string property]
        {
            get
            {
                return GetErrorForProperty(property);
            }
        }

        private string GetErrorForProperty(string propertyName)
        {
            if (Name.Length > 10)
            {
                return "Error";
            }
           
            return string.Empty;
        }

        public string Error
        {
            get
            {
                return string.Empty;
            }
        }
    }
}
