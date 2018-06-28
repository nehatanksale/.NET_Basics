using System;

namespace Practice_Core
{
    class Program
    {

        private DateTime _birthdate;

        public DateTime BirthDate { get { return _birthdate; } set {_birthdate=value; } }

        static void Main(string[] args)
        {

            var p = new Program();
            p.BirthDate = new DateTime(1996, 2, 14);

        }
    }
}
