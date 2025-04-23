using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public  class Player
    {

        // Dane
        private string _name;
        private string _password;
        private int _lastScore;
        private int _bestScore;
        //private int _avgScore;
        private List<int> _scores { get; } = new List<int>(); 

        public string Name
        {
            get => _name;
            set
            {
                string correctedValue = value.ToLower().Trim();

                correctedValue = correctedValue.Replace(" ", "");

                if (string.IsNullOrEmpty(correctedValue)
                    || ContainsNonLetterOrDigit(correctedValue)
                    || correctedValue.Length < 3
                    || !char.IsLetter(correctedValue[0]))
                {
                    throw new ArgumentException("Wrong name!");
                }
                
                _name = correctedValue;
            }
        }


        public int LastScore
        {
            get => _lastScore;
            //set
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Wrong score!");
                }
                _lastScore = value;
            }
        }

        public int BestScore
        {
            get => _bestScore;
            private set
            //set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Wrong score!");
                }
                _bestScore = value;
            }
        }


        public double AvgScore { get;  private set; }
        


        // Konstruktor
        public Player(string name, string password) 
        {

            if (!IsvalidPassword(password)) throw new ArgumentException("Wrong password!");

            _password = password;

            Name = name;
            LastScore = 0;
            BestScore = 0;
            AvgScore = 0;

        }


        // Tekstowa reprezentacja obketu
        public override string ToString()
        {
            var avg = AvgScore == 0 ? 0 : Math.Round(AvgScore, 1);
            return $"Name: {Name}, Score: last={LastScore}, best={BestScore}, avg={avg}";
        }



        // Metody
        private static bool ContainsNonLetterOrDigit(string value)
        {
            foreach (char el in value)
            {
                if (!char.IsLetterOrDigit(el))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsvalidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)
            || string.IsNullOrWhiteSpace(password)
            || password.Length < 8
            || password.Length > 16)
            {
                return false;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasPunctuation = false;


            foreach (char ch in password)
            {
                if (char.IsUpper(ch)) hasUpper = true;
                if(char.IsLetter(ch)) hasLower = true;
                if (char.IsDigit(ch)) hasDigit = true;
                if (char.IsPunctuation(ch)) hasPunctuation = true;
            }

            foreach (char ch in password)
            {
                if (!(ch >= 32 && ch <= 126))
                {
                    return false;
                }
            }

            if (hasUpper && hasLower && hasDigit && hasPunctuation)
            {
                return true;
            }

            return false;
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == _password)
            {
                if (IsvalidPassword(newPassword))
                {
                    _password = newPassword;
                    return true;
                }
            }
            return false;
        }
        public bool VerifyPassword(string password)
        {
            return password == _password;
        }

        public void AddScore(int currentScore)
        {
            if (currentScore < 0 || currentScore > 100)
            {
                throw new ArgumentOutOfRangeException(null, "Wrong value!");
            }
            LastScore = currentScore;
            if (currentScore > BestScore)
            {
                BestScore = currentScore;
            }

            _scores.Add(currentScore);
            UpdateAverageScore();

        }
        public bool TryAddScore(int currentScore)
        {
            if (currentScore < 0 || currentScore > 100)
            {
                return false;
            }
            LastScore = currentScore;
            if (currentScore > BestScore)
            {
                BestScore = currentScore;
            }

            _scores.Add(currentScore);
            UpdateAverageScore();



            return true;
        }

        private void UpdateAverageScore()
        {
            int sum = 0;

            foreach (var score in _scores)
            {
                sum += score;
            }

            AvgScore = _scores.Count > 0 ? (double)sum / _scores.Count : 0;
        }




    }
}
