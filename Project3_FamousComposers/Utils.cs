using System;
using System.Collections.Generic;
using System.Reflection;

namespace Project3_FamousComposers
{
    public static class Utils
    {
        // Declare class level variables
        private static bool error;
        public static string nameErrorMessage;
        public static string titleErrorMessage;
        public static string yearErrorMessage;
        public static string locationErrorMessage;
        public static string synopsisErrorMessage;
        public static string linkErrorMessage;

        public static void insertionSort(List<Composer> composers, String prop)
        {
            int i, j;
            if (prop == "Name")
            {
                for (i = 0; i < composers.Count; i++)
                {
                    Composer temp = composers[i];
                    j = i - 1;
                    while (j >= 0 && composers[j].Name.CompareTo(temp.Name) > 0)
                    {
                        composers[j + 1] = composers[j];
                        j--;
                    }
                    composers[j + 1] = temp;
                }
            }
            else if (prop == "Title")
            {
                for (i = 0; i < composers.Count; i++)
                {
                    Composer temp = composers[i];
                    j = i - 1;
                    while (j >= 0 && composers[j].Title.CompareTo(temp.Title) > 0)
                    {
                        composers[j + 1] = composers[j];
                        j--;
                    }
                    composers[j + 1] = temp;
                }
            }
        }

        public static void selectionSort(List<Composer> composers)
        {
            int min = 0;
            for (int i = 0; i < composers.Count; i++)
            {
                min = findMinimum(composers, i);
                Composer temp = composers[i];
                composers[i] = composers[min];
                composers[min] = temp;
            }
        }

        public static int findMinimum(List<Composer> composers, int i)
        {
            int j, min = i;
            for (j = i + 1; j < composers.Count; j++)
            {
                if (int.Parse(composers[j].Year) < int.Parse(composers[min].Year))
                    min = j;
            }
            return min;
        }

        public static int LinearSearch(List<Composer> composers, String composerName)
        {
            int index = -1;
            bool found = false;

            // Create string array of composer names
            String[] composerArray = new String[composers.Count];
            for (int i = 0; i < composerArray.Length; i++)
                composerArray[i] = composers[i].Name.ToLower();

            for (int i = 0; i < composerArray.Length && !found; i++)
            {
                if (composerArray[i].Contains(composerName.ToLower()))
                {
                    index = i;
                    found = true;
                }
            }
            return index;
        }

        public static int BinarySearch(List<Composer> composers, String compositionTitle)
        {
            // Sort list
            string prop = "Title";
            insertionSort(composers, prop);
            
            // Create string array of composition titles
            String[] titleArray = new String[composers.Count];
            for (int i = 0; i < titleArray.Length; i++)
            {
                titleArray[i] = composers[i].Title.ToLower();
                Console.WriteLine(titleArray[i].ToString());
            }
            // Convert entry to lower
            String comp = compositionTitle.ToLower();

            int low = 0;
            int high = titleArray.Length - 1;
            int middle;
            while (low <= high)
            {
                middle = (low + high) / 2;

                if (String.Compare(comp, titleArray[middle].ToString()) == 0)
                {
                    return middle;
                }
                else if (String.Compare(comp, titleArray[middle].ToString()) < 0)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }
            return -1;
        }

        public static bool ValidateName(List<Composer> composers, String name)
        {
            int nameParts = -1;
            int matchFound = -1;
            bool checkNext = true;

            // If name isn't null or empty string, start validation checks
            if (name != null || name != "")
            {
                // Convert string to char array, removing all spaces
                char[] fullname = name.ToCharArray();

                // First validation method - check for invalid characters
                while (checkNext)
                {
                    // First pass, check if chars are all letters
                    foreach (char ch in fullname)
                    {
                        if (char.IsLetter(ch) || char.IsWhiteSpace(ch))
                        {
                            checkNext = true;
                        }
                        else
                        {
                            if (ch.Equals('\'') || ch.Equals('-'))
                                {
                                    checkNext = true;
                                }
                            else
                                {
                                    // Invalid char found in array
                                    checkNext = false;
                                    error = true;
                                    nameErrorMessage = "Composer name may not contain numbers or special characters.";
                                    return error;
                                }
                        }
                    }
                    checkNext = false;
                 }

                // Second validation method - verify that name contains at least two parts (assumption is given name and surname)
                name = name.Trim();             // trim leading and trailing spaces
                nameParts = name.IndexOf(" ");  // find first space char in string

                // Third validation method - check for composer in existing DB
                if (nameParts > 0)
                {
                    matchFound = LinearSearch(composers, name);
                    if (matchFound != -1)
                    {
                        // Composer name already exists, composer cannot be added
                        error = true;
                        nameErrorMessage = "Composer already exists.";
                        return error;
                    }
                    else
                    {
                        // All checks passed, all is well! :)
                        error = false;
                        nameErrorMessage = String.Empty;
                        return error;
                    }

                }
                else
                {
                    // Name field contains partial name only, stop validation
                    error = true;
                    nameErrorMessage = "Please enter composer's full name.";
                    return error;
                }

            }
            else
            {
                // Name field not filled out, stop validation
                error = true;
                nameErrorMessage = "Please enter composer name.";
                return error;
            }
        }

        public static bool ValidateTitle(List<Composer> composers, String title)
        {
            int matchFound;

            if (title != null || title != "")
            {
                // Search list
                matchFound = BinarySearch(composers, title);

                if (matchFound == -1)
                {
                    // All checks passed, all is well! :)
                    error = false;
                    titleErrorMessage = String.Empty;
                    return error;
                }
                else
                {
                    // Title already exists, composer cannot be added
                    error = true;
                    titleErrorMessage = "Title already exists.";
                    return error;
                }
            }
            else
            {
                // Title field not filled out, stop validation
                error = true;
                titleErrorMessage = "Please enter title of composition.";
                return error;
            }
        }

        public static bool ValidateYear(String year)
        {
            if (year != null)
            {
                year = year.Trim();
                if (year != "")
                {
                    if (int.TryParse(year, out int debut))
                    {
                        if (debut > 2021 || debut < 1000)
                        {
                            // Year of debut is out of range
                            error = true;
                            yearErrorMessage = "Debut year must be after 1000 and before 2021";
                            return error;
                        }
                        else
                        {
                            // All checks passed, all is well! :)
                            error = false;
                            yearErrorMessage = "";
                            return error;
                        }
                    }
                    else
                    {
                        // Could not parse year
                        error = true;
                        yearErrorMessage = "Field must contain numbers only.";
                        return error;
                    }
                }
                else
                {
                    // Year is empty string
                    error = true;
                    yearErrorMessage = "Please enter a year for the composition's debut.";
                    return error;
                }
            }
            else
            {
                // Year is null string
                error = true;
                yearErrorMessage = "Please enter a year for the composition's debut.";
                return error;
            }
        }
        public static bool ValidateLocation(String location)
        {
            if (location != null)
            {
                location = location.Trim();
                if (location != "")
                {
                    char[] city = location.ToCharArray();
                    bool checkNext = true;
                    while (checkNext)
                    {
                        // Verify that string does not contain numbers
                        foreach (char ch in city)
                        {
                            if (!char.IsNumber(ch))
                            {
                                checkNext = true;
                            }
                            else
                            {
                                // Invalid char found in array
                                checkNext = false;
                                error = true;
                                locationErrorMessage = "Location field may not contain numbers.";
                            }
                        }
                        // All checks passed, all is well! :)
                        checkNext = false;
                        error = false;
                        locationErrorMessage = "";
                    }
                    return error;
                }
                else
                {
                    // Location is empty string
                    error = true;
                    locationErrorMessage = "Please enter a location for the composition's debut performance.";
                    return error;
                }
            }
            else
            {
                // Location is null string
                error = true;
                locationErrorMessage = "Please enter a location for the composition's debut performance.";
                return error;
            }
        }

        public static bool ValidateSynopsis(String synopsis)
        {
            if (synopsis.Length < 100)
            {
                error = true;
                synopsisErrorMessage = "Synopsis must be at least 100 characters.";
                return error;
            }
            else
            {
                error = false;
                synopsisErrorMessage = "";
                return error;
            }
        }

        public static bool ValidateLink(String link)
        {
            Uri uri = null;
            if (Uri.TryCreate(link, UriKind.Absolute, out uri))
            {
                if (link.Contains("youtube.com") || link.Contains("youtu.be"))
                {
                    error = false;
                    linkErrorMessage = "";
                    return error;
                }
                else
                {
                    error = true;
                    linkErrorMessage = "Please enter YouTube link.";
                    return error;
                }
            }
            else
            {
                error = true;
                linkErrorMessage = "Please enter valid link.";
                return error;
            }
        }
    }
}
