private static ucWindow3 _instance;
        public static ucWindow3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucWindow3();
                return _instance;
            }
        }
