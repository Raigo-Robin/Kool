namespace Palgaarvestus_programm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta brutopalk: ");
            double brutoSalary = Convert.ToDouble(Console.ReadLine());
            double netIncome = 0;
            

            
            
            


            if (brutoSalary <= 1200)
            {
                netIncome = Employee.SalaryCalculationLess1200(brutoSalary, netIncome);
            }

            else if (brutoSalary >= 1201.01 && brutoSalary <= 2099)
            {
                netIncome = Employee.SalaryCalculationAbove1200(brutoSalary, netIncome);
            }
            else if (brutoSalary >= 2100)
            {
                netIncome = Employee.SalaryCalculationAbove2100(brutoSalary, netIncome);
            }
            else
            {
                Console.WriteLine("ERROR!!!!");
            }
            Console.WriteLine("Neto sissetulek on: " + netIncome);
            
        }

    }

    public class Employee
    {
        public static double SalaryCalculationLess1200(double brutoSalary, double netIncome)
        {

            
            double IncomeTax = 0.2;
            float TaxFreeIncome = 654;

            double pensionFond = brutoSalary * 0.02;
            double unEmpTax = brutoSalary * 0.016;
            double incomeTaxSum = IncomeTax * (brutoSalary - (TaxFreeIncome + pensionFond + unEmpTax));
            
            double deductibleIncome = brutoSalary - TaxFreeIncome;
            double taxSum = deductibleIncome * IncomeTax;
            netIncome = brutoSalary - (pensionFond + unEmpTax + incomeTaxSum);

            

            return netIncome;

            

        }


        public static double SalaryCalculationAbove2100(double brutoSalary, double netIncome)
        {
            double IncomeTax = 0.2;
            

            double pensionFond = brutoSalary * 0.02;
            double unEmpTax = brutoSalary * 0.016;
            double incomeTaxSum = IncomeTax * (brutoSalary - (pensionFond + unEmpTax));

            double deductibleIncome = brutoSalary ;
            double taxSum = deductibleIncome * IncomeTax;
            netIncome = brutoSalary - (pensionFond + unEmpTax + incomeTaxSum);
           
            return netIncome;

        }


        public static double SalaryCalculationAbove1200(double brutoSalary, double netIncome)
        {
            double IncomeTax = 0.2;
            double TaxFreeIncome = 654 - 0.72667 * (brutoSalary - 1200);

            double pensionFond = brutoSalary * 0.02;
            double unEmpTax = brutoSalary * 0.016;
            double incomeTaxSum = IncomeTax * (brutoSalary - (TaxFreeIncome + pensionFond + unEmpTax));
            
            netIncome = brutoSalary - (pensionFond + unEmpTax + incomeTaxSum);
            
            return netIncome;
        }
    }
}