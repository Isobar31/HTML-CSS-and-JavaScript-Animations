public int NumberCount ()
        {
            string countString = "SELECT COUNT(*) FROM dbo.[HistogramDB]";
            int count = 0;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                
                using (SqlCommand cmd2 = new SqlCommand(countString, sqlCon))
                {
                    sqlCon.Open();
                    label10.Text = cmd2.ExecuteScalar().ToString();
                }

                
                //cmd2.ExecuteNonQuery();
                sqlCon.Close();
            }
            return count;
        }
