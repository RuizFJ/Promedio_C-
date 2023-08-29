namespace PjPromedio
{
    partial class FrmPromedio
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
            txtEstudiante = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            txtNota1 = new TextBox();
            txtPromedio = new TextBox();
            txtMinimo = new TextBox();
            txtCondicion = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(73, 138);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(177, 23);
            txtEstudiante.TabIndex = 0;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(360, 138);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(39, 23);
            txtNota2.TabIndex = 1;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(421, 136);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(39, 23);
            txtNota3.TabIndex = 2;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(478, 136);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(39, 23);
            txtNota4.TabIndex = 3;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(297, 138);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(39, 23);
            txtNota1.TabIndex = 4;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(109, 271);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(72, 23);
            txtPromedio.TabIndex = 5;
            // 
            // txtMinimo
            // 
            txtMinimo.Location = new Point(109, 315);
            txtMinimo.Name = "txtMinimo";
            txtMinimo.Size = new Size(72, 23);
            txtMinimo.TabIndex = 6;
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(109, 361);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(72, 23);
            txtCondicion.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(73, 189);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(175, 189);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(354, 314);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(147, 16);
            label1.Name = "label1";
            label1.Size = new Size(313, 30);
            label1.TabIndex = 11;
            label1.Text = "Control de Promedio de Notas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 106);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 12;
            label2.Text = "Estudiante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(291, 109);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 13;
            label3.Text = "Nota1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(354, 106);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 14;
            label4.Text = "Nota2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(421, 106);
            label5.Name = "label5";
            label5.Size = new Size(45, 17);
            label5.TabIndex = 15;
            label5.Text = "Nota3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(478, 106);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 16;
            label6.Text = "Nota4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 272);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 17;
            label7.Text = "Promedio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 321);
            label8.Name = "label8";
            label8.Size = new Size(97, 17);
            label8.TabIndex = 18;
            label8.Text = "Nota más baja";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(22, 362);
            label9.Name = "label9";
            label9.Size = new Size(70, 17);
            label9.TabIndex = 19;
            label9.Text = "Condicion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(351, 75);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 20;
            label10.Text = "Registro de Notas";
            // 
            // FrmPromedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtCondicion);
            Controls.Add(txtMinimo);
            Controls.Add(txtPromedio);
            Controls.Add(txtNota1);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtEstudiante);
            Name = "FrmPromedio";
            Text = "FrmPromedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEstudiante;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private TextBox txtNota1;
        private TextBox txtPromedio;
        private TextBox txtMinimo;
        private TextBox txtCondicion;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}