using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ObjectOrientedExample
{
    class Course
    {
        public String COURSELECTURER { get; set; }

        private String name; //Course name ozelligindeki fonksiyonlara gore name'e ataniyor.

        public String COURSENAME
        {
            get { return name; }
            set
            {
                if (value == "")
                    name = "unknown";
                else
                    name = value;
            }
        }
         
        private String email; //Course email ozelligindeki fonksiyonlara gore email atanicak.

        public String COURSEMAIL
        {
            get { return email; }
            set
            {
                String rule = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"; //internetten aldik, basina @ koydugumuz \n gibi string icinde varolan kurallari yok saydiriyoruz.
                if (String.IsNullOrWhiteSpace(value))
                    email = "unknown";//bossa unknown
                else if (Regex.IsMatch(value, rule)) //regular expression kutuphanesini cagirdik
                    email = value; //kurala uyuyorsa ekle
                else
                    email = "Invalid"; //uymuyorsa invalid
            }
        }
        public override string ToString()
        {
            //return base.ToString(); buradaki base super demek
            return COURSENAME + "-" + COURSEMAIL + "-" + COURSELECTURER;
        }
    }
}
