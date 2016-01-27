using System;
using System.Linq;

namespace Net.Teirlinck.Utils.Mathnet
{
    public static class Sequence
    {
        public static bool IsMonotonic(this double[] sequence)
        {
            if (sequence == null || sequence.Length < 2)
                return false;

            int sign = 0;
            int counter = 0;

            while (sign == 0 && counter < sequence.Length - 1)
                sign = Math.Sign(sequence[counter + 1] - sequence[counter++]);

            if (sign == 0)
                return true; // That means that all items in the sequence are equal to 0

            for (int i = counter; i < sequence.Length - 1; i++)
            {
                int localSign = Math.Sign(sequence[i + 1] - sequence[i]);

                if (localSign != sign && localSign != 0)
                    return false;
            }

            return true;
        }

        public static bool IsMonotonicIncreasing(this double[] sequence)
        {
            return sequence.IsMonotonic() && sequence.Last() >= sequence.First();
        }

        public static bool IsMonotonicDecreasing(this double[] sequence)
        {
            return sequence.IsMonotonic() && sequence.Last() <= sequence.First();
        }

        public static bool IsMonotonic(this int[] sequence)
        {
            if (sequence == null || sequence.Length == 0)
                return false;

            return sequence.Select(i => (double)i).ToArray().IsMonotonic();
        }

        public static bool IsMonotonicIncreasing(this int[] sequence)
        {
            return sequence.IsMonotonic() && sequence.Last() >= sequence.First();
        }

        public static bool IsMonotonicDecreasing(this int[] sequence)
        {
            return sequence.IsMonotonic() && sequence.Last() <= sequence.First();
        }

        public static bool IsStrictlyMonotonic(this double[] sequence)
        {
            if (sequence == null || sequence.Length < 2)
                return false;

            int sign = Math.Sign(sequence[1] - sequence[0]);

            if (sign == 0)
                return false;

            for (int i = 1; i < sequence.Length - 1; i++)
            {
                int localSign = Math.Sign(sequence[i + 1] - sequence[i]);

                if (localSign != sign)
                    return false;
            }

            return true;
        }

        public static bool IsStrictlyMonotonicIncreasing(this double[] sequence)
        {
            return sequence.IsStrictlyMonotonic() && sequence.Last() > sequence.First();
        }

        public static bool IsStrictlyMonotonicDecreasing(this double[] sequence)
        {
            return sequence.IsStrictlyMonotonic() && sequence.Last() < sequence.First();
        }

        public static bool IsStrictlyMonotonic(this int[] sequence)
        {
            if (sequence == null || sequence.Length == 0)
                return false;

            return sequence.Select(i => (double)i).ToArray().IsStrictlyMonotonic();
        }

        public static bool IsStrictlyMonotonicIncreasing(this int[] sequence)
        {
            return sequence.IsStrictlyMonotonic() && sequence.Last() > sequence.First();
        }

        public static bool IsStrictlyMonotonicDecreasing(this int[] sequence)
        {
            return sequence.IsStrictlyMonotonic() && sequence.Last() < sequence.First();
        }
    }
}
