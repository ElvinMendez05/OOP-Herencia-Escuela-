namespace Principios__KISS_.Class
{
    public class Restaurant 
    {
        public decimal CalcularTotal(decimal[] price, decimal? tipsPercentage)
        {
            decimal total = 0;

            foreach (decimal prices in price)
            {
                total += prices;
            }

            if (tipsPercentage.HasValue) 
            {
                total += total * (tipsPercentage.Value / 100);
            } else {
                total += total * 0.10m;
            }
            return total;
        }   
    }
}
































