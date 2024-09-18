namespace ASP3.Services
{
    public class TimeService
    {
        public string TimeAnalysis()
        {
            var currentTime = DateTime.Now.TimeOfDay;

            return currentTime.Hours >= 12 && currentTime.Hours < 18 ? "Зараз день" :
                currentTime.Hours >= 18 && currentTime.Hours < 24 ? "Зараз вечір" :
                currentTime.Hours >= 24 && currentTime.Hours < 6 ? "Зараз ніч" : "Зараз ранок";
        }
    }
}
