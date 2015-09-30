using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Net.Teirlinck.Utils.Mathnet
{
    public static class Statistics
    {
        /// <summary>
        /// Estimates the unbiased population standard deviation from the provided samples. On a dataset of size N will use an N-1 normalizer (Bessel's correction). Returns null if data has less than two entries or if any entry is NaN. Null-entries are ignored
        /// This method is a wrapper of MathNet.Numerics.Statistics.Statistics.StandardDeviation()
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source</typeparam>
        /// <param name="source">A subset of samples, sampled from the full population</param>
        /// <param name="selector">A transform function to apply to each element</param>
        /// <returns>Null if data has less than two entries or if any entry is NaN. Null-entries are ignored</returns>
        public static double? StandardDeviationSelector<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            double stdDev = source.Select(selector).StandardDeviation();

            return double.IsNaN(stdDev) ? (double?)null : stdDev;
        }

        /// <summary>
        /// Estimates the unbiased population standard deviation from the provided samples. On a dataset of size N will use an N-1 normalizer (Bessel's correction). Returns null if data has less than two entries or if any entry is NaN. Null-entries are ignored
        /// This method is a wrapper of MathNet.Numerics.Statistics.Statistics.StandardDeviation()
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source</typeparam>
        /// <param name="source">A subset of samples, sampled from the full population</param>
        /// <param name="selector">A transform function to apply to each element</param>
        /// <returns>Null if data has less than two entries or if any entry is NaN. Null-entries are ignored</returns>
        public static double? StandardDeviationSelector<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            double stdDev = source.Select(selector).Select(item => (double?)item).StandardDeviation();

            return double.IsNaN(stdDev) ? (double?)null : stdDev;
        }
    }
}
