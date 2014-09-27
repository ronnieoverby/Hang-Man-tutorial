using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Shuffles a collection of items.
        /// </summary>
        /// <thanks to="Jon Skeet">http://stackoverflow.com/a/1287572/64334</thanks>
        public static IEnumerable<T> Shuffle<T>(this IList<T> list, Random rng = null)
        {
            rng = rng ?? new Random();
            var elements = new T[list.Count];
            list.CopyTo(elements, 0);
            for (var i = elements.Length - 1; i >= 0; i--)
            {
                // Swap element "i" with a random earlier element it (or itself)
                // ... except we don't really need to swap it fully, as we can
                // return it immediately, and afterwards it's irrelevant.
                var swapIndex = rng.Next(i + 1);
                yield return elements[swapIndex];
                elements[swapIndex] = elements[i];
            }
        }
    }
}