using System;
class RoomNames
{
    static void Main(string[] args)
    {
        string[] rooms = { " kitchen ", "BEDROOM", "", "  living room", "bathroom  " };
        foreach(string name in rooms)
        {
            string cleanName=CleanNames(name);
            
            if(cleanName !="")
            {
                Console.WriteLine(cleanName);
            }
        }





    }
    static string CleanNames(string name)
    {
        string trimmed = name.Trim();

        if (trimmed=="")
        {
            return "";
        }
        string lower=trimmed.ToLower();
        string firstletter=trimmed.Substring(0,1).ToUpper();
        string rest=trimmed.Substring(1).ToLower();

        return firstletter + rest;


    }

}