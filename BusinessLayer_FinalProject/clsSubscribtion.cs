using DataAcciss_GymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FinalProject
{
    public class clsSubscribtion
    {
        enum enMode { AddNew=0 , UpdateNew=1}   
        enum enProOrNot { Default = 0, Pro =1}
        enMode Mode = enMode.AddNew;
        public int SubscribtionID {  get; set; }
        public int SubsicribtionTypeID {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MemberID {  get; set; } 

        public clsClient Client;

        public decimal Cash { get; set; }
        public decimal remainder { get { return SubscribtionType.Price - Cash; } }
        public int CoachID { get; set; }
      
        public SubscribtionsTypeBusiness SubscribtionType;

                      
        public clsSubscribtion( )
        {
            this.SubscribtionID = -1;
            this.CoachID = -1;
            this.SubsicribtionTypeID = -1;
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.MemberID = -1;
            Mode = enMode.AddNew;
        }
         private clsSubscribtion(int SubscribtionID,int SubscribtionTypeID,
                                  DateTime StartDate,DateTime EndDate,int MemberID,
                                  decimal Cash, decimal remainder,int CoachID)
        {
            this.SubscribtionID= SubscribtionID;
            this.SubsicribtionTypeID = SubscribtionTypeID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.MemberID = MemberID;
            this.Cash = Cash;
            this.CoachID = CoachID;
            this.Mode = enMode.UpdateNew;
            SubscribtionType = SubscribtionsTypeBusiness.Find(SubsicribtionTypeID);
            Client = clsClient.FindClient(MemberID);

        }


        private bool _AddNewSubscribtion()
        {
            this.SubscribtionID = clsSubscribtionsData.AddNewSubscribtion(this.SubsicribtionTypeID,this.StartDate,
                                                                          this.EndDate,this.MemberID,this.Cash,
                                                                           this.remainder,this.CoachID);
            return this.SubscribtionID != -1;
        }

        private bool _UpdateSubscribtion()
        {
            return clsSubscribtionsData.UpdateSubscribtion(this.SubscribtionID,this.SubsicribtionTypeID,this.StartDate,this.EndDate,this.MemberID,
                                                            this.Cash,this.remainder,this.CoachID );
        }

        public static clsSubscribtion FindSubscribtionByID(int SubscribtionID)
        {
            int SubscribtionTypeID = -1;
            int MemberID = -1;
            decimal Cash = 0;
             decimal remainder = 0;
            int CoachID = -1;
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;

            if(clsSubscribtionsData.GetSubscribtionIfoByID(SubscribtionID,ref SubscribtionTypeID,ref StartDate,
                                                            ref EndDate,ref MemberID,ref Cash,ref remainder,ref CoachID))
            {
                return new clsSubscribtion(SubscribtionID, SubscribtionTypeID, StartDate,
                                            EndDate,MemberID,Cash,remainder,CoachID);
            }
            else 
            { 
                return null;
            }
        }



        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSubscribtion())
                    {
                        Mode = enMode.UpdateNew;
                        return true;
                    }
                    else
                        return false;

                case enMode.UpdateNew:
                    return _UpdateSubscribtion();
            }
            return false;
        }

        public static DataTable GetAllSubscribtions()
        {
           return clsSubscribtionsData.GetAllSubscribtions();
        }

        static public  bool  IsSubscribtionExist(int SubscribtionID)
        {
            return clsSubscribtionsData.IsSubscribtionExist(SubscribtionID);
        }

        public static bool DeleteSubscribtion(int SubID)
        {
            return clsSubscribtionsData.DeleteSubscribtion(SubID);
        }
        static public bool IsSubscribtionExistByMemberID(int MemberID)
        {
            return clsSubscribtionsData.IsSubscribtionExistByMemberID(MemberID);
        }

    }
}
