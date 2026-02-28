namespace App_Manejo_Datos
{
    partial class ProductForm
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
            groupBox1 = new GroupBox();
            textInsertCategoria = new TextBox();
            label13 = new Label();
            textInsertID = new TextBox();
            buttonInsert = new Button();
            textInsertDescription = new TextBox();
            textInsertPrice = new TextBox();
            textInsertName = new TextBox();
            textInsertStock = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textDeleteID = new TextBox();
            buttonDelete = new Button();
            label6 = new Label();
            groupBox3 = new GroupBox();
            textUpdateCategoria = new TextBox();
            buttonUpdate = new Button();
            textUpdateDescription = new TextBox();
            textUpdateStock = new TextBox();
            textUpdateName = new TextBox();
            textUpdateID = new TextBox();
            textUpdatePrice = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            buttonShow = new Button();
            screen = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)screen).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textInsertCategoria);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textInsertID);
            groupBox1.Controls.Add(buttonInsert);
            groupBox1.Controls.Add(textInsertDescription);
            groupBox1.Controls.Add(textInsertPrice);
            groupBox1.Controls.Add(textInsertName);
            groupBox1.Controls.Add(textInsertStock);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 250);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            // 
            // textInsertCategoria
            // 
            textInsertCategoria.Location = new Point(137, 99);
            textInsertCategoria.Name = "textInsertCategoria";
            textInsertCategoria.Size = new Size(234, 27);
            textInsertCategoria.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 24);
            label13.Name = "label13";
            label13.Size = new Size(24, 20);
            label13.TabIndex = 12;
            label13.Text = "ID";
            // 
            // textInsertID
            // 
            textInsertID.Location = new Point(6, 46);
            textInsertID.Name = "textInsertID";
            textInsertID.Size = new Size(125, 27);
            textInsertID.TabIndex = 11;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(6, 184);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(365, 54);
            buttonInsert.TabIndex = 10;
            buttonInsert.Text = "Agregar";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // textInsertDescription
            // 
            textInsertDescription.Location = new Point(137, 151);
            textInsertDescription.Name = "textInsertDescription";
            textInsertDescription.Size = new Size(234, 27);
            textInsertDescription.TabIndex = 8;
            // 
            // textInsertPrice
            // 
            textInsertPrice.Location = new Point(6, 97);
            textInsertPrice.Name = "textInsertPrice";
            textInsertPrice.Size = new Size(125, 27);
            textInsertPrice.TabIndex = 7;
            // 
            // textInsertName
            // 
            textInsertName.Location = new Point(137, 46);
            textInsertName.Name = "textInsertName";
            textInsertName.Size = new Size(234, 27);
            textInsertName.TabIndex = 6;
            // 
            // textInsertStock
            // 
            textInsertStock.Location = new Point(6, 151);
            textInsertStock.Name = "textInsertStock";
            textInsertStock.Size = new Size(125, 27);
            textInsertStock.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 76);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 129);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 24);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textDeleteID);
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(383, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 250);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Insertar";
            // 
            // textDeleteID
            // 
            textDeleteID.Location = new Point(6, 46);
            textDeleteID.Name = "textDeleteID";
            textDeleteID.Size = new Size(188, 27);
            textDeleteID.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(6, 79);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(188, 54);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 0;
            label6.Text = "ID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textUpdateCategoria);
            groupBox3.Controls.Add(buttonUpdate);
            groupBox3.Controls.Add(textUpdateDescription);
            groupBox3.Controls.Add(textUpdateStock);
            groupBox3.Controls.Add(textUpdateName);
            groupBox3.Controls.Add(textUpdateID);
            groupBox3.Controls.Add(textUpdatePrice);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(595, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(452, 249);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // textUpdateCategoria
            // 
            textUpdateCategoria.Location = new Point(163, 96);
            textUpdateCategoria.Name = "textUpdateCategoria";
            textUpdateCategoria.Size = new Size(283, 27);
            textUpdateCategoria.TabIndex = 14;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(6, 183);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(440, 54);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Actualizar";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textUpdateDescription
            // 
            textUpdateDescription.Location = new Point(159, 150);
            textUpdateDescription.Name = "textUpdateDescription";
            textUpdateDescription.Size = new Size(287, 27);
            textUpdateDescription.TabIndex = 10;
            // 
            // textUpdateStock
            // 
            textUpdateStock.Location = new Point(6, 150);
            textUpdateStock.Name = "textUpdateStock";
            textUpdateStock.Size = new Size(147, 27);
            textUpdateStock.TabIndex = 9;
            // 
            // textUpdateName
            // 
            textUpdateName.Location = new Point(163, 45);
            textUpdateName.Name = "textUpdateName";
            textUpdateName.Size = new Size(283, 27);
            textUpdateName.TabIndex = 8;
            // 
            // textUpdateID
            // 
            textUpdateID.Location = new Point(6, 45);
            textUpdateID.Name = "textUpdateID";
            textUpdateID.Size = new Size(147, 27);
            textUpdateID.TabIndex = 7;
            // 
            // textUpdatePrice
            // 
            textUpdatePrice.Location = new Point(6, 97);
            textUpdatePrice.Name = "textUpdatePrice";
            textUpdatePrice.Size = new Size(151, 27);
            textUpdatePrice.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(163, 127);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 5;
            label12.Text = "Descripcion";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(159, 76);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 4;
            label11.Text = "Categoria";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 76);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 3;
            label10.Text = "Precio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 127);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 2;
            label9.Text = "Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(163, 22);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 1;
            label8.Text = "Nombre del Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 23);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 0;
            label7.Text = "ID";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonShow);
            groupBox4.Controls.Add(screen);
            groupBox4.Location = new Point(6, 245);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1035, 275);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(377, 12);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(194, 29);
            buttonShow.TabIndex = 1;
            buttonShow.Text = "Cargar";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // screen
            // 
            screen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            screen.Location = new Point(0, 47);
            screen.Name = "screen";
            screen.RowHeadersWidth = 51;
            screen.Size = new Size(1029, 217);
            screen.TabIndex = 0;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 521);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ProductForm";
            Text = "ProductForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)screen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textInsertPrice;
        private TextBox textInsertName;
        private TextBox textInsertStock;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox4;
        private DataGridView screen;
        private TextBox textInsertDescription;
        private Button buttonInsert;
        private TextBox textDeleteID;
        private Button buttonDelete;
        private Button buttonUpdate;
        private TextBox textUpdateDescription;
        private TextBox textUpdateStock;
        private TextBox textUpdateName;
        private TextBox textUpdateID;
        private TextBox textUpdatePrice;
        private Button buttonShow;
        private Label label13;
        private TextBox textInsertID;
        private TextBox textInsertCategoria;
        private TextBox textUpdateCategoria;
    }
}