if (!panel1.Controls.Contains(usWindow2.Instance))
            {
                panel1.Controls.Add(usWindow2.Instance);
                usWindow2.Instance.Dock = DockStyle.Fill;
                usWindow2.Instance.BringToFront();
            }
            else
            {
                usWindow2.Instance.BringToFront();
            }
