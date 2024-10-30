using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_TRACK3.Klasser
{
    internal class Manager
    {
        public class UserService
        {
            private readonly List<User> _users = new List<User>();

            public bool RegisterUser(string username, string password, string country)
            {
                if (_users.Any(u => u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)))
                {
                    return false; // användarnamnet är upptaget
                }

                var newUser = new User("admin", "password", "Sweden")
                {
                    UserName = username,
                    Password = password,
                    Country = country
                };

                _users.Add(newUser);
                return true; // registreringen lyckades
            }
            public User SignIn(string username, string password)
            {
                return _users.FirstOrDefault(u => u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            }


        }

        public class WorkoutService
        {
            private readonly List<Workouts> _workouts = new List<Workouts>();

            public IEnumerable<Workouts> GetWorkouts()
            {
                return _workouts;
            }

            public void AddWorkout(Workouts workout)
            {
                _workouts.Add(workout);
            }

            public void RemoveWorkout(Workouts workout)
            {
                _workouts.Remove(workout);
            }
        }
    }   

}
