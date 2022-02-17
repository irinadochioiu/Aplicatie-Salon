using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProiectMediiDeProgramare.Behaviors
{
    internal class ValidationNotNullBehavior: Behavior<Editor>
    {
        protected override void OnAttachedTo(Editor entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Editor entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Editor)sender;
            
                entry.TextColor = string.IsNullOrEmpty(e.NewTextValue) ? Color.DarkRed : Color.Default;
                entry.BackgroundColor = string.IsNullOrEmpty(e.NewTextValue)? Color.PaleVioletRed : Color.Default;
   
        }
    }
}
