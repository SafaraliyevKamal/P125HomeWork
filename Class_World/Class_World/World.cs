namespace Class_World
{
    class World
    {

        public string Capital; 
        public string OfficialLanguage;
        public double Area; 
        public double Population; 
        public string Currency; 
        public string Country; 

        public World()
        {
        }

        public string WordDetail()
        {
            return $" \nCountry: {Country}" +
                   $"\nCapital: {Capital}" +
                   $" \nOfficial language: {OfficialLanguage} " +
                   $"\nArea: {Area}km " +
                   $"\nPopulation:{Population} people " +
                   $"\nCurrency: {Currency}";
                 
        }

    }
}
