using System;
using System.Collections.Generic;
using System.Text;

namespace DZ5_IVT_21B_Nick_P._Var2
{
    class Address
    {
        public string Country;
        string Area;
        public string City;
        string Street;
        int Building;
        int PostalСode;
        public Address(string Area, string City, string Street, int Building, int PostalСode)
        :
            this("Россия", Area, City, Street, Building, PostalСode)
        { 
        }
        public Address(string Country, string Area, string City, string Street, int Building, int PostalСode)
        {
            this.Country = Country;
            this.Area = Area;
            this.City = City;
            this.Street = Street;
            this.Building = Building;
            this.PostalСode = PostalСode;
            if(Country != "Россия" && 
                Country != "Украина" && 
                Country !=  "Казахстан" && 
                Country != "Беларусь")
            {
                throw new Exception("Неверно указана страна");
            }
            if(Country == "Россия" && (PostalСode < 100000 || PostalСode > 1000000))
            {
                throw new Exception("Почтовый номер должен состоять из 6-ти цифр");
            }
        }
        public Address(string Area, string City, int Building, int PostalСode)
        :
            this("Россия", Area, City, "" , Building, PostalСode)
        {
        }
        public override string ToString()
        {
            if (Street.Length == 0)
            {
                return $"Страна: {Country}, Область: {Area}, Город: {City}, Дом: {Building}, Почтовый Индекс: {PostalСode}";
            }
            return $"Страна: {Country}, Область: {Area}, Город: {City}, Улица: {Street}, Дом: {Building}, Почтовый Индекс: {PostalСode}";
        }
    }
    
}
