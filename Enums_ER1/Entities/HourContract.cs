namespace Enums_ER1.Entities
{
    internal class HourContract
    {
        internal DateTime Date { get; set; }
        internal double ValuePerHour { get; set; }
        internal int Hours { get; set; }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

        public HourContract(DateTime Date, double ValuePerHour, int Hours)
        {
            this.Date = Date;
            this.ValuePerHour = ValuePerHour;
            this.Hours = Hours;

        }
    }

    
}
