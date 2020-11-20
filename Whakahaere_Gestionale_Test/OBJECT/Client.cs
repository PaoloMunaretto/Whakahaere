using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Whakahaere
{
    public class Client
    {
        int iD;
        string name;
        string surname;
        string fiscalCode;
        DateTime dateBirth;
        string typeDocument;
        string codeDocument;
        int paymentMetod;
        Payments paymentOBJ = new Payments();
        string telephone;
        string email;
        string street;
        string city;
        string province;
        int cap;
        string country;
        string p_IVA;
        string company;
        string companyStreet;
        string companyCity;
        string companyProvince;
        string companyCAP;
        string companyCountry;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string FiscalCode { get => fiscalCode; set => fiscalCode = value; }
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public string TypeDocument { get => typeDocument; set => typeDocument = value; }
        public string CodeDocument { get => codeDocument; set => codeDocument = value; }
        public int PaymentMetod { get => paymentMetod; set => paymentMetod = value; } //ID oggetto Payment
        public Payments PaymentOBJ { get => paymentOBJ; set => paymentOBJ = value; }// Oggetto Payment con i dati del pagamento
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
        public int CAP { get => cap; set => cap = value; }
        public string Country { get => country; set => country = value; }



        //Company information
        public string P_IVA { get => p_IVA; set => p_IVA = value; }
        public string Company { get => company; set => company = value; }
        public string CompanyStreet { get => companyStreet; set => companyStreet = value; }
        public string CompanyCity { get => companyCity; set => companyCity = value; }
        public string CompanyProvince { get => companyProvince; set => companyProvince = value; }
        public string CompanyCAP { get => companyCAP; set => companyCAP = value; }
        public string CompanyCountry { get => companyCountry; set => companyCountry = value; }
    }
}
