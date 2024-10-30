using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_TRACK3.Klasser
{
    internal class CardioWorkout : Workouts
    {
        //egenskaper
        public int Repetations { get; set; }

        //konstruktor
        public CardioWorkout(DateTime Date, string Type, TimeSpan Duration, int CaloriesBurned, string Notes, int Repetations)
        : base(Date, Type, Duration, CaloriesBurned, Notes)
        {
            this.Repetations = Repetations;
        }
        //metoder
        public override int CalculateCaloriesBurned()
        {
            throw new NotImplementedException();
        }
    }
}
