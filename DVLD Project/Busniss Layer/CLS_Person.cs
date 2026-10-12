using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Busniss_Layer
{
    public class CLS_Person
    {
        public enum Enum_mode { ADD_New = 0, Updata = 1 }
        public Enum_mode Mode = Enum_mode.ADD_New;

        public int personID {  get; set; }
        public string First_name { get; set; }
        public string  Second_name { get; set; }
        public string Third_name {  get; set; }
        public string Last_name {  get; set; }
        public string Full_name
        {
            get { return First_name + ' ' + Second_name + ' ' + Third_name + ' ' + Last_name; }
        }
        public DateTime Birth_Date { get; set; }
        public string email { get; set; }
        public string National_No { get; set; }
        public string Phone_Number {  get; set; }
        public short Gendor {  get; set; }
        public string Image_Path { get; set; }
        public string Address {  get; set; }
        public int National_countryID {  get; set; }


        public CLS_Person()

        {
            this.personID = -1;
            this.First_name = "";
            this.Second_name = "";
            this.Third_name= "";
            this.Last_name = "";
            this.Birth_Date = DateTime.Now;
            this.Address = "";
            this.Phone_Number = "";
            this.email = "";
            this.National_countryID = -1;
            this.Image_Path = "";

            Mode = Enum_mode.ADD_New;
        }

        private CLS_Person(int PersonID, string FirstName, string SecondName, string ThirdName,
            string LastName, string NationalNo, DateTime DateOfBirth, short Gendor,
             string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.personID=PersonID;
            this.First_name=FirstName;
            this.Second_name=SecondName;
            this.Third_name=ThirdName;
            this.Last_name=LastName;
            this.email=Email;
            this.Birth_Date=DateOfBirth;
            this.Address = Address;
            this.National_countryID = NationalityCountryID;
            this.Phone_Number=Phone;
            this.Image_Path=ImagePath;
            this.National_No=NationalNo;
            this.Gendor=Gendor;
        }
        public static CLS_Person find_by_ID (int ID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            short Gendor = 0;

            bool IS_found = Data_Layer.Person.Find_By_ID(ID,ref FirstName,ref SecondName,ref ThirdName, ref LastName,
                ref NationalNo, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IS_found)
            {
                return new CLS_Person(ID, FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gendor,
             Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static CLS_Person Find_by_NationalNo(string NationalNo)
        {
            int ID = -1, NationalityCountryID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "",
                Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gendor = 0;

            bool IS_found = Data_Layer.Person.Find_By_NationalNO(NationalNo, ref ID, ref FirstName,ref SecondName, ref ThirdName,ref LastName,
                ref DateOfBirth , ref Gendor, ref Address, ref Phone,ref Email, ref NationalityCountryID,ref ImagePath);

            if (IS_found)
            {
                return new CLS_Person(ID, FirstName, SecondName, ThirdName, LastName, NationalNo,
                    DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static DataTable Get_People()
        {
            return Data_Layer.Person.GET_All_Person();
        }
    }
}
