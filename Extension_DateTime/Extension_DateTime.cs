using System;

namespace Extension_DateTime
{
    static public class Extension_DateTime
    {
        static public bool IsBefore(this DateTime dateTimeSelf, DateTime dateTimeOther)
        {
            return dateTimeSelf < dateTimeOther;
        }
        static public bool TheSameAs(this DateTime dateTimeSelf, DateTime dateTimeOther)
        {
            return dateTimeSelf == dateTimeOther;
        }
        static public bool IsAfter(this DateTime dateTimeSelf, DateTime dateTimeOther)
        {
            return dateTimeSelf > dateTimeOther;
        }

        /// <summary>
        /// 取得該月第一天
        /// </summary>
        /// <param name="month">int</param>
        /// <param name="year">int</param>
        /// <returns>DateTime</returns>
        static DateTime GetFristDayForMonth(int month, int year)
        {
            const int Day = 1;

            return new DateTime(year, month, Day);
        }
        /// <summary>
        /// 取得該月第一天
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>DateTime</returns>
        static public DateTime GetFristDayForMonth(this DateTime date)
        {
            return GetFristDayForMonth(date.Month, date.Year);
        }

        /// <summary>
        /// 取得該月最後一天
        /// </summary>
        /// <param name="month">int</param>
        /// <param name="year">int</param>
        /// <returns>DateTime</returns>
        static DateTime GetLastDayForMonth(int month, int year)
        {
            const int Day = 1;

            return new DateTime(year, month, Day).AddMonths(1).AddDays(-1);
        }
        /// <summary>
        /// 取得該月最後一天
        /// </summary>
        /// <param name="date"></param>
        /// <returns>DateTime</returns>
        static public DateTime GetLastDayForMonth(this DateTime date)
        {
            return GetLastDayForMonth(date.Month, date.Year);
        }

        /// <summary>取得該年第一天</summary>
        /// <param name="year">int</param>
        /// <returns>DateTime</returns>
        static DateTime GetFristDayForYear(int year)
        {
            const int Month = 1;
            const int Day = 1;

            return new DateTime(year, Month, Day);
        }
        /// <summary>取得該年第一天</summary>
        /// <param name="date">DateTime</param>
        /// <returns>DateTime</returns>
        static public DateTime GetFristDayForYear(this DateTime date)
        {
            return GetFristDayForYear(date.Year);
        }

        /// <summary>取得該年最後一天</summary>
        /// <param name="year">int</param>
        /// <returns>DateTime</returns>
        static DateTime GetLastDayForYear(int year)
        {
            const int Month = 12;
            const int Day = 31;

            return new DateTime(year, Month, Day);
        }
        /// <summary>取得該年最後一天</summary>
        /// <param name="date">DateTime</param>
        /// <returns>DateTime</returns>
        static public DateTime GetLastDayForYear(this DateTime date)
        {
            return GetLastDayForYear(date.Year);
        }

        /// <summary>
        /// UnixTime轉DateTime
        /// UnixTime to DateTime
        /// </summary>
        /// <param name="unixTime">double unixTime</param>
        /// <returns>return DateTime</returns>
        static public void SetFromUnixTime(this DateTime dateTime, double unixTime)
        {
            //UnixTime為一個從1970/01/01至今的秒數值,並為國際標準時間(UTC+0)
            //不可用DateTime.MinValue，DateTime.MinValue可能為0001/01/01
            dateTime = new DateTime(1970, 01, 01);
            //ToLocalTime() : UTC+8
            dateTime.AddSeconds(unixTime).ToLocalTime();
        }
    }
}
