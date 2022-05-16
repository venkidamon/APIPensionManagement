namespace ProcessPension.Entities
{
    public class AppProcessPension
    {
        public int Id { get; set; }
        public string AadharNumber { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string PanCardNumber { get; set; }
        public double Salary { get; set; }
        public double Allowance { get; set; }
        public string PensionType { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BankType { get; set; }
        public double Amount { get; set; }
        public double BankServiceCharge { get; set; }
    }
}
