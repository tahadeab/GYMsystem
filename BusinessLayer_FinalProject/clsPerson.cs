using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcciss_GymSystem;

namespace BusinessLayer_FinalProject
{
    public class clsPerson
    {
        enum enMode {AddNew=0, Update =1 }
        enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get {return FirstName+" "+SecondName+" "+ThirdName+" "+LastName ;}}
        public short Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNum { get; set; }
        public int CountryID { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

       public clsCountry countryInfo;

        private string _ImagePath;
        public string ImagePath { get { return _ImagePath; } set {_ImagePath = value; } }

        public clsPerson()
        { 
            this.PersonID = -1;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.Gender = 0;
            this.DateOfBirth = DateTime.Now;
            this.PhoneNum = string.Empty;
            this.CountryID = -1;
            this.Email = string.Empty;
            this.Address = string.Empty;
            this.ImagePath = string.Empty;
            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID,string FirstName, string SecondName,
                           string ThirdName,string LastName,short Gender,
                           DateTime DateOfBirth,string PhoneNum, int CountryID,
                           string Email, string Address,string ImagePath)
        {
            this.PersonID=PersonID;
            this.FirstName=FirstName;
            this.SecondName=SecondName;
            this.ThirdName=ThirdName;
            this.LastName=LastName;
            this.Gender = Gender;
            this.DateOfBirth=DateOfBirth;
            this.PhoneNum = PhoneNum;
            this.CountryID = CountryID;
            this.Email = Email;
            this.Address = Address;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;

            countryInfo = clsCountry.Find(CountryID);

        }


        private bool _AddNewPerson()
        {
            this.PersonID = clsHR.AddNewPersonToDB(this.FirstName,this.SecondName,this.ThirdName,
                                                   this.LastName,this.Gender,this.DateOfBirth,
                                                   this.PhoneNum,this.CountryID,this.Email,
                                                   this.Address,this.ImagePath);
            return (this.PersonID > 0);
        }

        private bool _UpdatePerson()
        {
            return clsHR.UpdatePerson(this.PersonID,this.FirstName,this.SecondName, this.ThirdName,
                                       this.LastName, this.Gender,this.DateOfBirth,this.PhoneNum,this.CountryID, this.Email,
                                       this.Address,this.ImagePath);
        }


       public static  clsPerson Find(int PersonID)
        {
            string FirstName = " ";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            short Gender = 0;
            DateTime DateOfBirth =DateTime.Now;
            string PhoneNum = "";
            int CountryID=-1;
            string Email = "";
            string Address = "";
            string ImagePath = "";

            if (clsHR.GetPersonInfoByID(PersonID,ref FirstName,ref SecondName,ref ThirdName,ref LastName,
                                        ref Gender,ref DateOfBirth, ref PhoneNum,ref CountryID,
                                        ref Email, ref Address,ref ImagePath))
            {
                return new clsPerson(PersonID,  FirstName,  SecondName, ThirdName, LastName,
                                        Gender, DateOfBirth, PhoneNum, CountryID,
                                        Email, Address, ImagePath);
            }
            else
            {
                return null;
            }

        }


        public static clsPerson Find(string FirstName,string LastName)
        {
            int PersonID = -1;
            string SecondName = "";
            string ThirdName = "";
           
            short Gender = 0;
            DateTime DateOfBirth = DateTime.Now;
            string PhoneNum = "";
            int CountryID = -1;
            string Email = "";
            string Address = "";
            string ImagePath = "";

            if (clsHR.GetPersonInfoByFirstNameAndLastName( FirstName,ref PersonID, ref SecondName, ref ThirdName,LastName,
                                        ref Gender, ref DateOfBirth, ref PhoneNum, ref CountryID,
                                        ref Email, ref Address, ref ImagePath))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName,
                                        Gender, DateOfBirth, PhoneNum, CountryID,
                                        Email, Address, ImagePath);
            }
            else
            {
                return null;
            }

        }

        public bool Save ()
        {
            switch (Mode) 
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false; 
                    }
                 case enMode.Update:
                    return _UpdatePerson();
            
            }
            return false;

        }


        public static  DataTable GetAllPeople()
        {
            return clsHR.GetAllPeople();
        }

       public static bool DeletePerson(int PersonID)
        {
            return (clsHR.DeletePerson(PersonID));  
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsHR.IsPersonExist(PersonID);
        }

    }
}
