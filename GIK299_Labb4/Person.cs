namespace GIK299_Labb4;

public class Person
//Properties för de olika klasserna
{
    public DateTime Birthday { get; private set; }
    public string EyeColor{ get; private set; }
    public Gender TheGender{ get; private set; }
    public Hair HairStyle{ get; private set; }

    //constructor för de olika data om personen, tilldelar properties, skapar en "person"
    public Person(DateTime birthday, string eyecolor, Gender gender, Hair hair)
    {
        Birthday = birthday;
        EyeColor = eyecolor;
        TheGender = gender;
        HairStyle = hair;
    }

    public override string ToString()
        //overridear ToString för att returnera lämpliga värden
    {
        return $"Date of Birth: {Birthday:yyyy/MM/dd}" +
               $"\nGender: {TheGender}" +
               $"\nHairstyle: {HairStyle.HairColor}, {HairStyle.HairLength} and {HairStyle.HairType}" +
               $"\nEyecolor: {EyeColor}";

    }
}