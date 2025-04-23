public class Child : Person
{
    // dane
    public Person Mother {get; }
    public Person Father {get; }

    public new int Age
    {
        get=> base.Age;
        private set{
        if (value > 15)
        {
            throw new ArgumentException("Child’s age must be less than 15!");
        }
        
        base.Age = value;
        }
    }

    // konstruktor
    public Child(
        string firstName,
        string familyName,
        int age,
        Person mother = null,
        Person father = null
        )
    // : base(nazwisko, imie, dataUrodzenia
    : base(firstName, familyName, age)

    {
        if (age > 15)
        {
            throw new ArgumentException("Child’s age must be less than 15!");
        }

        Mother = mother;
        Father = father;

    }


    // tekstowa reprezentacja obiektu
    public override string ToString()
    {
        string stringOutput = $"{FamilyName} {FirstName} ({Age})" + "\n"; 
        // string stringOutput = $"{FirstName} {FamilyName} ({Age})" + "\n"; 

        stringOutput += "mother: ";
        stringOutput +=  Mother != null? Mother.ToString() : "No data";
        stringOutput += "\n";

        stringOutput += "father: ";
        stringOutput +=  Father != null? Father.ToString() : "No data";

        return stringOutput;
    }

    // Metody
    public override void modifyAge(int age)
    {
                if (age > 15)
        {
            throw new ArgumentException("Child’s age must be less than 15!");
        }
        base.modifyAge(age);
    }

    public override void modifyFirstName(string firstName)
    {
        FamilyName = firstName;
    }
}