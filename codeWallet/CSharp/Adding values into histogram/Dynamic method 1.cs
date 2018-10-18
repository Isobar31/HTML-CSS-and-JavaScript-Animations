        using (graphDBEntities db = new graphDBEntities())
            {
                chartRevenue.DataSource = db.Salaries.ToList();
                chartRevenue.Series["Revenue"].XValueMember = "Year";
                chartRevenue.Series["Revenue"].XValueType = ChartValueType.Int32;
                chartRevenue.Series["Revenue"].YValueMembers = "Total";
                chartRevenue.Series["Revenue"].YValueType = ChartValueType.Double;

            }
