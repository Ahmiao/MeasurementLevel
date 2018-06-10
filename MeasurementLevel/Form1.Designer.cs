namespace MeasurementLevel
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dtView = new System.Windows.Forms.DataGridView();
            this.Input = new System.Windows.Forms.Button();
            this.pointNum = new System.Windows.Forms.TextBox();
            this.Cal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtView
            // 
            this.dtView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView.Location = new System.Drawing.Point(169, 47);
            this.dtView.Name = "dtView";
            this.dtView.RowTemplate.Height = 27;
            this.dtView.Size = new System.Drawing.Size(1063, 384);
            this.dtView.TabIndex = 0;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(26, 139);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(122, 36);
            this.Input.TabIndex = 1;
            this.Input.Text = "输入未知点";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // pointNum
            // 
            this.pointNum.Location = new System.Drawing.Point(41, 85);
            this.pointNum.Name = "pointNum";
            this.pointNum.Size = new System.Drawing.Size(75, 25);
            this.pointNum.TabIndex = 2;
            // 
            // Cal
            // 
            this.Cal.Location = new System.Drawing.Point(26, 196);
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(122, 34);
            this.Cal.TabIndex = 3;
            this.Cal.Text = "计算";
            this.Cal.UseVisualStyleBackColor = true;
            this.Cal.Click += new System.EventHandler(this.Cal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 486);
            this.Controls.Add(this.Cal);
            this.Controls.Add(this.pointNum);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.dtView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtView;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.TextBox pointNum;
        private System.Windows.Forms.Button Cal;
    }
}

