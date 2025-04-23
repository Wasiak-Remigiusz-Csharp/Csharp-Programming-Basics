public class Person
{
    //dane
    private string _firstName;
    private string _familyName;
    private DateTime _birthday;


    public string FirstName 
    {
        get => _firstName;
        set
        {
            if (value == null)
            {
                throw new ArgumentException("Incorrect data for FirstName");
            }

            value = value.Trim();
            if (!IsCorrectFirstName(value))
            {
                throw new ArgumentException("Incorrect data for FirstName");
            }

            _firstName = value;
        } 
    }


    public string FamilyName 
    {
        get => _familyName;
        set
        {
            if (value == null)
            {
                throw new ArgumentException("Incorrect data for FamilyName");
            }

            value = value.Trim();
            
            if (!IsCorrectFamilyName(value))
            {
                throw new ArgumentException("Incorrect data for FamilyName");
            }


            _familyName= value;
        } 
    }


    public DateTime Birthday 
    {
        get => _birthday;
        set
        {
            DateTime thisDay = DateTime.Today;
            if (value>=thisDay)
            {
                throw new ArgumentException("Incorrect data for Birthday");
            }
            _birthday = value;
        }
    }
    

    // konstruktor-y
    public Person(string familyName, string firstName, DateTime birthday)
    {
        FirstName = firstName;
        FamilyName = familyName;
        Birthday = birthday;
    }


    // tekstowa reprezentacja obiektu
    public override string ToString()
    {
        return $"{FirstName} {FamilyName} ({Birthday:yyy-MM-dd})";
    }

    // metody

    private bool IsCorrectFirstName(string value)
    {
        return IsValidPartName(value);
    }

    private bool IsCorrectFamilyName(string value)
    {
        bool isCorrect;
        var parts = value.Split('-');

        if (parts.Length > 2)
        {
            isCorrect = false;
            return isCorrect;
        }

        
         foreach (var partFamilyName  in parts)
        {
            if (!IsValidPartName(partFamilyName))
            {
                isCorrect = false;
                return isCorrect;
            }
        }

        isCorrect = true;
        return isCorrect;
    }

    private bool IsValidPartName(string value)
    {
        bool isCorrect;
        if (value.Length >=2 
            && char.IsUpper(value[0]) 
            && IsAllLetters(value))
        {
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }

        return isCorrect;
    }

    private bool IsAllLetters(string value)
    {
        bool isCorrect;

        foreach (var letter in value)
        {
            if (!char.IsLetter(letter))
            {
                isCorrect = false;
                return isCorrect;
            }
        }

        isCorrect = true;
        return isCorrect;
    }





}