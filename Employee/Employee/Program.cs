namespace Employee
{


    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();

            empWageBuilderArray.computeEmpWage();


        }
        public static CompanyEmpWage UserInput()
        {
            Console.WriteLine(value: "enter company name");
            String CompanyName = Console.ReadLine();

            Console.WriteLine(value: "enter Emp rate per hr");
            int empRatePerHr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(value: "enter no of working Days");
            int noOfWorkingDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(value: "enter maxWorking hrs per month");
            int maxWorkingHrsPerMonth = Convert.ToInt32(Console.ReadLine());

            return new CompanyEmpWage(CompanyName, empRatePerHr, maxWorkingHrsPerMonth, noOfWorkingDays)
            {
                company = CompanyName,
                empRatePerHour = empRatePerHr,
                numOfWorkingDays = noOfWorkingDays,
                maxHoursPerMonth = maxWorkingHrsPerMonth



            };
}
    }
}

    

