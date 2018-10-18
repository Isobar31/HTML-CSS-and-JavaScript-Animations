private static ucWindow1 _instance;
        public static ucWindow1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucWindow1();
                return _instance;
            }
        }
