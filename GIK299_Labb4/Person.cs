namespace GIK299_Labb4;

public class Person
//Properties för de olika klasserna
{
    public string Birthday { get; set; }
    public string EyeColor{ get; set; }
    public Gender TheGender{ get; set; }
    public Hair HairStyle{ get; set; }

    //constructor för de olika data om personen, tilldelar properties, skapar en "person"
    public Person(string birthday, string eyecolor, Gender gender, Hair hair)
    {
        Birthday = birthday;
        EyeColor = eyecolor;
        TheGender = gender;
        HairStyle = hair;
    }

    public override string ToString()
        //overridear ToString för att returnera lämpliga värden
    {
        if (TheGender == Gender.NotAvailible)
        {
            return $"Date of Birth:       {Birthday}" +
                   $"\nGender:              No gender specified" +
                   $"\nHaircolor:           {HairStyle.HairColor}" +
                   $"\nHairlength:          {HairStyle.HairLength}" +
                   $"\nHairtype:            {HairStyle.HairType}" +
                   $"\nEyecolor:            {EyeColor}";
        }
        
        {
            return $"Date of Birth:       {Birthday}" +
                   $"\nGender:              {TheGender}" +
                   $"\nHaircolor:           {HairStyle.HairColor}" +
                   $"\nHairlength:          {HairStyle.HairLength}" +
                   $"\nHairtype:            {HairStyle.HairType}" +
                   $"\nEyecolor:            {EyeColor}";
        }

    }
}