using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProiectMediiDeProgramare.Behaviors
{
    internal class ValidationZiProgramareBehavior : Behavior<DatePicker>
    {
        protected override void OnAttachedTo(DatePicker entry)
        {
            entry.DateSelected += OnEntryDateSelected;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(DatePicker entry)
        {
            entry.DateSelected -= OnEntryDateSelected;
            base.OnDetachingFrom(entry);
        }

        private void OnEntryDateSelected(object sender, DateChangedEventArgs e)
        {
            var date = (DatePicker)sender;
            var d = date.Date.DayOfWeek.ToString();
            Label error = ((DatePicker)sender).FindByName<Label>("labelEroare");
            error.TextColor = Color.DarkRed;
            if(d == "Sunday" || d == "Saturday")
            {
                error.Text = "Trebuie sa alegeti o zi lucratoare";
                date.BackgroundColor = Color.PaleVioletRed;
            }
            else 
            {
                error.Text = "";
                date.BackgroundColor = Color.Default;
            }
        }
    }
}
