using System;

namespace RCASensor.Utils
{
    public static class DateConverter
    {
        public static DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            DateTimeOffset dateTomeOffset;

            if (unixTimeStamp <= 253402300799)
            {
                dateTomeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimeStamp);
            }
            else
            {
                dateTomeOffset = DateTimeOffset.FromUnixTimeMilliseconds(unixTimeStamp);
            }

            return dateTomeOffset.DateTime;
        }

        public static long DateTimeToUnixTime(DateTime date)
        {
            return (long)(date.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}
