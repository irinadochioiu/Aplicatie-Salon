using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace ProiectMediiDeProgramare.Behaviors
{
    internal class ValidationNameBehavior: Behavior<Editor>
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
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(e.NewTextValue);
            if (!string.IsNullOrEmpty(entry.Text))
            {
                entry.TextColor = isValid ? Color.DarkRed : Color.Default;
                entry.BackgroundColor = isValid ? Color.PaleVioletRed : Color.Default;
            }
            else
            {
                entry.TextColor = Color.DarkRed;
                entry.BackgroundColor = Color.PaleVioletRed;
            }
        }
    }
}
