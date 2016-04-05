namespace WinFromTest
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
            this.lblSourceEnv = new System.Windows.Forms.Label();
            this.lblNowEnv = new System.Windows.Forms.Label();
            this.numMinWorkThreads = new System.Windows.Forms.NumericUpDown();
            this.numMinCompletionPortThreads = new System.Windows.Forms.NumericUpDown();
            this.btnSaveMin = new System.Windows.Forms.Button();
            this.numDefaultConnectionLimit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnParallel = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnSetServer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMinWorkThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinCompletionPortThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultConnectionLimit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSourceEnv
            // 
            this.lblSourceEnv.AutoSize = true;
            this.lblSourceEnv.Location = new System.Drawing.Point(15, 56);
            this.lblSourceEnv.Name = "lblSourceEnv";
            this.lblSourceEnv.Size = new System.Drawing.Size(41, 12);
            this.lblSourceEnv.TabIndex = 1;
            this.lblSourceEnv.Text = "label1";
            // 
            // lblNowEnv
            // 
            this.lblNowEnv.AutoSize = true;
            this.lblNowEnv.Location = new System.Drawing.Point(15, 75);
            this.lblNowEnv.Name = "lblNowEnv";
            this.lblNowEnv.Size = new System.Drawing.Size(41, 12);
            this.lblNowEnv.TabIndex = 1;
            this.lblNowEnv.Text = "label1";
            // 
            // numMinWorkThreads
            // 
            this.numMinWorkThreads.Location = new System.Drawing.Point(111, 26);
            this.numMinWorkThreads.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMinWorkThreads.Name = "numMinWorkThreads";
            this.numMinWorkThreads.Size = new System.Drawing.Size(61, 21);
            this.numMinWorkThreads.TabIndex = 2;
            this.numMinWorkThreads.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numMinCompletionPortThreads
            // 
            this.numMinCompletionPortThreads.Location = new System.Drawing.Point(335, 27);
            this.numMinCompletionPortThreads.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMinCompletionPortThreads.Name = "numMinCompletionPortThreads";
            this.numMinCompletionPortThreads.Size = new System.Drawing.Size(61, 21);
            this.numMinCompletionPortThreads.TabIndex = 2;
            this.numMinCompletionPortThreads.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // btnSaveMin
            // 
            this.btnSaveMin.Location = new System.Drawing.Point(637, 29);
            this.btnSaveMin.Name = "btnSaveMin";
            this.btnSaveMin.Size = new System.Drawing.Size(60, 23);
            this.btnSaveMin.TabIndex = 3;
            this.btnSaveMin.Text = "Save";
            this.btnSaveMin.UseVisualStyleBackColor = true;
            this.btnSaveMin.Click += new System.EventHandler(this.btnSaveMin_Click);
            // 
            // numDefaultConnectionLimit
            // 
            this.numDefaultConnectionLimit.Location = new System.Drawing.Point(549, 29);
            this.numDefaultConnectionLimit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numDefaultConnectionLimit.Name = "numDefaultConnectionLimit";
            this.numDefaultConnectionLimit.Size = new System.Drawing.Size(82, 21);
            this.numDefaultConnectionLimit.TabIndex = 2;
            this.numDefaultConnectionLimit.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "MinWorkThreads:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "MinCompletionPortThreads:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "DefaultConnectionLimit:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSourceEnv);
            this.groupBox1.Controls.Add(this.lblNowEnv);
            this.groupBox1.Controls.Add(this.btnSaveMin);
            this.groupBox1.Controls.Add(this.numMinWorkThreads);
            this.groupBox1.Controls.Add(this.numDefaultConnectionLimit);
            this.groupBox1.Controls.Add(this.numMinCompletionPortThreads);
            this.groupBox1.Location = new System.Drawing.Point(19, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Env";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "count:";
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(19, 373);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(770, 23);
            this.btnAsync.TabIndex = 0;
            this.btnAsync.Text = "Async 什么都不设置";
            this.btnAsync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(19, 291);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(770, 23);
            this.btnParallel.TabIndex = 0;
            this.btnParallel.Text = "Parallel 要设置Env为比较大的数才快，线程数也增长很快，因为就是用线程来提高并发的";
            this.btnParallel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParallel.UseVisualStyleBackColor = true;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(19, 124);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(763, 23);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync 一个一个来，肯定很慢，线程数没什么变化";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // numTotal
            // 
            this.numTotal.Location = new System.Drawing.Point(63, 53);
            this.numTotal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTotal.Name = "numTotal";
            this.numTotal.Size = new System.Drawing.Size(61, 21);
            this.numTotal.TabIndex = 2;
            this.numTotal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "url:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(204, 55);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(519, 21);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "http://localhost:36020/api/test/sleep/10000";
            // 
            // btnSetServer
            // 
            this.btnSetServer.Location = new System.Drawing.Point(596, 25);
            this.btnSetServer.Name = "btnSetServer";
            this.btnSetServer.Size = new System.Drawing.Size(75, 23);
            this.btnSetServer.TabIndex = 7;
            this.btnSetServer.Text = "Set Server";
            this.btnSetServer.UseVisualStyleBackColor = true;
            this.btnSetServer.Click += new System.EventHandler(this.btnSetServer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "url:";
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.Location = new System.Drawing.Point(53, 30);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(519, 21);
            this.txtServerUrl.TabIndex = 6;
            this.txtServerUrl.Text = "http://localhost:36020/api/test/Init/100/200";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUrl);
            this.groupBox3.Controls.Add(this.btnSetServer);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtServerUrl);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numTotal);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(771, 80);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "先设置服务器可以接受大并发（通过设置最小线程数实现）";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 425);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnParallel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSync);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numMinWorkThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinCompletionPortThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultConnectionLimit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSourceEnv;
        private System.Windows.Forms.Label lblNowEnv;
        private System.Windows.Forms.NumericUpDown numMinWorkThreads;
        private System.Windows.Forms.NumericUpDown numMinCompletionPortThreads;
        private System.Windows.Forms.Button btnSaveMin;
        private System.Windows.Forms.NumericUpDown numDefaultConnectionLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSetServer;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

