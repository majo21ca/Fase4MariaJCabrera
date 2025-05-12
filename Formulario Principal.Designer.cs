namespace Fase4MariaJCabrera
{
    partial class Formulario_Principal
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
            label1 = new Label();
            btnagregar = new Button();
            btnbuscar = new Button();
            txtregistro = new TextBox();
            label2 = new Label();
            picarbol = new Panel();
            panePre = new Panel();
            panelPos = new Panel();
            panelIn = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(8, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor entero";
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Purple;
            btnagregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregar.Location = new Point(145, 12);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(131, 23);
            btnagregar.TabIndex = 1;
            btnagregar.Text = "Agrergar Nodo";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Purple;
            btnbuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuscar.Location = new Point(293, 12);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(125, 23);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar Nodo";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtregistro
            // 
            txtregistro.Location = new Point(12, 21);
            txtregistro.Name = "txtregistro";
            txtregistro.Size = new Size(99, 23);
            txtregistro.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 47);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 8;
            label2.Text = "Árbol";
            // 
            // picarbol
            // 
            picarbol.BackColor = Color.FromArgb(255, 192, 255);
            picarbol.Location = new Point(26, 65);
            picarbol.Name = "picarbol";
            picarbol.Size = new Size(919, 292);
            picarbol.TabIndex = 9;
            picarbol.Paint += picarbol_Paint;
            // 
            // panePre
            // 
            panePre.Location = new Point(26, 384);
            panePre.Name = "panePre";
            panePre.Size = new Size(919, 23);
            panePre.TabIndex = 10;
            panePre.Paint += panePre_Paint;
            // 
            // panelPos
            // 
            panelPos.Location = new Point(26, 511);
            panelPos.Name = "panelPos";
            panelPos.Size = new Size(919, 23);
            panelPos.TabIndex = 11;
            panelPos.Paint += panelPos_Paint;
            // 
            // panelIn
            // 
            panelIn.Location = new Point(26, 452);
            panelIn.Name = "panelIn";
            panelIn.Size = new Size(919, 23);
            panelIn.TabIndex = 11;
            panelIn.Paint += panelIn_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 366);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "Preorden";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 423);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 13;
            label4.Text = "Inorden";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 493);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 14;
            label5.Text = "Posorden";
            // 
            // Formulario_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 546);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panelIn);
            Controls.Add(panelPos);
            Controls.Add(panePre);
            Controls.Add(picarbol);
            Controls.Add(label2);
            Controls.Add(txtregistro);
            Controls.Add(btnbuscar);
            Controls.Add(btnagregar);
            Controls.Add(label1);
            Name = "Formulario_Principal";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnagregar;
        private Button btnbuscar;
        private TextBox txtregistro;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label2;
        private Panel picarbol;
        private Panel panePre;
        private Panel panelPos;
        private Panel panelIn;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}