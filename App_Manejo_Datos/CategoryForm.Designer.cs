namespace App_Manejo_Datos
{
    partial class CategoryForm
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
            textInsertName = new TextBox();
            label1 = new Label();
            buttonInsert = new Button();
            groupBox2 = new GroupBox();
            textDeleteID = new TextBox();
            label2 = new Label();
            buttonDelete = new Button();
            groupBox3 = new GroupBox();
            textUpdateID = new TextBox();
            textUpdateName = new TextBox();
            buttonUpdate = new Button();
            label4 = new Label();
            label3 = new Label();
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
            groupBox1.Controls.Add(textInsertName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonInsert);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            // 
            // textInsertName
            // 
            textInsertName.Location = new Point(6, 45);
            textInsertName.Name = "textInsertName";
            textInsertName.Size = new Size(313, 27);
            textInsertName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la Categoria";
            label1.Click += label1_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(6, 81);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(313, 56);
            buttonInsert.TabIndex = 4;
            buttonInsert.Text = "Agregar";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textDeleteID);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Location = new Point(331, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 200);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar";
            // 
            // textDeleteID
            // 
            textDeleteID.Location = new Point(6, 45);
            textDeleteID.Name = "textDeleteID";
            textDeleteID.Size = new Size(187, 27);
            textDeleteID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(6, 81);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(187, 56);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textUpdateID);
            groupBox3.Controls.Add(textUpdateName);
            groupBox3.Controls.Add(buttonUpdate);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(544, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(277, 200);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // textUpdateID
            // 
            textUpdateID.Location = new Point(6, 45);
            textUpdateID.Name = "textUpdateID";
            textUpdateID.Size = new Size(262, 27);
            textUpdateID.TabIndex = 7;
            // 
            // textUpdateName
            // 
            textUpdateName.Location = new Point(6, 96);
            textUpdateName.Name = "textUpdateName";
            textUpdateName.Size = new Size(262, 27);
            textUpdateName.TabIndex = 8;
            textUpdateName.TextChanged += textBox4_TextChanged;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(6, 138);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(262, 56);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Actualizar";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 75);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre de la Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonShow);
            groupBox4.Controls.Add(screen);
            groupBox4.Location = new Point(6, 206);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(815, 232);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(331, 14);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(201, 29);
            buttonShow.TabIndex = 7;
            buttonShow.Text = "Cargar";
            buttonShow.UseVisualStyleBackColor = true;
            // 
            // screen
            // 
            screen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            screen.Location = new Point(6, 49);
            screen.Name = "screen";
            screen.RowHeadersWidth = 51;
            screen.Size = new Size(800, 177);
            screen.TabIndex = 10;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CategoryForm";
            Text = "Categoria";
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
        private TextBox textInsertName;
        private Label label1;
        private Button buttonInsert;
        private GroupBox groupBox2;
        private Label label2;
        private Button buttonDelete;
        private GroupBox groupBox3;
        private TextBox textUpdateID;
        private TextBox textUpdateName;
        private Button buttonUpdate;
        private Label label4;
        private Label label3;
        private GroupBox groupBox4;
        private Button buttonShow;
        private TextBox textDeleteID;
        private DataGridView screen;
    }
}