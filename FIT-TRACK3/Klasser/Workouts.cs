using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_TRACK3.Klasser
{
    abstract class Workouts
    {
        //egenskaper
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public string Notes { get; set; }


        //konstruktor
        public Workouts(DateTime Date, string Type, TimeSpan Duration, int CaloriesBurned, string Notes)
        {
            this.Date = Date;
            this.Type = Type;
            this.Duration = Duration;
            this.CaloriesBurned = CaloriesBurned;
            this.Notes = Notes;
        }


        //Metoder
        public abstract int CalculateCaloriesBurned();
    }
}
