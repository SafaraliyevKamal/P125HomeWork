using System;
namespace Class_World
{
     class Azerbaijan : World 
     {
        public string postcode;

        public Azerbaijan(string capital,string oficiallanguage, double area, double population, string currency, string postcode)
        {
            this.Country = "Azerbaijan";
            this.Capital = capital;
            this.OfficialLanguage = oficiallanguage;
            this.Area = area;
            this.Population = population;
            this.Currency = currency;
            
            this.postcode = postcode;


        }

        public string AzeDetail()
        {
            return $"{WordDetail()} \nPost code: {postcode}";
        }
        
    }
}
