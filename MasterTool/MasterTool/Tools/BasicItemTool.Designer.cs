namespace MasterTool.Tools
{
    partial class BasicItemTool
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxStackCount = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellPriceCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.flavorTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxStackCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 225);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // maxStackCount
            // 
            this.maxStackCount.Location = new System.Drawing.Point(152, 51);
            this.maxStackCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.maxStackCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxStackCount.Name = "maxStackCount";
            this.maxStackCount.Size = new System.Drawing.Size(120, 20);
            this.maxStackCount.TabIndex = 2;
            this.maxStackCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(135, 15);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max Stack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sell Price";
            // 
            // sellPriceCount
            // 
            this.sellPriceCount.Location = new System.Drawing.Point(151, 86);
            this.sellPriceCount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.sellPriceCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sellPriceCount.Name = "sellPriceCount";
            this.sellPriceCount.Size = new System.Drawing.Size(120, 20);
            this.sellPriceCount.TabIndex = 5;
            this.sellPriceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Flavor Text";
            // 
            // flavorTextBox
            // 
            this.flavorTextBox.DetectUrls = false;
            this.flavorTextBox.Location = new System.Drawing.Point(97, 134);
            this.flavorTextBox.Multiline = false;
            this.flavorTextBox.Name = "flavorTextBox";
            this.flavorTextBox.Size = new System.Drawing.Size(175, 96);
            this.flavorTextBox.TabIndex = 8;
            this.flavorTextBox.Text = "";
            // 
            // BasicItemTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.flavorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellPriceCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.maxStackCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "BasicItemTool";
            this.Text = "Item Definitions";
            ((System.ComponentModel.ISupportInitialize)(this.maxStackCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maxStackCount;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sellPriceCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox flavorTextBox;
    }
}