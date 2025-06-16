using DataAcciss_GymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FinalProject
{
    public class clsClient
    {
        enum enMode { AddNew =0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public int MemberID { get; set; }
        public int PersonID { get; set; }
        public string EmergencyPhone { get; set; }
        public decimal BodyWeight { get; set; }
        public bool IsActive { get; set; }
        public decimal Length { get; set; }
        public  clsPerson _Person;
     
       public clsClient()
        {
            MemberID = -1;
            PersonID = -1;
            EmergencyPhone = string.Empty;
            BodyWeight = 0;
            IsActive = false;
            Length = 0;
            Mode = enMode.AddNew;
        }

        private clsClient(int MemberID,int PersonID,string EmergencyPhone,decimal BodyWeight,
                            bool IsActive,decimal Length)
        {
            this.MemberID = MemberID;
            this.PersonID = PersonID;
            this.EmergencyPhone = EmergencyPhone;
            this.BodyWeight = BodyWeight;
            this.IsActive = IsActive;
            this.Length = Length;
            _Person = clsPerson.Find(this.PersonID);
            Mode = enMode.Update;
        }


        private bool _AddNewClient()
        {
            this.MemberID = clsClientData.AddNewClient(this.PersonID, this.EmergencyPhone,this.BodyWeight,
                                                       this.IsActive,this.Length);
            return this.MemberID != -1;
        }


        private  bool _UpdateClient()
        {
            return clsClientData.UpdateClient(this.MemberID,this.PersonID,this.EmergencyPhone,this.BodyWeight,
                                  this.IsActive,this.Length);
        }

       public static clsClient FindClient(int MemberID)
        {
            int PersonID = -1;
            string EmergencyPhone = "";
            decimal BodyWeight = 0;
            bool IsActive = false;
            decimal Length = 0;
            if (clsClientData.GetClientInfoByID(MemberID, ref PersonID, ref EmergencyPhone, ref BodyWeight, ref IsActive, ref Length))
            {
                return new clsClient(MemberID, PersonID, EmergencyPhone, BodyWeight, IsActive, Length);
            }
            else
                return null;
        }

        public static clsClient FindClientByPersonID(int PersonID)
        {
            int MemberID = -1;
            string EmergencyPhone = "";
            decimal BodyWeight = 0;
            bool IsActive = false;
            decimal Length = 0;
            if (clsClientData.GetClientInfoByPersonID(ref MemberID,PersonID, ref EmergencyPhone, ref BodyWeight, ref IsActive, ref Length))
            {
                return new clsClient(MemberID, PersonID, EmergencyPhone, BodyWeight, IsActive, Length);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode) {
            
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }
                case enMode.Update:
                    return _UpdateClient();
            }
            return false;
        }


        public static DataTable GetAllClients()
        {
            return clsClientData.GetAllClients();
        }

        public static bool DeleteClient(int MemberID)
        {
            return clsClientData.DeleteClient(MemberID);
        }

        public static bool IsClientExist(int MemberID)
        {
            return clsClientData.IsClientExist(MemberID);
        }

        public static bool IsClientExistbyPersonID(int PersonID)
        {
            return clsClientData.IsClientExistByPersonID(PersonID);
        }












    }
}
