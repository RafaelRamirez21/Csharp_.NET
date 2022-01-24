using System;
namespace CoreSchool.Entities
{   
    class School
    {
        string name=string.Empty;
        public string Name 
        { 
            get{return name;}
            set{name=value.ToUpper();}

        }
        public int CreationYear{get;set;}

        public string Country { get; set; }
        public string City { get; set; }
        private int myVar;
        // public School(string name,int year)
        // {
        //     this.name=name;
        //     this.CreationYear=year;
        // }
        public SchoolTypes SchoolType{get;set;}
        public List<Course> Courses { get; set; }
        public School(string name,int year)=>(Name,CreationYear)=(name,year);
        public School(string name,int year,
                            SchoolTypes type,
                            string country="",
                            string city="")
        {
            (Name,CreationYear)=(name,year);
            this.City=city;
            this.Country=country;
            
        }
        
        public override string ToString()
        {
            return $"Name : \"{this.Name}\",{System.Environment.NewLine} Type : {this.SchoolType} \n Country : {this.Country}, City : {this.City}";
        }


    }
}