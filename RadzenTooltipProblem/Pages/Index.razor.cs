using Microsoft.AspNetCore.Components;

namespace RadzenTooltipProblem.Pages
{
    public partial class Index : ComponentBase
    {
        public List<GenericJobData> ChartData { get; set; }

        protected override void OnInitialized()
        {
            ChartData = new List<GenericJobData>();

            var random = new Random();

            for (var i = 0; i < 30; i++)
            {
                ChartData.Add(new GenericJobData (DateTime.Now.AddDays(i + random.Next(4)), random.Next(21)));
            }

            ChartData = ChartData.GroupBy(x => x.Date)
                        .Select(x => new GenericJobData (x.Key, x.Sum(y => y.Value)))
                        .ToList();
        }
    }
    public class GenericJobData
    {
        public DateTime Date { get; }
        public double Value { get; }

        public GenericJobData(DateTime date, double value)
        {
            this.Date = date;
            this.Value = value;
        }
    }
}
