using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private String _ID;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private String _UserName;

        public String UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private String _Password;

        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private String _FirstName;

        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private String _LastName;

        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private int _Gender;

        public int Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        private String _BirthDate;

        public String BirthDate
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }

        private String _Address;

        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private String _JoinDate;

        public String JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }

        private int _IsNew;

        public int IsNew
        {
            get { return _IsNew; }
            set { _IsNew = value; }
        }

        public Customer(String id, String userName, String password, String firstName, String lastName, int gender, String birthDate, String address, String joinDate, int isNew)
        {
            this._ID = id;
            this._UserName = userName;
            this._Password = password;
            this._FirstName = firstName;
            this._LastName = lastName;
            this._Gender = gender;
            this._BirthDate = birthDate;
            this._Address = address;
            this._JoinDate = joinDate;
            this._IsNew = isNew;
        }

        public Customer()
        {

        }
    }
}
