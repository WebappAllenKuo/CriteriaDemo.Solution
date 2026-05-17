namespace CriteriaDemo.WinApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GenerateSQL();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			GenerateSQL();
		}

		private string GetStatusFilter()
		{
			if (s_Status.SelectedIndex < 0) return string.Empty;

			var status = s_Status.SelectedItem.ToString();
			return status;
		}

		private string GetStartDateFilter()
		{
			if(string.IsNullOrEmpty(s_StartTime.Text)) return string.Empty;

			bool isValid = DateTime.TryParse(s_StartTime.Text, out var startTime);
			if (isValid)
			{
				return startTime.ToString("yyyy/MM/dd");
			}
			else
			{
				return string.Empty;
			}
		}

		private string GetEndDateFilter()
		{
			if (string.IsNullOrEmpty(s_EndTime.Text)) return string.Empty;

			bool isValid = DateTime.TryParse(s_EndTime.Text, out var endTime);

			if (isValid)
			{
				return endTime.ToString("yyyy/MM/dd");
			}
			else
			{
				return string.Empty;
			}
		}

		private void GenerateSQL()
		{
			var sql = @"SELECT
    o.Id AS OrderId,
    o.OrderTime AS OrderTime,
    m.MemberName AS MemberName,
    o.Status AS OrderStatus,
    o.Total AS OrderTotal
FROM Orders o
INNER JOIN Members m ON o.MemberId = m.Id";

			// Build the WHERE clause based on user input
			var where = string.Empty;

			var s_status = GetStatusFilter();
			if (string.IsNullOrEmpty(s_status) == false)
			{
				where += $" AND o.Status = '{s_status}'";
			}

			var s_startTime = GetStartDateFilter();
			if (string.IsNullOrEmpty(s_startTime) == false)
			{
				where += $" AND o.OrderTime >= '{s_startTime}'";
			}

			var s_endTime = GetEndDateFilter();
			if (string.IsNullOrEmpty(s_endTime) == false)
			{
				var dtEnd = DateTime.Parse(s_endTime).AddDays(1).ToString("yyyy/MM/dd");
				where += $" AND o.OrderTime < '{dtEnd}'";
			}

			// 若有任一篩選條件，則將其加入 WHERE 子句
			if (string.IsNullOrEmpty(where) == false) { 
				sql += "\r\nWHERE " + where.Substring(5);
			}

			sql += "\r\nORDER BY o.OrderTime DESC";

			txtSQL.Text = sql;
		}


	}
}
