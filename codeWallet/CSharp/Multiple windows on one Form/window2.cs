private static usWindow2 _instance;
        public static usWindow2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usWindow2();
                return _instance;
            }
        }
