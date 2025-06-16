using DataAcciss_GymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_FinalProject
{
    public class SubscribtionsTypeBusiness
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int SubscribtionTypeID { set; get; }
        public string Name { set; get; }
        public string Details { set; get; }
        public short Period { set; get; }
        public Decimal Price { set; get; }
        private SubscribtionsTypeBusiness()
        { 
            this.SubscribtionTypeID = -1;
            this.Name = string.Empty;
            this.Details = string.Empty;
            this.Period = 0;
            this.Price = 0.0m;
            Mode = enMode.AddNew;
        }

        public SubscribtionsTypeBusiness(int SubscribtionTypeID,string Name,string Details, short Period, Decimal Price)
        {
            this.SubscribtionTypeID= SubscribtionTypeID;
            this.Name = Name;
            this.Details = Details;
            this.Period = Period;
            this.Price = Price;
            Mode = enMode.Update;
        }

        private bool _UpdateSubscribtionType()
        {
            return clsSubscribtionType.UpdateSubscribtionType(this.SubscribtionTypeID,
                                                               this.Name,this.Period,this.Details,this.Price);
        }


        public static SubscribtionsTypeBusiness Find(int TypeID)
        {
            string Name = "";
            string Details = "";
            short Period = 0;
            Decimal Price = 0.0m;
            if (clsSubscribtionType.GetSubscribeTypeByID(TypeID,ref Name,ref Period,ref Details,ref Price) )
            {
                  return new SubscribtionsTypeBusiness(TypeID,Name,Details,Period,Price);
            }
            else
                return null;
        }

        public static SubscribtionsTypeBusiness FindByName(string TypeName)
        {
            int TypeID = -1;
            string Details = "";
            short Period = 0;
            Decimal Price = 0.0m;
            if (clsSubscribtionType.GetSubscribeTypeByName(ref TypeID, TypeName, ref Period, ref Details, ref Price))
            {
                return new SubscribtionsTypeBusiness(TypeID, TypeName, Details, Period, Price);
            }
            else
                return null;
        }

        public static DataTable GetAllSubscribtionType()
        {
           return clsSubscribtionType.GetAllSubscribtionType();
        }

        public bool Save()
        {
            if(Mode == enMode.Update)
            {
                if (_UpdateSubscribtionType())
                    return true;
            }
            return false; 
        }

    }
}
