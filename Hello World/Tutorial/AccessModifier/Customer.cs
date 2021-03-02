namespace AccessModifier
{
    public class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 1)
            {
            System.Console.WriteLine("Promoting");

            } else
            {
                System.Console.WriteLine("Don't Promote");
            }
        }

        private int CalculateRating()
        {
            return 1;
        }
    }
}
