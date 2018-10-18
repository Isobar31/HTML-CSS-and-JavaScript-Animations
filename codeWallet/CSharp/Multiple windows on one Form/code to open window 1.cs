if(!panel1.Controls.Contains(ucWindow1.Instance))
            {
                panel1.Controls.Add(ucWindow1.Instance);
                ucWindow1.Instance.Dock = DockStyle.Fill;
                ucWindow1.Instance.BringToFront();
            }
            else
            {
                ucWindow1.Instance.BringToFront();
            }
