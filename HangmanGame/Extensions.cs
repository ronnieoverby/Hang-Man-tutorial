using System;
using System.Windows.Forms;

namespace HangmanGame
{
    public static class Extensions
    {
        /// <summary>
        /// Assuming that the control text contains a numeric string,
        /// parses the string, increments it by n (or 1 if not provided)
        /// and resets the text to the incremented string value.
        /// </summary>
        /// <exception cref="FormatException">
        /// When the control doesn't contain a parsable numeric value.
        /// </exception>
        public static void Increment(this Control control, double n = 1)
        {
            var i = double.Parse(control.Text);
            i += n;
            control.Text = i.ToString();
        }
    }
}