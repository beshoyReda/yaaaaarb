﻿namespace DatabaseProject
{
    partial class ProductManageAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlContainer = new System.Windows.Forms.Panel();
            this.Manu = new System.Windows.Forms.TextBox();
            this.Manufac = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DescBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SubCateg = new System.Windows.Forms.ComboBox();
            this.Categ = new System.Windows.Forms.ComboBox();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.Ref = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Refurbished = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ControlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlContainer
            // 
            this.ControlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(192)))), ((int)(((byte)(223)))));
            this.ControlContainer.Controls.Add(this.Manu);
            this.ControlContainer.Controls.Add(this.Manufac);
            this.ControlContainer.Controls.Add(this.button3);
            this.ControlContainer.Controls.Add(this.button2);
            this.ControlContainer.Controls.Add(this.button1);
            this.ControlContainer.Controls.Add(this.Quantity);
            this.ControlContainer.Controls.Add(this.label8);
            this.ControlContainer.Controls.Add(this.DescBox);
            this.ControlContainer.Controls.Add(this.label6);
            this.ControlContainer.Controls.Add(this.SubCateg);
            this.ControlContainer.Controls.Add(this.Categ);
            this.ControlContainer.Controls.Add(this.ProductID);
            this.ControlContainer.Controls.Add(this.label7);
            this.ControlContainer.Controls.Add(this.PriceBox);
            this.ControlContainer.Controls.Add(this.Ref);
            this.ControlContainer.Controls.Add(this.ProductName);
            this.ControlContainer.Controls.Add(this.label5);
            this.ControlContainer.Controls.Add(this.Refurbished);
            this.ControlContainer.Controls.Add(this.label3);
            this.ControlContainer.Controls.Add(this.label2);
            this.ControlContainer.Controls.Add(this.label1);
            this.ControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlContainer.Location = new System.Drawing.Point(0, 0);
            this.ControlContainer.Name = "ControlContainer";
            this.ControlContainer.Size = new System.Drawing.Size(1164, 573);
            this.ControlContainer.TabIndex = 3;
            this.ControlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlContainer_Paint);
            // 
            // Manu
            // 
            this.Manu.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Manu.Location = new System.Drawing.Point(769, 295);
            this.Manu.Name = "Manu";
            this.Manu.Size = new System.Drawing.Size(257, 38);
            this.Manu.TabIndex = 21;
            // 
            // Manufac
            // 
            this.Manufac.AutoSize = true;
            this.Manufac.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manufac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Manufac.Location = new System.Drawing.Point(569, 298);
            this.Manufac.Name = "Manufac";
            this.Manufac.Size = new System.Drawing.Size(155, 31);
            this.Manufac.TabIndex = 20;
            this.Manufac.Text = "Manufacturer";
            this.Manufac.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(918, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(918, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(100)))), ((int)(((byte)(161)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(918, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Quantity.Location = new System.Drawing.Point(769, 225);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(257, 38);
            this.Quantity.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.label8.Location = new System.Drawing.Point(569, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantity";
            // 
            // DescBox
            // 
            this.DescBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DescBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescBox.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DescBox.Location = new System.Drawing.Point(241, 378);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(649, 163);
            this.DescBox.TabIndex = 14;
            this.DescBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.label6.Location = new System.Drawing.Point(62, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Description";
            // 
            // SubCateg
            // 
            this.SubCateg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCateg.FormattingEnabled = true;
            this.SubCateg.Location = new System.Drawing.Point(769, 142);
            this.SubCateg.Name = "SubCateg";
            this.SubCateg.Size = new System.Drawing.Size(257, 33);
            this.SubCateg.TabIndex = 12;
            // 
            // Categ
            // 
            this.Categ.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categ.FormattingEnabled = true;
            this.Categ.Location = new System.Drawing.Point(241, 150);
            this.Categ.Name = "Categ";
            this.Categ.Size = new System.Drawing.Size(257, 33);
            this.Categ.TabIndex = 11;
            this.Categ.SelectedIndexChanged += new System.EventHandler(this.Categ_SelectedIndexChanged);
            // 
            // ProductID
            // 
            this.ProductID.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.ProductID.Location = new System.Drawing.Point(769, 74);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(257, 38);
            this.ProductID.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.label7.Location = new System.Drawing.Point(569, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Product ID";
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.PriceBox.Location = new System.Drawing.Point(241, 295);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(257, 38);
            this.PriceBox.TabIndex = 8;
            // 
            // Ref
            // 
            this.Ref.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.Ref.Location = new System.Drawing.Point(241, 221);
            this.Ref.Name = "Ref";
            this.Ref.Size = new System.Drawing.Size(257, 38);
            this.Ref.TabIndex = 7;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.ProductName.Location = new System.Drawing.Point(241, 74);
            this.ProductName.Name = "ProductName";
            this.ProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductName.Size = new System.Drawing.Size(257, 38);
            this.ProductName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(62, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // Refurbished
            // 
            this.Refurbished.AutoSize = true;
            this.Refurbished.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refurbished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.Refurbished.Location = new System.Drawing.Point(62, 224);
            this.Refurbished.Name = "Refurbished";
            this.Refurbished.Size = new System.Drawing.Size(138, 31);
            this.Refurbished.TabIndex = 3;
            this.Refurbished.Text = "Refurbished";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(569, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subcategory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(62, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(62, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // ProductManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControlContainer);
            this.Name = "ProductManageAdmin";
            this.Size = new System.Drawing.Size(1164, 573);
            this.Load += new System.EventHandler(this.ProductManageAdmin_Load);
            this.ControlContainer.ResumeLayout(false);
            this.ControlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlContainer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox DescBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SubCateg;
        private System.Windows.Forms.ComboBox Categ;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox Ref;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Refurbished;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Manu;
        private System.Windows.Forms.Label Manufac;
    }
}
