using System;

namespace CrossCuttingConcerns.Validation
{
    public static class ChronologyValidator
    {
        public static bool IsValidChronology(DateOnly dateFrom, DateOnly? dateTill)
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);

            if (dateTill == null)
            {
                // Open-ended: only check that dateFrom is not in the future
                return dateFrom <= today;
            }

            return dateFrom <= dateTill && dateFrom <= today && dateTill <= today;
        }
    }
}
