namespace Principios__KISS_.Class
{
    public class Restaurant 
    {
        public decimal CalcularTotal(decimal[] price, decimal? tipsPercentage)
        {
            decimal total = 0;

            for (int i = 0; i < price.Length; i++)
            {
                total = total + price[i];
            }  
            
            if (tipsPercentage.HasValue) 
            {
                total = total + total * (tipsPercentage.Value / 100);
            } else {
                total = total + total * 0.10m;
            }
            return total;
        }   
    }
}
































