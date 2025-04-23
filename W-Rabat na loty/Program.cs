using System;

public class Program
{
    public static DateTime GetClientBirthday()
    {
        Console.Write("Podaj swoją datę urodzenia w formacie RRRR-MM-DD: ");
        string inputBirthday = Console.ReadLine();


        if (DateTime.TryParse(inputBirthday, out DateTime parsedBirthday) == false)
        {
            Console.WriteLine("Podałeś niepoprawny format daty. Proszę podaj poprawną datę.");
            return GetClientBirthday();
        }
        else if (parsedBirthday >= DateTime.Today )
        {
            Console.WriteLine("Data urodzenia nie może być większa lub równa od dnia dzisiejszego. Proszę podaj poprawną datę.");
            return GetClientBirthday();
        }
        
        return parsedBirthday;
    }

    public static DateTime GetClientFlightDay()
    {
        Console.Write("Podaj datę lotu w formacie RRRR-MM-DD: ");
        string inputFlightDay = Console.ReadLine();


        if (DateTime.TryParse(inputFlightDay, out DateTime parsedFlightDay) == false)
        {
            Console.WriteLine("Podałeś niepoprawny format daty. Proszę podaj poprawną datę.");
            return GetClientFlightDay();
        }
        else if (parsedFlightDay < DateTime.Today )
        {
            Console.WriteLine("Data lotu nie może być mniejsza od dnia dzisiejszego. Proszę podaj poprawną datę.");
            return GetClientFlightDay();
        }

        return parsedFlightDay;
    }

    public static bool GetClientAnswer(string inputQuestion)
    {

        Console.Write(inputQuestion);
        string answer = Console.ReadLine();
        
        if (string.Equals(answer, "t", StringComparison.OrdinalIgnoreCase)) 
            return true;
        else if (string.Equals(answer, "n", StringComparison.OrdinalIgnoreCase))
             return false; 
        else
            Console.WriteLine("Odpowiedź jest niepoprawna. Proszę podaj poprawną odpowiedź.");
            return GetClientAnswer(inputQuestion);
    }

    public static bool GetDataDiff(DateTime bookingDate, DateTime clientFlightDay)
    {   
        int diff = ((clientFlightDay.Year - bookingDate.Year) * 12) + (clientFlightDay.Month - bookingDate.Month);

        if (diff >= 5) 
            return true;
        else 
            return false;
    }

    public static void printReport(DateTime clientBirthday, DateTime clientFlightDay, bool isDomesticFlight,
                                        bool isRegularClient, bool isEarlyBooking, int clientAge, bool isSeason, int discount)
    {
        Console.WriteLine("\n=== Do obliczeń przyjęto:");
        Console.WriteLine($" * Data urodzenia: {clientBirthday:dd.MM.yyyy}");
        Console.WriteLine($" * Data lotu: {clientFlightDay:dddd, dd MMMM yyyy}. {(isSeason ? "Lot w sezonie" : "Lot poza sezonem")}");  
        Console.WriteLine($" * {(isDomesticFlight ? "Lot krajowy" : "Lot międzynarodowy")}");  
        Console.WriteLine($" * Stały klient: {(isRegularClient &&  clientAge >=18 ? "Tak" : "Nie")}"); 

        Console.WriteLine($"\nPrzysługuje Ci rabat w wysokości: {discount}%");
        Console.WriteLine($"Data wygenerowania raportu: {DateTime.Now}");
    }

    public static int GetClientAge(DateTime today, DateTime clientBirthday)
    {
        int age = today.Year - clientBirthday.Year;
        return age;
    }

    public static bool GetIsSeason(DateTime clientFlightDay)
    {
        if ((clientFlightDay.Day >= 20  && clientFlightDay.Month == 12) || (clientFlightDay.Day  <= 10  && clientFlightDay.Month == 1)
            ||  (clientFlightDay.Day >= 20  && clientFlightDay.Month == 03) || (clientFlightDay.Day  <= 10  && clientFlightDay.Month == 04) 
                ||  (clientFlightDay.Month == 07)  || (clientFlightDay.Month == 08)) 
                    return true;
        return false;
    }

    public static int GetDiscount(DateTime clientFlightDay, bool isDomesticFlight, bool isRegularClient, 
                                    bool isEarlyBooking, int clientAge,  bool isSeason)
    {
        // DISCOUNTS LIST:
        // Basic Discounts -- per age
        int isInfantDomesticFlighDisc = 80;  // > 2
        int isInfantIntFlighDisc = 70;  // > 2
        int isChildDisc  = 10;  // >= 2 and < 16
        int isAdultDisc  = 0;  // >= 18

        // Regular client discount
        int regularClientDisc = 15; // only for >= 18 age

        //  Discount (%) for bookings made more than 5 months in advance
        int earlyBookingDisc = 10;

        //  Discount applies to international flights outside high season
        int offSeasonDisc = 15;

        // Max Discount:
        int maxInfantDisc = 80; // > 2
        int maxChildDisc  = 30; // >= 2 and < 16
        int maxAdultDisc  = 30; // >= 18

        int discount = 0;

        // DECISION TABLE -  calculation:
        // 1. Basic Discounts
        if (clientAge < 2)
            if (isDomesticFlight)
                   discount+= isInfantDomesticFlighDisc;
            else
                discount+= isInfantIntFlighDisc;
        else if (clientAge >= 2 && clientAge <= 16)
            discount+= isChildDisc;
        else if (clientAge >= 18)
            discount+= isAdultDisc;

        // 2. Regular client discount
        if (clientAge >= 18 && isRegularClient)
            discount+= regularClientDisc;

        // 3. Discount (%) for bookings made more than 5 months in advance
        if (isEarlyBooking) discount+= earlyBookingDisc;

        //  4. Discount applies to international flights outside high season
        if (!isDomesticFlight && !isSeason) discount+= offSeasonDisc;

        // 5. No discounts for international flights unless the passenger is an infant or the flight is off-season
        if (isSeason && clientAge >=2 && isDomesticFlight == false)   discount= 0;

        // 6. Check max Discount:
        if ( (clientAge < 2) && discount > maxInfantDisc)
            discount= maxInfantDisc;
        else if ((clientAge >= 2 && clientAge <= 16) && (discount > maxChildDisc))
            discount= maxChildDisc;
        else if (clientAge >= 18 && discount > maxAdultDisc)
            discount= maxAdultDisc;
        
        return discount;
    }


    public static void Main()
    {
        // Variables - get entry info
        DateTime clientBirthday = GetClientBirthday();
        DateTime clientFlightDay = GetClientFlightDay();
        bool isDomesticFlight =  GetClientAnswer("Czy lot jest krajowy (T/N)? ");
        bool isRegularClient =  GetClientAnswer("Czy jesteś stałym klientem (T/N)? ");
        DateTime today = DateTime.Today;

        // Calculations
        bool isEarlyBooking = GetDataDiff(today, clientFlightDay);
        int clientAge = GetClientAge(today, clientBirthday);
        bool isSeason = GetIsSeason(clientFlightDay);
        int discount = GetDiscount(clientFlightDay, isDomesticFlight,isRegularClient, isEarlyBooking, clientAge, isSeason);

        // Generate report - printing
        printReport(clientBirthday, clientFlightDay, isDomesticFlight,isRegularClient, isEarlyBooking, clientAge, isSeason, discount);

    }
}