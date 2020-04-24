namespace CalcualtorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Nag = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_gdc = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_aclear = new System.Windows.Forms.Button();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.tb_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.写日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Nag
            // 
            this.btn_Nag.BackColor = System.Drawing.Color.White;
            this.btn_Nag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nag.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Nag.Location = new System.Drawing.Point(12, 507);
            this.btn_Nag.Name = "btn_Nag";
            this.btn_Nag.Size = new System.Drawing.Size(122, 64);
            this.btn_Nag.TabIndex = 2;
            this.btn_Nag.Text = "+/-";
            this.btn_Nag.UseVisualStyleBackColor = false;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_return.Location = new System.Drawing.Point(396, 507);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(122, 64);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "=";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.Color.White;
            this.btn_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dot.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dot.Location = new System.Drawing.Point(268, 507);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(122, 64);
            this.btn_dot.TabIndex = 4;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = false;
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.White;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_0.Location = new System.Drawing.Point(140, 507);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(122, 64);
            this.btn_0.TabIndex = 5;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.White;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_2.Location = new System.Drawing.Point(140, 437);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(122, 64);
            this.btn_2.TabIndex = 9;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.White;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_3.Location = new System.Drawing.Point(268, 437);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(122, 64);
            this.btn_3.TabIndex = 8;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(396, 437);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 64);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btnOps_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_1.Location = new System.Drawing.Point(12, 437);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(122, 64);
            this.btn_1.TabIndex = 6;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.White;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_5.Location = new System.Drawing.Point(140, 367);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(122, 64);
            this.btn_5.TabIndex = 13;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.White;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_6.Location = new System.Drawing.Point(268, 367);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(122, 64);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sub.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sub.Location = new System.Drawing.Point(396, 367);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(122, 64);
            this.btn_sub.TabIndex = 11;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btnOps_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.White;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_4.Location = new System.Drawing.Point(12, 367);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(122, 64);
            this.btn_4.TabIndex = 10;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.White;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_8.Location = new System.Drawing.Point(140, 297);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(122, 64);
            this.btn_8.TabIndex = 17;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.White;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_9.Location = new System.Drawing.Point(268, 297);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(122, 64);
            this.btn_9.TabIndex = 16;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_mul.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mul.Location = new System.Drawing.Point(396, 297);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(122, 64);
            this.btn_mul.TabIndex = 15;
            this.btn_mul.Text = "×";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btnOps_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.White;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_7.Location = new System.Drawing.Point(12, 297);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(122, 64);
            this.btn_7.TabIndex = 14;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btn_gdc
            // 
            this.btn_gdc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_gdc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_gdc.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gdc.Location = new System.Drawing.Point(140, 227);
            this.btn_gdc.Name = "btn_gdc";
            this.btn_gdc.Size = new System.Drawing.Size(122, 64);
            this.btn_gdc.TabIndex = 21;
            this.btn_gdc.Text = "%";
            this.btn_gdc.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_clear.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clear.Location = new System.Drawing.Point(268, 227);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 64);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_div.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_div.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_div.Location = new System.Drawing.Point(396, 227);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(122, 64);
            this.btn_div.TabIndex = 19;
            this.btn_div.Text = "÷";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btnOps_Click);
            // 
            // btn_aclear
            // 
            this.btn_aclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_aclear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_aclear.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_aclear.Location = new System.Drawing.Point(12, 227);
            this.btn_aclear.Name = "btn_aclear";
            this.btn_aclear.Size = new System.Drawing.Size(122, 64);
            this.btn_aclear.TabIndex = 18;
            this.btn_aclear.Text = "AC";
            this.btn_aclear.UseVisualStyleBackColor = false;
            this.btn_aclear.Click += new System.EventHandler(this.btn_aclear_Click);
            // 
            // tb_out
            // 
            this.tb_out.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_out.Font = new System.Drawing.Font("微软雅黑 Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_out.Location = new System.Drawing.Point(119, 78);
            this.tb_out.Name = "tb_out";
            this.tb_out.ReadOnly = true;
            this.tb_out.Size = new System.Drawing.Size(385, 36);
            this.tb_out.TabIndex = 22;
            this.tb_out.Text = "None";
            this.tb_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_in
            // 
            this.tb_in.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_in.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_in.Location = new System.Drawing.Point(119, 130);
            this.tb_in.Name = "tb_in";
            this.tb_in.ReadOnly = true;
            this.tb_in.Size = new System.Drawing.Size(385, 80);
            this.tb_in.TabIndex = 23;
            this.tb_in.Text = "0";
            this.tb_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 52);
            this.label1.TabIndex = 26;
            this.label1.Text = "标准";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日志ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 日志ToolStripMenuItem
            // 
            this.日志ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.写日志ToolStripMenuItem,
            this.读取日志ToolStripMenuItem});
            this.日志ToolStripMenuItem.Name = "日志ToolStripMenuItem";
            this.日志ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.日志ToolStripMenuItem.Text = "日志";
            this.日志ToolStripMenuItem.Click += new System.EventHandler(this.Form1_Load);
            // 
            // 写日志ToolStripMenuItem
            // 
            this.写日志ToolStripMenuItem.Name = "写日志ToolStripMenuItem";
            this.写日志ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.写日志ToolStripMenuItem.Text = "写入日志";
            this.写日志ToolStripMenuItem.Click += new System.EventHandler(this.日志ToolStripMenuItem_Click);
            // 
            // 读取日志ToolStripMenuItem
            // 
            this.读取日志ToolStripMenuItem.Name = "读取日志ToolStripMenuItem";
            this.读取日志ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.读取日志ToolStripMenuItem.Text = "读取日志";
            this.读取日志ToolStripMenuItem.Click += new System.EventHandler(this.读取日志ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(527, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_in);
            this.Controls.Add(this.tb_out);
            this.Controls.Add(this.btn_gdc);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_aclear);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_Nag);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "简单计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nag;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_gdc;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_aclear;
        private System.Windows.Forms.TextBox tb_out;
        private System.Windows.Forms.TextBox tb_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 写日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读取日志ToolStripMenuItem;
    }
}

