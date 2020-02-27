namespace VertexGatherer
{
    partial class CtrlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxPosition = new System.Windows.Forms.CheckBox();
            this.checkBoxWeight = new System.Windows.Forms.CheckBox();
            this.checkBoxNormal = new System.Windows.Forms.CheckBox();
            this.checkBoxUV = new System.Windows.Forms.CheckBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelDesc = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageDesc = new System.Windows.Forms.TabPage();
            this.labelVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.checkBoxPosition, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxWeight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxNormal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUV, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(159, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // checkBoxPosition
            // 
            this.checkBoxPosition.AutoSize = true;
            this.checkBoxPosition.Checked = true;
            this.checkBoxPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPosition.Location = new System.Drawing.Point(3, 3);
            this.checkBoxPosition.Name = "checkBoxPosition";
            this.checkBoxPosition.Size = new System.Drawing.Size(58, 23);
            this.checkBoxPosition.TabIndex = 0;
            this.checkBoxPosition.Text = "位置";
            this.checkBoxPosition.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeight
            // 
            this.checkBoxWeight.AutoSize = true;
            this.checkBoxWeight.Checked = true;
            this.checkBoxWeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWeight.Location = new System.Drawing.Point(82, 3);
            this.checkBoxWeight.Name = "checkBoxWeight";
            this.checkBoxWeight.Size = new System.Drawing.Size(69, 23);
            this.checkBoxWeight.TabIndex = 1;
            this.checkBoxWeight.Text = "ウェイト";
            this.checkBoxWeight.UseVisualStyleBackColor = true;
            // 
            // checkBoxNormal
            // 
            this.checkBoxNormal.AutoSize = true;
            this.checkBoxNormal.Checked = true;
            this.checkBoxNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNormal.Location = new System.Drawing.Point(3, 32);
            this.checkBoxNormal.Name = "checkBoxNormal";
            this.checkBoxNormal.Size = new System.Drawing.Size(58, 24);
            this.checkBoxNormal.TabIndex = 2;
            this.checkBoxNormal.Text = "法線";
            this.checkBoxNormal.UseVisualStyleBackColor = true;
            // 
            // checkBoxUV
            // 
            this.checkBoxUV.AutoSize = true;
            this.checkBoxUV.Location = new System.Drawing.Point(82, 32);
            this.checkBoxUV.Name = "checkBoxUV";
            this.checkBoxUV.Size = new System.Drawing.Size(47, 24);
            this.checkBoxUV.TabIndex = 3;
            this.checkBoxUV.Text = "UV";
            this.checkBoxUV.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(7, 75);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(159, 33);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "実行";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(6, 3);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(269, 40);
            this.labelDesc.TabIndex = 2;
            this.labelDesc.Text = "選択頂点の指定した数値を平均値に揃える\r\nウェイトは重いボーンから4つまでが採用される";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageDesc);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(187, 145);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMain.Controls.Add(this.tableLayoutPanel1);
            this.tabPageMain.Controls.Add(this.buttonRun);
            this.tabPageMain.Location = new System.Drawing.Point(4, 29);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(179, 112);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "実行";
            // 
            // tabPageDesc
            // 
            this.tabPageDesc.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDesc.Controls.Add(this.labelVersion);
            this.tabPageDesc.Controls.Add(this.labelDesc);
            this.tabPageDesc.Location = new System.Drawing.Point(4, 29);
            this.tabPageDesc.Name = "tabPageDesc";
            this.tabPageDesc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesc.Size = new System.Drawing.Size(179, 112);
            this.tabPageDesc.TabIndex = 1;
            this.tabPageDesc.Text = "説明";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(123, 88);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(53, 20);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Ver 1.1";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // CtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 146);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CtrlForm";
            this.ShowIcon = false;
            this.Text = "頂点集結";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageDesc.ResumeLayout(false);
            this.tabPageDesc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxPosition;
        private System.Windows.Forms.CheckBox checkBoxWeight;
        private System.Windows.Forms.CheckBox checkBoxNormal;
        private System.Windows.Forms.CheckBox checkBoxUV;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageDesc;
        private System.Windows.Forms.Label labelVersion;
    }
}