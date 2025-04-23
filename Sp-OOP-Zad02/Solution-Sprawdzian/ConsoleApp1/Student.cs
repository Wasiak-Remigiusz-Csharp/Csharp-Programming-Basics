using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Student
    {

        // Dane
        private string _login;

        private string _haslo;

        public string Login
        {
            get => _login;
            set
            {
                string formattedValue = value.ToLower().Trim();

                formattedValue = formattedValue.Replace(" ", "").ToLower();

                if (string.IsNullOrEmpty(formattedValue) || ContainsNonLetterOrDigit(formattedValue))
                {
                    throw new ArgumentException("Bledny login!");
                }

                if (formattedValue.Length < 4)
                {
                    throw new ArgumentException("Bledny login!");
                }

                if (formattedValue[0] < 'a' || formattedValue[0] > 'z')
                    throw new ArgumentException("Bledny login!");



                _login = formattedValue;
            }
        }


        // Konstruktor
        public Student(string login, string haslo)
        {
            if (!IsValidPassword(haslo)) throw new ArgumentException("Bledne haslo!");
            _haslo = haslo;

            Login = login;
            

            //BestScore = 0;
            //LastScore = 0;
            //AvgScore = 0;


        }



        // Tekstowa repr Obj
        //public override string ToString()
        //{
        //    //var avg = AvgScore == 0 ? 0 : Math.Round(AvgScore, 1);
        //    return $"Login: {Login}. Wyniki: n={LiczbaPodejsc}, ostatni={WynikOstatni}, najlepszy={WynikNajlepszy}, najgorszy={WynikNajgorszy}, sredni={WynikSredni}}";
        //}

        public override string ToString()
        {
            //var avg = AvgScore == 0 ? 0 : Math.Round(AvgScore, 1);
            return $"Login: {Login}.";
        }



        // Metody


        private static bool ContainsNonLetterOrDigit(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetterOrDigit(c)) return true;
            }

            return false;
        }


        static bool IsValidPassword(string password)

        {
            foreach (char el in password)
            {
                if (char.IsDigit(el)) return false;
            }

            if (password.Length < 4 || password.Length > 8)
            {
                return false;
            }
            else
                return true;
        }



        }
}
