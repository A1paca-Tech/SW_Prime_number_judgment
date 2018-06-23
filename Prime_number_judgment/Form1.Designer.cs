namespace Prime_number_judgment
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
            this.bt_run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nb = new System.Windows.Forms.TextBox();
            this.lb_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_run
            // 
            this.bt_run.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt_run.Location = new System.Drawing.Point(17, 84);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(250, 43);
            this.bt_run.TabIndex = 0;
            this.bt_run.Text = "Run";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入欲判斷的數字";
            // 
            // tb_nb
            // 
            this.tb_nb.Font = new System.Drawing.Font("新細明體", 20F);
            this.tb_nb.Location = new System.Drawing.Point(17, 39);
            this.tb_nb.Name = "tb_nb";
            this.tb_nb.Size = new System.Drawing.Size(250, 39);
            this.tb_nb.TabIndex = 2;
            // 
            // lb_show
            // 
            this.lb_show.AutoSize = true;
            this.lb_show.Font = new System.Drawing.Font("新細明體", 20F);
            this.lb_show.Location = new System.Drawing.Point(12, 130);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(86, 27);
            this.lb_show.TabIndex = 3;
            this.lb_show.Text = "SHOW";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 202);
            this.Controls.Add(this.lb_show);
            this.Controls.Add(this.tb_nb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_run);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nb;
        private System.Windows.Forms.Label lb_show;
    }
}

