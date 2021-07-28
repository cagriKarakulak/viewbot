namespace CaracalViewBotv3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.url_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewDone_progressbar = new System.Windows.Forms.ProgressBar();
            this.viewDone_lbl = new System.Windows.Forms.Label();
            this.proxyList_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userAgents_txtbox = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.loadProxyList_btn = new System.Windows.Forms.Button();
            this.loadUserAgents_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.proxyUsed_lbl = new System.Windows.Forms.Label();
            this.userAgentsAmount_lbl = new System.Windows.Forms.Label();
            this.proxyAmount_lbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.log_lstbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delay_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.afterDelay_nud = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delay_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterDelay_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // url_txtbox
            // 
            this.url_txtbox.Location = new System.Drawing.Point(50, 8);
            this.url_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.url_txtbox.Name = "url_txtbox";
            this.url_txtbox.Size = new System.Drawing.Size(210, 20);
            this.url_txtbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "View Done:";
            // 
            // viewDone_progressbar
            // 
            this.viewDone_progressbar.Location = new System.Drawing.Point(96, 46);
            this.viewDone_progressbar.Margin = new System.Windows.Forms.Padding(2);
            this.viewDone_progressbar.Name = "viewDone_progressbar";
            this.viewDone_progressbar.Size = new System.Drawing.Size(159, 41);
            this.viewDone_progressbar.TabIndex = 5;
            // 
            // viewDone_lbl
            // 
            this.viewDone_lbl.AutoSize = true;
            this.viewDone_lbl.Location = new System.Drawing.Point(259, 59);
            this.viewDone_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewDone_lbl.Name = "viewDone_lbl";
            this.viewDone_lbl.Size = new System.Drawing.Size(13, 13);
            this.viewDone_lbl.TabIndex = 6;
            this.viewDone_lbl.Text = "0";
            // 
            // proxyList_txtbox
            // 
            this.proxyList_txtbox.Location = new System.Drawing.Point(313, 28);
            this.proxyList_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.proxyList_txtbox.Multiline = true;
            this.proxyList_txtbox.Name = "proxyList_txtbox";
            this.proxyList_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.proxyList_txtbox.Size = new System.Drawing.Size(198, 164);
            this.proxyList_txtbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(366, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Proxy List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(371, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "User-Agents";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // userAgents_txtbox
            // 
            this.userAgents_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userAgents_txtbox.Location = new System.Drawing.Point(2, 253);
            this.userAgents_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.userAgents_txtbox.Multiline = true;
            this.userAgents_txtbox.Name = "userAgents_txtbox";
            this.userAgents_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userAgents_txtbox.Size = new System.Drawing.Size(853, 164);
            this.userAgents_txtbox.TabIndex = 9;
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_btn.Location = new System.Drawing.Point(118, 197);
            this.start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(96, 46);
            this.start_btn.TabIndex = 11;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // loadProxyList_btn
            // 
            this.loadProxyList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadProxyList_btn.Location = new System.Drawing.Point(338, 197);
            this.loadProxyList_btn.Margin = new System.Windows.Forms.Padding(2);
            this.loadProxyList_btn.Name = "loadProxyList_btn";
            this.loadProxyList_btn.Size = new System.Drawing.Size(144, 26);
            this.loadProxyList_btn.TabIndex = 13;
            this.loadProxyList_btn.Text = "Load Proxy List";
            this.loadProxyList_btn.UseVisualStyleBackColor = true;
            this.loadProxyList_btn.Click += new System.EventHandler(this.loadProxyList_btn_Click);
            // 
            // loadUserAgents_btn
            // 
            this.loadUserAgents_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadUserAgents_btn.Location = new System.Drawing.Point(348, 421);
            this.loadUserAgents_btn.Margin = new System.Windows.Forms.Padding(2);
            this.loadUserAgents_btn.Name = "loadUserAgents_btn";
            this.loadUserAgents_btn.Size = new System.Drawing.Size(144, 26);
            this.loadUserAgents_btn.TabIndex = 14;
            this.loadUserAgents_btn.Text = "Load User-Agents";
            this.loadUserAgents_btn.UseVisualStyleBackColor = true;
            this.loadUserAgents_btn.Click += new System.EventHandler(this.loadUserAgents_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Proxy Used:";
            // 
            // proxyUsed_lbl
            // 
            this.proxyUsed_lbl.AutoSize = true;
            this.proxyUsed_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proxyUsed_lbl.Location = new System.Drawing.Point(104, 172);
            this.proxyUsed_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.proxyUsed_lbl.Name = "proxyUsed_lbl";
            this.proxyUsed_lbl.Size = new System.Drawing.Size(15, 16);
            this.proxyUsed_lbl.TabIndex = 16;
            this.proxyUsed_lbl.Text = "0";
            // 
            // userAgentsAmount_lbl
            // 
            this.userAgentsAmount_lbl.AutoSize = true;
            this.userAgentsAmount_lbl.Location = new System.Drawing.Point(470, 235);
            this.userAgentsAmount_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userAgentsAmount_lbl.Name = "userAgentsAmount_lbl";
            this.userAgentsAmount_lbl.Size = new System.Drawing.Size(13, 13);
            this.userAgentsAmount_lbl.TabIndex = 17;
            this.userAgentsAmount_lbl.Text = "0";
            // 
            // proxyAmount_lbl
            // 
            this.proxyAmount_lbl.AutoSize = true;
            this.proxyAmount_lbl.Location = new System.Drawing.Point(453, 9);
            this.proxyAmount_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.proxyAmount_lbl.Name = "proxyAmount_lbl";
            this.proxyAmount_lbl.Size = new System.Drawing.Size(13, 13);
            this.proxyAmount_lbl.TabIndex = 18;
            this.proxyAmount_lbl.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(642, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Log List";
            // 
            // log_lstbox
            // 
            this.log_lstbox.FormattingEnabled = true;
            this.log_lstbox.HorizontalScrollbar = true;
            this.log_lstbox.Location = new System.Drawing.Point(515, 28);
            this.log_lstbox.Margin = new System.Windows.Forms.Padding(2);
            this.log_lstbox.Name = "log_lstbox";
            this.log_lstbox.Size = new System.Drawing.Size(340, 160);
            this.log_lstbox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Wait For Opening:";
            // 
            // delay_numericUpDown
            // 
            this.delay_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delay_numericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delay_numericUpDown.Location = new System.Drawing.Point(151, 99);
            this.delay_numericUpDown.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.delay_numericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delay_numericUpDown.Name = "delay_numericUpDown";
            this.delay_numericUpDown.Size = new System.Drawing.Size(96, 22);
            this.delay_numericUpDown.TabIndex = 23;
            this.delay_numericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // afterDelay_nud
            // 
            this.afterDelay_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.afterDelay_nud.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.afterDelay_nud.Location = new System.Drawing.Point(151, 133);
            this.afterDelay_nud.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.afterDelay_nud.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.afterDelay_nud.Name = "afterDelay_nud";
            this.afterDelay_nud.Size = new System.Drawing.Size(96, 22);
            this.afterDelay_nud.TabIndex = 25;
            this.afterDelay_nud.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Wait After Opening:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(862, 453);
            this.Controls.Add(this.afterDelay_nud);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delay_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log_lstbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.proxyAmount_lbl);
            this.Controls.Add(this.userAgentsAmount_lbl);
            this.Controls.Add(this.proxyUsed_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loadUserAgents_btn);
            this.Controls.Add(this.loadProxyList_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userAgents_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proxyList_txtbox);
            this.Controls.Add(this.viewDone_lbl);
            this.Controls.Add(this.viewDone_progressbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.url_txtbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caracal View Bot v3";
            ((System.ComponentModel.ISupportInitialize)(this.delay_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterDelay_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar viewDone_progressbar;
        private System.Windows.Forms.Label viewDone_lbl;
        private System.Windows.Forms.TextBox proxyList_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userAgents_txtbox;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button loadProxyList_btn;
        private System.Windows.Forms.Button loadUserAgents_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label proxyUsed_lbl;
        private System.Windows.Forms.Label userAgentsAmount_lbl;
        private System.Windows.Forms.Label proxyAmount_lbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown delay_numericUpDown;
        private System.Windows.Forms.NumericUpDown afterDelay_nud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox log_lstbox;
    }
}

