using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project3_FamousComposers
{
    public class Composer : IFormattable
    {
        // Declare class level variables
        private string name;
        private string title;
        private string year;
        private string location;
        private string synopsis;
        private string link;

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Constructor   Default constructor to create new instance of Composer class
        ' Date          11/24/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public Composer()
        {
            name = title = year = location = synopsis = link = string.Empty;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Constructor   Overloaded constructor to create new instance of Composer class
        ' Parameter     name--string 
        ' Parameter     title--string
        ' Parameter     year--string
        ' Parameter     location--string
        ' Parameter     synopsis--string
        ' Parameter     link--string
        ' Date          11/24/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public Composer(string name, string title, string year, string location, string synopsis, string link)
        {
            this.name = name;
            this.title = title;
            this.year = year;
            this.location = location;
            this.synopsis = synopsis;
            this.link = link;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Constructor   Composer()- overloaded copy constructor
        ' Description   Creates an instance of the Composer class-- copy of nextComposer
        ' Parameter     nextComposer--Composer 
        ' Date          11/24/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public Composer(Composer nextComposer)
        {
            name = nextComposer.name;
            title = nextComposer.title;
            year = nextComposer.year;
            location = nextComposer.location;
            synopsis = nextComposer.synopsis;
            link = nextComposer.link;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Method        Equals()
        ' Description   Overridden bool method to check if two composers are equal.
        '               Composers are considered equal if last names match.
        ' Date          11/24/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(this.GetType().Equals(obj.GetType())))
            {
                return false;
            }
            Composer nextComposer = (Composer)obj;
            if (this.name != nextComposer.name)
            {
                return false;
            }
            return true;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Method        GetHashCode()
        ' Description   Overridden GetHashCode.
        ' Return        hashCode--int
        ' Date          11/24/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Method        ToString()
        ' Description   Overridden ToString method to display composer info using 
        '               IFormattable with general (G) format and default culture
        ' Date          11/28/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Method        ToString()
        ' Description   ToString method to display composer info using IFormattable
        '               with application-defined format and default culture 
        ' Date          11/28/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public String ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ' Method        ToString()
        ' Description   ToString method to display composer info using IFormattable
        '               with application-defined format and default culture, defines
        '               formats G (general) and S (short) for displaying strings for 
        '               Composer class object.
        ' Date          11/28/2020
        ' Author        Laura Waite
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public String ToString(string format, IFormatProvider provider)
        {
            // If format is not defined in call to method, use G (general)
            if (String.IsNullOrEmpty(format)) format = "G";

            // In all cases, use default culture as this does not apply to straight string formatting
            if (provider == null) provider = CultureInfo.CurrentCulture;

            // Define formats, lowercase and uppercase should both be accepted
            switch (format.ToUpperInvariant())
            {
                // General format G
                case "G":
                    return  "Composer: " + name + Environment.NewLine +
                            "Title of notable composition: " + title + Environment.NewLine +
                            "Year composition cebuted: " + year + Environment.NewLine +
                            "Location of debut performance: " + location + Environment.NewLine +
                            "Synopsis: " + synopsis + Environment.NewLine +
                            "Link to YouTube: " + link;

                // Short format S, used for Delete input box form
                case "S":
                    return name + Environment.NewLine + title;
                
                // Formatting error for other string not defined
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }

        }
        // Get and Set Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Synopsis
        {
            get { return synopsis; }
            set { synopsis = value; }
        }

        public string Link
        {
            get { return link; }
            set { link = value; }
        }
    }
}
