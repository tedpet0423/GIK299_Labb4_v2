namespace GIK299_Labb4;

public class Person
//Properties för de olika klasserna
{
    public DateTime Birthday { get; set; }
    public string EyeColor{ get; set; }
    public Gender TheGender{ get; set; }
    public Hair HairStyle{ get; set; }

    //constructor för de olika data om personen, tilldelar properties, skapar en "person"
    public Person(DateTime birthday, string eyeColor, Gender gender, Hair hair)
    {
        Birthday = birthday;
        EyeColor = eyeColor;
        TheGender = gender;
        HairStyle = hair;
    }

    public override string ToString()
        //overridear ToString för att returnera lämpliga värden
    {
        if (TheGender == Gender.NotAvailible)
        {
            return $"Date of Birth:        {Birthday:yyyy-MM-dd}" +
                   $"\nGender:               No gender specified" +
                   $"\nHair color:           {HairStyle.HairColor}" +
                   $"\nHair length:          {HairStyle.HairLength}" +
                   $"\nHair type:            {HairStyle.HairType}" +
                   $"\nEye color:            {EyeColor}";
        }
        
        {
            return $"Date of Birth:        {Birthday:yyyy-MM-dd}" +
                   $"\nGender:               {TheGender}" +
                   $"\nHair color:           {HairStyle.HairColor}" +
                   $"\nHair length:          {HairStyle.HairLength}" +
                   $"\nHair type:            {HairStyle.HairType}" +
                   $"\nEye color:            {EyeColor}";
        } 

    }
}