using System;

namespace DigitalClock.Models
{
    public class ClockModel
    {
        public TimeZoneInfo TimeZone { get; set; }
        public DateTime CurrentTime { get; set; }
        public string DisplayName => TimeZone?.DisplayName ?? "UTC";
        public string StandardName => TimeZone?.StandardName ?? "UTC";
        public string AbbreviatedName => TimeZone?.StandardName?.Substring(0, Math.Min(3, TimeZone.StandardName.Length)) ?? "UTC";

        public ClockModel(TimeZoneInfo timeZone)
        {
            TimeZone = timeZone;
            CurrentTime = DateTime.Now;
        }

        public void UpdateTime(DateTime newTime)
        {
            CurrentTime = newTime;
        }

        public string GetFormattedTime(string format = "HH:mm:ss")
        {
            return CurrentTime.ToString(format);
        }

        public string GetFormattedDate(string format = "dddd, MMMM dd, yyyy")
        {
            return CurrentTime.ToString(format);
        }

        public string GetAMPM()
        {
            return CurrentTime.ToString("tt");
        }

        public string Get12HourTime()
        {
            return CurrentTime.ToString("hh:mm:ss tt");
        }

        public override string ToString()
        {
            return $"{StandardName}: {GetFormattedTime()}";
        }
    }
}
