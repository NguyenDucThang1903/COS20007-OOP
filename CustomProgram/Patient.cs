using System;
using System.Collections.Generic;

namespace HospitalManagementSystem
{
    public class Patient : Person
    {
        private List<IObserver> _observers = new List<IObserver>();

        public Patient(string name, DateTime dob, string contact, string[] symptoms):base(name, contact, dob)
        {
            Symptoms = symptoms;
        }

        public string[] Symptoms 
        { 
            get; 
            set; 
        }

        public void AttachObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void DetachObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this); // Passing the patient data to the observers
            }
        }
    }
}
