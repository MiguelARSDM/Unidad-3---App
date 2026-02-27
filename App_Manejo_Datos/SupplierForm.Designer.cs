namespace App_Manejo_Datos
{
    partial class SupplierForm
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
            textInsertMail = new TextBox();
            textInsertPhone = new TextBox();
            textInsertName = new TextBox();
            buttonInsert = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textDeleteID = new TextBox();
            buttonDelete = new Button();
            label4 = new Label();
            groupBox3 = new GroupBox();
            textUpdateName = new TextBox();
            textUpdatePhone = new TextBox();
            textUpdateMail = new TextBox();
            textUpdateID = new TextBox();
            buttonUpdate = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
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
            groupBox1.Controls.Add(textInsertMail);
            groupBox1.Controls.Add(textInsertPhone);
            groupBox1.Controls.Add(textInsertName);
            groupBox1.Controls.Add(buttonInsert);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            // 
            // textInsertMail
            // 
            textInsertMail.Location = new Point(6, 97);
            textInsertMail.Name = "textInsertMail";
            textInsertMail.Size = new Size(348, 27);
            textInsertMail.TabIndex = 14;
            // 
            // textInsertPhone
            // 
            textInsertPhone.Location = new Point(193, 44);
            textInsertPhone.Name = "textInsertPhone";
            textInsertPhone.Size = new Size(161, 27);
            textInsertPhone.TabIndex = 13;
            // 
            // textInsertName
            // 
            textInsertName.Location = new Point(6, 44);
            textInsertName.Name = "textInsertName";
            textInsertName.Size = new Size(181, 27);
            textInsertName.TabIndex = 12;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(3, 133);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(351, 47);
            buttonInsert.TabIndex = 8;
            buttonInsert.Text = "Agregar";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 23);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Proveedor";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textDeleteID);
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(366, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 186);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar";
            // 
            // textDeleteID
            // 
            textDeleteID.Location = new Point(6, 44);
            textDeleteID.Name = "textDeleteID";
            textDeleteID.Size = new Size(185, 27);
            textDeleteID.TabIndex = 15;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(6, 77);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(185, 47);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 3;
            label4.Text = "ID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textUpdateName);
            groupBox3.Controls.Add(textUpdatePhone);
            groupBox3.Controls.Add(textUpdateMail);
            groupBox3.Controls.Add(textUpdateID);
            groupBox3.Controls.Add(buttonUpdate);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(569, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(370, 186);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textUpdateName
            // 
            textUpdateName.Location = new Point(6, 97);
            textUpdateName.Name = "textUpdateName";
            textUpdateName.Size = new Size(161, 27);
            textUpdateName.TabIndex = 19;
            // 
            // textUpdatePhone
            // 
            textUpdatePhone.Location = new Point(173, 44);
            textUpdatePhone.Name = "textUpdatePhone";
            textUpdatePhone.Size = new Size(191, 27);
            textUpdatePhone.TabIndex = 18;
            // 
            // textUpdateMail
            // 
            textUpdateMail.Location = new Point(173, 97);
            textUpdateMail.Name = "textUpdateMail";
            textUpdateMail.Size = new Size(191, 27);
            textUpdateMail.TabIndex = 17;
            // 
            // textUpdateID
            // 
            textUpdateID.Location = new Point(6, 44);
            textUpdateID.Name = "textUpdateID";
            textUpdateID.Size = new Size(161, 27);
            textUpdateID.TabIndex = 16;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(0, 133);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(370, 47);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Actualizar";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(173, 77);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 7;
            label8.Text = "Correo Electronico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 21);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 6;
            label7.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 74);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 5;
            label6.Text = "Nombre del Proveedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 21);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 4;
            label5.Text = "ID";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(screen);
            groupBox4.Controls.Add(buttonShow);
            groupBox4.Location = new Point(0, 192);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(939, 299);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar";
            // 
            // screen
            // 
            screen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            screen.Location = new Point(6, 58);
            screen.Name = "screen";
            screen.RowHeadersWidth = 51;
            screen.Size = new Size(930, 241);
            screen.TabIndex = 11;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(366, 15);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(197, 37);
            buttonShow.TabIndex = 10;
            buttonShow.Text = "Cargar";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += button4_Click;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 493);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SupplierForm";
            Text = "Proveedor";
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
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox textInsertMail;
        private TextBox textInsertPhone;
        private TextBox textInsertName;
        private Button buttonInsert;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textDeleteID;
        private Button buttonDelete;
        private Label label4;
        private TextBox textUpdateName;
        private TextBox textUpdatePhone;
        private TextBox textUpdateMail;
        private TextBox textUpdateID;
        private Button buttonUpdate;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button buttonShow;
        private DataGridView screen;
    }
}