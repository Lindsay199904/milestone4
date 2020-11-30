namespace Inventory_Management_System
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
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.partNumberLabel = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityOnHandTextBox = new System.Windows.Forms.TextBox();
            this.quantityOnHandLabel = new System.Windows.Forms.Label();
            this.unitMeasurementLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.inventoryLocationLabel = new System.Windows.Forms.Label();
            this.unitMeasurementTextBox = new System.Windows.Forms.TextBox();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLocationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ReOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.ItemSelectButton = new System.Windows.Forms.Button();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(16, 55);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(79, 17);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(168, 47);
            this.itemNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.itemNameTextBox.TabIndex = 0;
            this.itemNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemNameTextBox.TextChanged += new System.EventHandler(this.itemNameTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(16, 87);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(113, 17);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Item Description:";
            // 
            // partNumberLabel
            // 
            this.partNumberLabel.AutoSize = true;
            this.partNumberLabel.Location = new System.Drawing.Point(16, 119);
            this.partNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partNumberLabel.Name = "partNumberLabel";
            this.partNumberLabel.Size = new System.Drawing.Size(92, 17);
            this.partNumberLabel.TabIndex = 3;
            this.partNumberLabel.Text = "Part Number:";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(168, 175);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.unitPriceTextBox.TabIndex = 4;
            this.unitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityOnHandTextBox
            // 
            this.quantityOnHandTextBox.Location = new System.Drawing.Point(168, 207);
            this.quantityOnHandTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityOnHandTextBox.Name = "quantityOnHandTextBox";
            this.quantityOnHandTextBox.Size = new System.Drawing.Size(132, 22);
            this.quantityOnHandTextBox.TabIndex = 5;
            this.quantityOnHandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityOnHandLabel
            // 
            this.quantityOnHandLabel.AutoSize = true;
            this.quantityOnHandLabel.Location = new System.Drawing.Point(16, 215);
            this.quantityOnHandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityOnHandLabel.Name = "quantityOnHandLabel";
            this.quantityOnHandLabel.Size = new System.Drawing.Size(126, 17);
            this.quantityOnHandLabel.TabIndex = 6;
            this.quantityOnHandLabel.Text = "Quantity On Hand:";
            // 
            // unitMeasurementLabel
            // 
            this.unitMeasurementLabel.AutoSize = true;
            this.unitMeasurementLabel.Location = new System.Drawing.Point(16, 151);
            this.unitMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitMeasurementLabel.Name = "unitMeasurementLabel";
            this.unitMeasurementLabel.Size = new System.Drawing.Size(127, 17);
            this.unitMeasurementLabel.TabIndex = 7;
            this.unitMeasurementLabel.Text = "Unit Measurement:";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Location = new System.Drawing.Point(16, 183);
            this.unitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(73, 17);
            this.unitPriceLabel.TabIndex = 8;
            this.unitPriceLabel.Text = "Unit Price:";
            // 
            // inventoryLocationLabel
            // 
            this.inventoryLocationLabel.AutoSize = true;
            this.inventoryLocationLabel.Location = new System.Drawing.Point(16, 247);
            this.inventoryLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryLocationLabel.Name = "inventoryLocationLabel";
            this.inventoryLocationLabel.Size = new System.Drawing.Size(128, 17);
            this.inventoryLocationLabel.TabIndex = 9;
            this.inventoryLocationLabel.Text = "Inventory Location:";
            // 
            // unitMeasurementTextBox
            // 
            this.unitMeasurementTextBox.Location = new System.Drawing.Point(168, 143);
            this.unitMeasurementTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitMeasurementTextBox.Name = "unitMeasurementTextBox";
            this.unitMeasurementTextBox.Size = new System.Drawing.Size(132, 22);
            this.unitMeasurementTextBox.TabIndex = 3;
            this.unitMeasurementTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitMeasurementTextBox.TextChanged += new System.EventHandler(this.unitMeasurementTextBox_TextChanged);
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(168, 111);
            this.partNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.partNumberTextBox.TabIndex = 2;
            this.partNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(168, 79);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(132, 22);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inventoryLocationTextBox
            // 
            this.inventoryLocationTextBox.Location = new System.Drawing.Point(168, 239);
            this.inventoryLocationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryLocationTextBox.Name = "inventoryLocationTextBox";
            this.inventoryLocationTextBox.Size = new System.Drawing.Size(132, 22);
            this.inventoryLocationTextBox.TabIndex = 6;
            this.inventoryLocationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(823, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Inventory Item";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(355, 55);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 28);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(739, 55);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 28);
            this.EditButton.TabIndex = 10;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(742, 91);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 28);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(355, 127);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 28);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ReOrderButton
            // 
            this.ReOrderButton.Location = new System.Drawing.Point(742, 236);
            this.ReOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReOrderButton.Name = "ReOrderButton";
            this.ReOrderButton.Size = new System.Drawing.Size(100, 28);
            this.ReOrderButton.TabIndex = 14;
            this.ReOrderButton.Text = "ReOrder";
            this.ReOrderButton.UseVisualStyleBackColor = true;
            this.ReOrderButton.Click += new System.EventHandler(this.ReOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(355, 239);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 28);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(16, 285);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(826, 185);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Description";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Part Number";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unit Measurement";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unit Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity on Hand";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Inventory Location";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 16;
            this.itemListBox.Location = new System.Drawing.Point(480, 55);
            this.itemListBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(217, 212);
            this.itemListBox.TabIndex = 16;
            // 
            // ItemSelectButton
            // 
            this.ItemSelectButton.Location = new System.Drawing.Point(355, 91);
            this.ItemSelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.ItemSelectButton.Name = "ItemSelectButton";
            this.ItemSelectButton.Size = new System.Drawing.Size(100, 28);
            this.ItemSelectButton.TabIndex = 8;
            this.ItemSelectButton.Text = "Select Item";
            this.ItemSelectButton.UseVisualStyleBackColor = true;
            this.ItemSelectButton.Click += new System.EventHandler(this.ItemSelectButton_Click);
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Location = new System.Drawing.Point(707, 204);
            this.reorderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.Size = new System.Drawing.Size(132, 22);
            this.reorderTextBox.TabIndex = 13;
            this.reorderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Order Amount";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(742, 127);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 28);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 539);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.ItemSelectButton);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReOrderButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inventoryLocationTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(this.unitMeasurementTextBox);
            this.Controls.Add(this.inventoryLocationLabel);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.unitMeasurementLabel);
            this.Controls.Add(this.quantityOnHandLabel);
            this.Controls.Add(this.quantityOnHandTextBox);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.partNumberLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label partNumberLabel;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox quantityOnHandTextBox;
        private System.Windows.Forms.Label quantityOnHandLabel;
        private System.Windows.Forms.Label unitMeasurementLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label inventoryLocationLabel;
        private System.Windows.Forms.TextBox unitMeasurementTextBox;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox inventoryLocationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ReOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Button ItemSelectButton;
        private System.Windows.Forms.TextBox reorderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

