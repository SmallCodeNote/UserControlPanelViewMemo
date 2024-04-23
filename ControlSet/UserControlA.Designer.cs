namespace ControlSet
{
    partial class UserControlA
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_subFormName = new System.Windows.Forms.GroupBox();
            this.button_ToString = new System.Windows.Forms.Button();
            this.button_DeleteThis = new System.Windows.Forms.Button();
            this.textBox_Param1 = new System.Windows.Forms.TextBox();
            this.textBox_Param2 = new System.Windows.Forms.TextBox();
            this.groupBox_subFormName.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_subFormName
            // 
            this.groupBox_subFormName.Controls.Add(this.textBox_Param2);
            this.groupBox_subFormName.Controls.Add(this.textBox_Param1);
            this.groupBox_subFormName.Controls.Add(this.button_ToString);
            this.groupBox_subFormName.Controls.Add(this.button_DeleteThis);
            this.groupBox_subFormName.Location = new System.Drawing.Point(3, 3);
            this.groupBox_subFormName.Name = "groupBox_subFormName";
            this.groupBox_subFormName.Size = new System.Drawing.Size(357, 81);
            this.groupBox_subFormName.TabIndex = 0;
            this.groupBox_subFormName.TabStop = false;
            this.groupBox_subFormName.Text = "subFormName";
            // 
            // button_ToString
            // 
            this.button_ToString.Location = new System.Drawing.Point(225, -5);
            this.button_ToString.Name = "button_ToString";
            this.button_ToString.Size = new System.Drawing.Size(75, 23);
            this.button_ToString.TabIndex = 1;
            this.button_ToString.Text = "ToString";
            this.button_ToString.UseVisualStyleBackColor = true;
            this.button_ToString.Click += new System.EventHandler(this.button_ToString_Click);
            // 
            // button_DeleteThis
            // 
            this.button_DeleteThis.Location = new System.Drawing.Point(335, -3);
            this.button_DeleteThis.Name = "button_DeleteThis";
            this.button_DeleteThis.Size = new System.Drawing.Size(22, 18);
            this.button_DeleteThis.TabIndex = 0;
            this.button_DeleteThis.Text = "X";
            this.button_DeleteThis.UseVisualStyleBackColor = true;
            this.button_DeleteThis.Click += new System.EventHandler(this.button_DeleteThis_Click);
            // 
            // textBox_Param1
            // 
            this.textBox_Param1.Location = new System.Drawing.Point(6, 18);
            this.textBox_Param1.Name = "textBox_Param1";
            this.textBox_Param1.Size = new System.Drawing.Size(187, 19);
            this.textBox_Param1.TabIndex = 2;
            // 
            // textBox_Param2
            // 
            this.textBox_Param2.Location = new System.Drawing.Point(6, 43);
            this.textBox_Param2.Name = "textBox_Param2";
            this.textBox_Param2.Size = new System.Drawing.Size(187, 19);
            this.textBox_Param2.TabIndex = 2;
            // 
            // UserControlA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_subFormName);
            this.Name = "UserControlA";
            this.Size = new System.Drawing.Size(398, 89);
            this.groupBox_subFormName.ResumeLayout(false);
            this.groupBox_subFormName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_subFormName;
        private System.Windows.Forms.Button button_DeleteThis;
        private System.Windows.Forms.Button button_ToString;
        private System.Windows.Forms.TextBox textBox_Param1;
        private System.Windows.Forms.TextBox textBox_Param2;
    }
}
