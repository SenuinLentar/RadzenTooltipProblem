using Microsoft.AspNetCore.Components;

namespace RadzenTooltipProblem.Pages
{
    public partial class Index : ComponentBase
    {
        public List<GenericJobData> ChartData { get; set; }
        public List<GenericJobData> ChartData2 { get; set; }

        protected override void OnInitialized()
        {
            ChartData = new List<GenericJobData>()
            {
                new GenericJobData(new DateTime(2022, 06, 14), 75),
                new GenericJobData(new DateTime(2022, 06, 15), 89),
                new GenericJobData(new DateTime(2022, 06, 16), 59),
                new GenericJobData(new DateTime(2022, 06, 17), 46),
                new GenericJobData(new DateTime(2022, 06, 20), 67),
                new GenericJobData(new DateTime(2022, 06, 21), 17),
            };

            ChartData2 = new List<GenericJobData>()
            {
                new GenericJobData(new DateTime(2022, 06, 14), 75),
                new GenericJobData(new DateTime(2022, 06, 15, 23, 59, 59), 89), //Exemple with hours
                new GenericJobData(new DateTime(2022, 06, 16), 59),
                new GenericJobData(new DateTime(2022, 06, 17, 12, 00, 00), 46), //Exemple with hours
                new GenericJobData(new DateTime(2022, 06, 20), 67),
                new GenericJobData(new DateTime(2022, 06, 21), 17),
            };

            //ChartData = new List<GenericJobData>();

            //var random = new Random();

            //for (var i = 0; i < 30; i++)
            //{
            //    ChartData.Add(new GenericJobData (DateTime.Now.Date.AddDays(i + random.Next(4)), random.Next(21)));
            //}

            //ChartData = ChartData.GroupBy(x => x.Date)
            //            .Select(x => new GenericJobData (x.Key, x.Sum(y => y.Value)))
            //            .ToList();
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


//ChartData = new List<GenericJobData>()
//            {
//                new GenericJobData(new DateTime(2022, 06, 20), 13),
//                new GenericJobData(new DateTime(2022, 06, 23), 10),
//                new GenericJobData(new DateTime(2022, 06, 24), 23),
//                new GenericJobData(new DateTime(2022, 06, 25), 10),
//                new GenericJobData(new DateTime(2022, 06, 26), 16),
//                new GenericJobData(new DateTime(2022, 06, 27), 0),
//                new GenericJobData(new DateTime(2022, 06, 30), 10),
//                new GenericJobData(new DateTime(2022, 06, 1), 5),
//                new GenericJobData(new DateTime(2022, 07, 3), 7),
//                new GenericJobData(new DateTime(2022, 06, 5), 10),
//                new GenericJobData(new DateTime(2022, 06, 6), 13),
//                new GenericJobData(new DateTime(2022, 06, 7), 19),
//                new GenericJobData(new DateTime(2022, 06, 11), 51),
//                new GenericJobData(new DateTime(2022, 06, 15), 1),
//                new GenericJobData(new DateTime(2022, 06, 16), 13),
//                new GenericJobData(new DateTime(2022, 06, 17), 7),
//                new GenericJobData(new DateTime(2022, 06, 18), 18),
//                new GenericJobData(new DateTime(2022, 06, 19), 16),
//                new GenericJobData(new DateTime(2022, 06, 22), 7),
//            };
