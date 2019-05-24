class Program
    {
        static void Main(string[] args)
        {
DateTime d = DateTime.Now;
            int number;
            string name;
            string phoneNumber;
            string summary;

            Console.WriteLine("Number of persons that called");
            number = Convert.ToInt32(Console.ReadLine());
           
            List<CallHistory> person = new List<CallHistory>();

            for (int index = 0; index < number; index++)
            {
                CallHistory callers = new CallHistory();

                Console.WriteLine();
                Console.WriteLine("Enter caller's Name");
                name = Console.ReadLine();
                callers.CallerName = name;

                Console.WriteLine("Enter caller's phone number");
                phoneNumber = Console.ReadLine();
                callers.PhoneNumber = phoneNumber;

                callers.DateAndTime = d.Date;

                Console.WriteLine("Enter caller's summary");
                summary = Console.ReadLine();
                callers.CallSummary = summary;

                person.Add(callers);
            }            

            Console.WriteLine();
            Console.WriteLine("******************** Call History ******************");
            foreach (CallHistory customer in person)
            {               
                Console.WriteLine("Name: {0}; Phone number: {1}; Date and time: {2}; Call summary: {3}", customer.CallerName, customer.PhoneNumber, customer.DateAndTime, customer.CallSummary);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

            
            public class CallHistory
    {
        private string callerName;
        private string phoneNumber;
        private DateTime dateAndTime;
        private string callSummary;

        public CallHistory()
        {

        }

        public string CallerName
        {
            get
            {
                return this.callerName;
            }
            set
            {
                this.callerName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            set
            {
                this.dateAndTime = value;
            }
        }

        public string CallSummary
        {
            get
            {
                return this.callSummary;
            }
            set
            {
                this.callSummary = value;
            }
        } 
    }
