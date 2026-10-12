using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Busniss_Layer
{
    public class CLS_User
    {
        public enum enum_mode { ADD_new = 0,update = 1};
        public enum_mode Mode = enum_mode.ADD_new;

        public int User_ID { get; set; }
        public int Person_ID {  get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public bool IS_Activ {  get; set; }
        
        public CLS_Person Personinfo;


        public CLS_User()
        {
            this.User_ID = -1;
            this.User_Name = " ";
            this.Password = " ";
            this.IS_Activ = true;
            Mode = enum_mode.ADD_new; 
        }
        private CLS_User(int userID, int PersonID , string UserNAme, string password ,
            bool IS_Activ)
        {
            Personinfo = CLS_Person.find_by_ID(PersonID);
            this.User_ID = -1;
            this.User_Name = " ";
            this.Password = " ";
            this.IS_Activ = true;
            Mode = enum_mode.update;
        }
        public static CLS_User Find_User(string userName, string password)
        {
             int userID = -1 , personID = -1; bool IS_Activ = false;
            
            bool IS_found = Data_Layer.User.User_info_by_USER_AND_Password(userName, password,ref userID ,
                ref personID,ref IS_Activ);

            if (IS_found)
            {
                return new CLS_User (userID,personID,userName,password,IS_Activ);
            }
            else
            {
                return null;
            }
        }
    }
}
