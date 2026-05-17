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


			// 若有任一篩選條件，則將其加入 WHERE 子句
			if (string.IsNullOrEmpty(where) == false) { 
				sql += "\r\nWHERE " + where;
			}

			sql += "\r\nORDER BY o.OrderTime DESC";

			txtSQL.Text = sql;
		}


	}
}
