namespace Fase4MariaJCabrera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btningresar = new Button();
            txtcontraseña = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(334, 118);
            label2.Name = "label2";
            label2.Size = new Size(135, 17);
            label2.TabIndex = 1;
            label2.Text = "Escriba la contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(196, 43);
            label3.Name = "label3";
            label3.Size = new Size(414, 32);
            label3.TabIndex = 2;
            label3.Text = "Arbol Binario de busqueda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 184);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Contraseña";
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.Purple;
            btningresar.ForeColor = Color.White;
            btningresar.Location = new Point(342, 258);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(114, 36);
            btningresar.TabIndex = 4;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += button1_Click;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(356, 176);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '-';
            txtcontraseña.Size = new Size(100, 23);
            txtcontraseña.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(246, 331);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtcontraseña);
            Controls.Add(btningresar);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Formulario de acceso a la interfaz grafica del arbol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label1;
        private Button btningresar;
        private TextBox txtcontraseña;
        private DateTimePicker dateTimePicker1;
    }
}
