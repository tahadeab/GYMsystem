using DataAcciss_GymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FinalProject
{
    public class clsUsers
    {
        enum enMode {AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public int UserID { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        clsPerson _Person; 

        public clsUsers()
        {
            this.UserID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = true;
            Mode = enMode.AddNew;
        }

        private clsUsers(int UserID,int PersonID,string UserName,string Password,bool IsActive)
        {
            this.PersonID = PersonID;
            this.UserID = UserID;   
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this._Person = clsPerson.Find(PersonID);
            
            Mode = enMode.Update;


        } 

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public static clsUsers FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByUserID
                                (UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        public static clsUsers FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByPersonID
                                (PersonID, ref UserID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                return new clsUsers(UserID, UserID, UserName, Password, IsActive);
            else
                return null;
        }
        public static clsUsers FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;

            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword
                                (UserName, Password, ref UserID, ref PersonID, ref IsActive);

            if (IsFound)
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool isUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool isUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        public static bool isUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }





    }
}
