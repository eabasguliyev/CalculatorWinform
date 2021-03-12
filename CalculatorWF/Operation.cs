namespace CalculatorWF
{
    public class Operation
    {
        public string LeftSide { get; set; }

        public string RightSide { get; set; }

        public OperationType OperationType { get; set; }

        public Operation InnerOperation { get; set; }

        public Operation()
        {
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;

        }

    }
}