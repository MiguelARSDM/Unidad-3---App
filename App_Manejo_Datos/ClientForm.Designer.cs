namespace App_Manejo_Datos
{
    partial class ClientForm
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
            buttonInsert = new Button();
            textInsertPhone = new TextBox();
            textInsertAddress = new TextBox();
            textInsertMail = new TextBox();
            textInsertName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonDelete = new Button();
            textDeleteID = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            textUpdateName = new TextBox();
            textUpdatePhone = new TextBox();
            textBox8 = new TextBox();
            textUpdateID = new TextBox();
            buttonUpdate = new Button();
            textUpdateAddress = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            screen = new DataGridView();
            buttonShow = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)screen).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonInsert);
            groupBox1.Controls.Add(textInsertPhone);
            groupBox1.Controls.Add(textInsertAddress);
            groupBox1.Controls.Add(textInsertMail);
            groupBox1.Controls.Add(textInsertName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(9, 188);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(373, 56);
            buttonInsert.TabIndex = 8;
            buttonInsert.Text = "Agregar";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += button1_Click;
            // 
            // textInsertPhone
            // 
            textInsertPhone.Location = new Point(194, 49);
            textInsertPhone.Name = "textInsertPhone";
            textInsertPhone.Size = new Size(188, 27);
            textInsertPhone.TabIndex = 7;
            // 
            // textInsertAddress
            // 
            textInsertAddress.Location = new Point(9, 155);
            textInsertAddress.Name = "textInsertAddress";
            textInsertAddress.Size = new Size(376, 27);
            textInsertAddress.TabIndex = 6;
            // 
            // textInsertMail
            // 
            textInsertMail.Location = new Point(6, 102);
            textInsertMail.Name = "textInsertMail";
            textInsertMail.Size = new Size(376, 27);
            textInsertMail.TabIndex = 5;
            // 
            // textInsertName
            // 
            textInsertName.Location = new Point(6, 49);
            textInsertName.Name = "textInsertName";
            textInsertName.Size = new Size(182, 27);
            textInsertName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 79);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "Correo Electronico";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 26);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(textDeleteID);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(411, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 253);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(6, 102);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(203, 56);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textDeleteID
            // 
            textDeleteID.Location = new Point(6, 67);
            textDeleteID.Name = "textDeleteID";
            textDeleteID.Size = new Size(203, 27);
            textDeleteID.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 37);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 9;
            label5.Text = "ID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textUpdateName);
            groupBox3.Controls.Add(textUpdatePhone);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(textUpdateID);
            groupBox3.Controls.Add(buttonUpdate);
            groupBox3.Controls.Add(textUpdateAddress);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(632, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(412, 253);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // textUpdateName
            // 
            textUpdateName.Location = new Point(6, 102);
            textUpdateName.Name = "textUpdateName";
            textUpdateName.Size = new Size(186, 27);
            textUpdateName.TabIndex = 10;
            // 
            // textUpdatePhone
            // 
            textUpdatePhone.Location = new Point(214, 49);
            textUpdatePhone.Name = "textUpdatePhone";
            textUpdatePhone.Size = new Size(186, 27);
            textUpdatePhone.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(6, 155);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(394, 27);
            textBox8.TabIndex = 8;
            // 
            // textUpdateID
            // 
            textUpdateID.Location = new Point(6, 49);
            textUpdateID.Name = "textUpdateID";
            textUpdateID.Size = new Size(186, 27);
            textUpdateID.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(6, 188);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(394, 56);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Actualizar";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // textUpdateAddress
            // 
            textUpdateAddress.Location = new Point(214, 102);
            textUpdateAddress.Name = "textUpdateAddress";
            textUpdateAddress.Size = new Size(186, 27);
            textUpdateAddress.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(214, 23);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 4;
            label10.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(214, 79);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 3;
            label9.Text = "Correo Electronico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 132);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 2;
            label8.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 79);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 1;
            label7.Text = "Nombre Completo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 0;
            label6.Text = "ID";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(screen);
            groupBox4.Controls.Add(buttonShow);
            groupBox4.Location = new Point(3, 271);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1041, 252);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar";
            // 
            // screen
            // 
            screen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            screen.Location = new Point(12, 64);
            screen.Name = "screen";
            screen.RowHeadersWidth = 51;
            screen.Size = new Size(1023, 188);
            screen.TabIndex = 1;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(408, 26);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(215, 29);
            buttonShow.TabIndex = 0;
            buttonShow.Text = "Cargar";
            buttonShow.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 535);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ClientForm";
            Text = "Cliente";
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
        private TextBox textInsertPhone;
        private TextBox textInsertAddress;
        private TextBox textInsertMail;
        private TextBox textInsertName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonInsert;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button buttonDelete;
        private TextBox textDeleteID;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textUpdateName;
        private TextBox textUpdatePhone;
        private TextBox textBox8;
        private TextBox textUpdateID;
        private Button buttonUpdate;
        private TextBox textUpdateAddress;
        private DataGridView screen;
        private Button buttonShow;
    }
}