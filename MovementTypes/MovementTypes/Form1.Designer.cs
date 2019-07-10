namespace MovementTypes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.movementTypeList = new System.Windows.Forms.ListBox();
            this.addMovementType = new System.Windows.Forms.Button();
            this.removeMovementType = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.validTileList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // movementTypeList
            // 
            this.movementTypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movementTypeList.FormattingEnabled = true;
            this.movementTypeList.ItemHeight = 20;
            this.movementTypeList.Location = new System.Drawing.Point(10, 10);
            this.movementTypeList.Name = "movementTypeList";
            this.movementTypeList.ScrollAlwaysVisible = true;
            this.movementTypeList.Size = new System.Drawing.Size(150, 404);
            this.movementTypeList.TabIndex = 0;
            // 
            // addMovementType
            // 
            this.addMovementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovementType.Location = new System.Drawing.Point(10, 415);
            this.addMovementType.Name = "addMovementType";
            this.addMovementType.Size = new System.Drawing.Size(75, 25);
            this.addMovementType.TabIndex = 1;
            this.addMovementType.Text = "+";
            this.addMovementType.UseVisualStyleBackColor = true;
            // 
            // removeMovementType
            // 
            this.removeMovementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMovementType.Location = new System.Drawing.Point(85, 415);
            this.removeMovementType.Name = "removeMovementType";
            this.removeMovementType.Size = new System.Drawing.Size(75, 25);
            this.removeMovementType.TabIndex = 2;
            this.removeMovementType.Text = "-";
            this.removeMovementType.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.validTileList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(166, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 440);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valid Tiles";
            // 
            // validTileList
            // 
            this.validTileList.FormattingEnabled = true;
            this.validTileList.Location = new System.Drawing.Point(22, 84);
            this.validTileList.Name = "validTileList";
            this.validTileList.Size = new System.Drawing.Size(138, 319);
            this.validTileList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tooltip
            // 
            this.tooltip.ToolTipTitle = "Name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(241, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Stopped by forest";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.removeMovementType);
            this.Controls.Add(this.addMovementType);
            this.Controls.Add(this.movementTypeList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox movementTypeList;
        private System.Windows.Forms.Button addMovementType;
        private System.Windows.Forms.Button removeMovementType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox validTileList;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

