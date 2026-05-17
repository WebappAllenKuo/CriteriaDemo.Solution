namespace CriteriaDemo.WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			s_Status = new ComboBox();
			label3 = new Label();
			s_StartTime = new TextBox();
			s_EndTime = new TextBox();
			label4 = new Label();
			btnSearch = new Button();
			txtSQL = new TextBox();
			label5 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
			label1.Location = new Point(29, 18);
			label1.Name = "label1";
			label1.Size = new Size(124, 24);
			label1.TabIndex = 0;
			label1.Text = "建立篩選條件";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(86, 84);
			label2.Name = "label2";
			label2.Size = new Size(41, 15);
			label2.TabIndex = 1;
			label2.Text = "Status";
			// 
			// s_Status
			// 
			s_Status.DropDownStyle = ComboBoxStyle.DropDownList;
			s_Status.FormattingEnabled = true;
			s_Status.Items.AddRange(new object[] { "待出貨", "已出貨", "已收貨", "已取消", "申請退貨" });
			s_Status.Location = new Point(134, 81);
			s_Status.Name = "s_Status";
			s_Status.Size = new Size(121, 23);
			s_Status.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(59, 119);
			label3.Name = "label3";
			label3.Size = new Size(67, 15);
			label3.TabIndex = 3;
			label3.Text = "OrderDate";
			// 
			// s_StartTime
			// 
			s_StartTime.Location = new Point(133, 112);
			s_StartTime.Name = "s_StartTime";
			s_StartTime.Size = new Size(122, 23);
			s_StartTime.TabIndex = 1;
			// 
			// s_EndTime
			// 
			s_EndTime.Location = new Point(283, 112);
			s_EndTime.Name = "s_EndTime";
			s_EndTime.Size = new Size(122, 23);
			s_EndTime.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(261, 115);
			label4.Name = "label4";
			label4.Size = new Size(16, 15);
			label4.TabIndex = 6;
			label4.Text = "~";
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(416, 115);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(75, 23);
			btnSearch.TabIndex = 3;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// txtSQL
			// 
			txtSQL.Location = new Point(36, 195);
			txtSQL.Multiline = true;
			txtSQL.Name = "txtSQL";
			txtSQL.Size = new Size(455, 169);
			txtSQL.TabIndex = 4;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft JhengHei UI", 11F, FontStyle.Bold);
			label5.Location = new Point(36, 171);
			label5.Name = "label5";
			label5.Size = new Size(118, 19);
			label5.TabIndex = 3;
			label5.Text = "SQL Statement";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(524, 383);
			Controls.Add(txtSQL);
			Controls.Add(btnSearch);
			Controls.Add(label4);
			Controls.Add(s_EndTime);
			Controls.Add(s_StartTime);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(s_Status);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private ComboBox s_Status;
		private Label label3;
		private TextBox s_StartTime;
		private TextBox s_EndTime;
		private Label label4;
		private Button btnSearch;
		private TextBox txtSQL;
		private Label label5;
	}
}
