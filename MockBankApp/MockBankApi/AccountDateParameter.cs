namespace MockBankApi
{
    public class AccountDateParameter
    {
        DateTime initialDate = new DateTime(2022, 12, 31);
        DateTime finalDate = new DateTime(2023, 12, 31);
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
