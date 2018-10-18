if (!panel1.Controls.Contains(ucWindow3.Instance))
            {
                panel1.Controls.Add(ucWindow3.Instance);
                ucWindow3.Instance.Dock = DockStyle.Fill;
                ucWindow3.Instance.BringToFront();
            }
            else
            {
                ucWindow3.Instance.BringToFront();
            }
