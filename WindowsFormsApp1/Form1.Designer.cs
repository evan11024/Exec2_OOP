namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.CalcButton = new System.Windows.Forms.Button();
			this.ResultTextBox = new System.Windows.Forms.TextBox();
			this.NewGameButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(91, 44);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(157, 22);
			this.InputTextBox.TabIndex = 0;
			// 
			// CalcButton
			// 
			this.CalcButton.Location = new System.Drawing.Point(304, 42);
			this.CalcButton.Name = "CalcButton";
			this.CalcButton.Size = new System.Drawing.Size(75, 23);
			this.CalcButton.TabIndex = 1;
			this.CalcButton.Text = "button1";
			this.CalcButton.UseVisualStyleBackColor = true;
			this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.Location = new System.Drawing.Point(91, 126);
			this.ResultTextBox.Multiline = true;
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ResultTextBox.Size = new System.Drawing.Size(313, 197);
			this.ResultTextBox.TabIndex = 2;
			// 
			// NewGameButton
			// 
			this.NewGameButton.Location = new System.Drawing.Point(304, 81);
			this.NewGameButton.Name = "NewGameButton";
			this.NewGameButton.Size = new System.Drawing.Size(75, 23);
			this.NewGameButton.TabIndex = 3;
			this.NewGameButton.Text = "button1";
			this.NewGameButton.UseVisualStyleBackColor = true;
			this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 360);
			this.Controls.Add(this.NewGameButton);
			this.Controls.Add(this.ResultTextBox);
			this.Controls.Add(this.CalcButton);
			this.Controls.Add(this.InputTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Button CalcButton;
		private System.Windows.Forms.TextBox ResultTextBox;
		private System.Windows.Forms.Button NewGameButton;
	}
}

