using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7BusinessClassLibrary
{
   public class Vendors
    {
        private int vendorID;
        private string name;
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string zipCode;
        private string phone;
        private string contactLName;
        private string contactFName;
        private int defaultTermsID;
        private int defaultAccountNo;
        private string contactFullName;
        

        public int DefaultAccountNo
        {
            get { return defaultAccountNo; }
            set { defaultAccountNo = value; }
        }


        public int DefaultTermsID
        {
            get { return defaultTermsID; }
            set { defaultTermsID = value; }
        }


        public string ContactFName
        {
            get { return contactFName; }
            set { contactFName = value; }
        }


        public string ContactLName
        {
            get { return contactLName; }
            set { contactLName = value; }
        }


        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }


        public string ZipCode 
        {
            get { return zipCode; }
            set { zipCode = value; }
        }


        public string State
        {
            get { return state; }
            set { state = value; }
        }


        public string City
        {
            get { return city; }
            set { city = value; }
        }


        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }



        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int VendorID
        {
            get { return vendorID; }
            set { vendorID = value; }
        }

        public string ContactFullName
        {
            get { return contactFullName; }
            set {contactFullName = value; }



        }
        

        public Vendors() { }
    }
}
