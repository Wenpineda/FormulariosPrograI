namespace Practica_PrograFormularios
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReultado = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbdDivision = new System.Windows.Forms.RadioButton();
            this.rbdResta = new System.Windows.Forms.RadioButton();
            this.rbdSumar = new System.Windows.Forms.RadioButton();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.LightPink;
            this.label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(203, 265);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 23);
            this.label.TabIndex = 16;
            this.label.Text = "Resultado";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.txtReultado);
            this.groupBox2.Location = new System.Drawing.Point(168, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 74);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // txtReultado
            // 
            this.txtReultado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReultado.Location = new System.Drawing.Point(18, 22);
            this.txtReultado.Name = "txtReultado";
            this.txtReultado.Size = new System.Drawing.Size(100, 30);
            this.txtReultado.TabIndex = 24;
            this.txtReultado.Text = "0.0";
            this.txtReultado.TextChanged += new System.EventHandler(this.txtReultado_TextChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btncalcular.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncalcular.Location = new System.Drawing.Point(27, 276);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(115, 45);
            this.btncalcular.TabIndex = 15;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightPink;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(115, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Operaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.rbdMultiplicacion);
            this.groupBox1.Controls.Add(this.rbdDivision);
            this.groupBox1.Controls.Add(this.rbdResta);
            this.groupBox1.Controls.Add(this.rbdSumar);
            this.groupBox1.Location = new System.Drawing.Point(27, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 98);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rbdMultiplicacion
            // 
            this.rbdMultiplicacion.AutoSize = true;
            this.rbdMultiplicacion.BackColor = System.Drawing.Color.PeachPuff;
            this.rbdMultiplicacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbdMultiplicacion.Location = new System.Drawing.Point(156, 22);
            this.rbdMultiplicacion.Name = "rbdMultiplicacion";
            this.rbdMultiplicacion.Size = new System.Drawing.Size(128, 27);
            this.rbdMultiplicacion.TabIndex = 2;
            this.rbdMultiplicacion.TabStop = true;
            this.rbdMultiplicacion.Text = "Multiplicacion";
            this.rbdMultiplicacion.UseVisualStyleBackColor = false;
            // 
            // rbdDivision
            // 
            this.rbdDivision.AutoSize = true;
            this.rbdDivision.BackColor = System.Drawing.Color.PeachPuff;
            this.rbdDivision.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbdDivision.Location = new System.Drawing.Point(156, 55);
            this.rbdDivision.Name = "rbdDivision";
            this.rbdDivision.Size = new System.Drawing.Size(84, 27);
            this.rbdDivision.TabIndex = 4;
            this.rbdDivision.TabStop = true;
            this.rbdDivision.Text = "Division";
            this.rbdDivision.UseVisualStyleBackColor = false;
            // 
            // rbdResta
            // 
            this.rbdResta.AutoSize = true;
            this.rbdResta.BackColor = System.Drawing.Color.PeachPuff;
            this.rbdResta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbdResta.Location = new System.Drawing.Point(27, 55);
            this.rbdResta.Name = "rbdResta";
            this.rbdResta.Size = new System.Drawing.Size(72, 27);
            this.rbdResta.TabIndex = 1;
            this.rbdResta.TabStop = true;
            this.rbdResta.Text = "Resta";
            this.rbdResta.UseVisualStyleBackColor = false;
            // 
            // rbdSumar
            // 
            this.rbdSumar.AutoSize = true;
            this.rbdSumar.BackColor = System.Drawing.Color.PeachPuff;
            this.rbdSumar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbdSumar.Location = new System.Drawing.Point(27, 22);
            this.rbdSumar.Name = "rbdSumar";
            this.rbdSumar.Size = new System.Drawing.Size(68, 27);
            this.rbdSumar.TabIndex = 0;
            this.rbdSumar.TabStop = true;
            this.rbdSumar.Text = "Suma";
            this.rbdSumar.UseVisualStyleBackColor = false;
            // 
            // numero2
            // 
            this.numero2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero2.Location = new System.Drawing.Point(186, 69);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(100, 30);
            this.numero2.TabIndex = 11;
            this.numero2.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Segundo Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Primer Valor";
            // 
            // numero1
            // 
            this.numero1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numero1.Location = new System.Drawing.Point(186, 26);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(100, 30);
            this.numero1.TabIndex = 8;
            this.numero1.Text = "0.0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(217, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(27, 327);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 43);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 440);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero1);
            this.Name = "Form4";
            this.Text = "Calculadora";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label;
        private GroupBox groupBox2;
        private Label lblResultado;
        private Button btncalcular;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbdMultiplicacion;
        private RadioButton rbdDivision;
        private RadioButton rbdResta;
        private RadioButton rbdSumar;
        private TextBox numero2;
        private Label label2;
        private Label label1;
        private TextBox numero1;
        private Button button1;
        private Button btnLimpiar;
        private TextBox txtReultado;
    }
}