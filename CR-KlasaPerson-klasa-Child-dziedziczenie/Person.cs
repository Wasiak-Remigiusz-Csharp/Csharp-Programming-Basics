public class Person
{
    // dane
    private string _firstName;
    private string _familyName;
    private int _age;


    public string FirstName
    {
        get=> _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Wrong name!");
            }

            value = value.Trim();
            if (!IsCorrect(value))
            {
                throw new ArgumentException("Wrong name!");
            }

            string correctString = CheckEmpty(value);
            _firstName =  char.ToUpper(correctString[0]) + correctString.Substring(1).ToLower();
        }
    }

    public string FamilyName
    {
        get=> _familyName;
        set
        {   
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Wrong name!");
            }
            
            value = value.Trim();
            
            if (!IsCorrect(value))
            {
                throw new ArgumentException("Wrong name!");
            }

            string correctString = CheckEmpty(value);
            _familyName = char.ToUpper(correctString[0]) + correctString.Substring(1).ToLower();
        }
    }

    public int Age
    {
        get=> _age;
        set
        {
        if (value <= 0)
        {
            throw new ArgumentException("Age must be positive!");
        }
        
        _age = value;
        }
    }

    // konstruktor
    public Person(string familyName, string firstName, int age)
    {
        FirstName = firstName;
        FamilyName = familyName;
        Age = age;
    }

    // testowa reprezentacja obiektu
    public override string ToString()
    {
        return $"{FirstName} {FamilyName} ({Age})";
     }




    // meotody

    private bool IsCorrect( string value)
    {
        bool info;
        foreach (var letter in value)
        {
            if (!char.IsLetter(letter) && letter != ' ')
            {
                info = false;
                return info;
            }
        }

        info = true;
        return info;
    }

    private string CheckEmpty( string value)
    {

        foreach (var letter in value)
            {
                if (letter == ' ')
                {
                    value = value.Replace(" ", string.Empty);
                }
            }
        return value;
    }

    // modifyFirstName, modifyFamilyName, modifyAge.
    public virtual void modifyFirstName(string firstName)
    {
        FirstName = firstName;
    }

    public void modifyFamilyName(string familyName)
    {
        FamilyName = familyName;
    }

    public virtual void modifyAge(int age)
    {
        Age = age;
    }
}

