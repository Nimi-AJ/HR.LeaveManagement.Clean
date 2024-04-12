namespace HR.LeaveManagement.Api
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public int ConvertToInt(string text)       
        {

            if(string.IsNullOrEmpty(text)) throw new ArgumentNullException("text");

            text.Trim();

            int num = 0;
            int mul = 1;

            for(int i = 0; i < text.Length; i++)
            {
                if(i == 0)
                {
                    if (text[i] == '-')
                    {
                        mul = -1;
                    } else if (text[i] == '+')
                    {
                        mul = 1;
                    }
                    break;
                }
                char c = text[i];
                int digit = Convert.ToInt32(c) - '0';

                num = digit + (num * 10);

            }

            return num * mul;
        }
    }
}