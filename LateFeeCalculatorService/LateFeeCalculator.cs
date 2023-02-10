namespace LateFeeCalculatorService
{
    public class LateFeeCalculator
    {
        public decimal Calculate(decimal BillAmount, DateTime dueDate)
        {

            int NoOfDays = (DateTime.Now - dueDate).Days;

            decimal calculatedLateFees = 0.00M;

            if (NoOfDays >= 2 && NoOfDays < 5)
            {
                calculatedLateFees = BillAmount * 0.01M;
            }
            else if (NoOfDays >= 5 && NoOfDays < 10)
            {
                calculatedLateFees = BillAmount * 0.025M;
            }
            else if (NoOfDays >= 10 && NoOfDays < 15)
            {
                calculatedLateFees = BillAmount * 0.05M;
            }
            else if (NoOfDays >= 15)
            {
                calculatedLateFees = BillAmount * 0.1M;
            }

            if (calculatedLateFees <= 500.00M)
                return calculatedLateFees;
            else
                return 500.00M;
        }
    }
}