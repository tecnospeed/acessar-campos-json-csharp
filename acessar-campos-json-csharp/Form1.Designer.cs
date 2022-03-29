namespace acessar_json_csharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExemplo2 = new System.Windows.Forms.RadioButton();
            this.rbExemplo1 = new System.Windows.Forms.RadioButton();
            this.txtLeitura = new System.Windows.Forms.TextBox();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.btnLerJson = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtLeitura);
            this.panel1.Controls.Add(this.txtJson);
            this.panel1.Controls.Add(this.btnLerJson);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 437);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Leitura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "JSON de Exemplo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbExemplo2);
            this.groupBox1.Controls.Add(this.rbExemplo1);
            this.groupBox1.Location = new System.Drawing.Point(318, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON";
            // 
            // rbExemplo2
            // 
            this.rbExemplo2.AutoSize = true;
            this.rbExemplo2.Location = new System.Drawing.Point(13, 43);
            this.rbExemplo2.Name = "rbExemplo2";
            this.rbExemplo2.Size = new System.Drawing.Size(74, 17);
            this.rbExemplo2.TabIndex = 1;
            this.rbExemplo2.Text = "Exemplo 2";
            this.rbExemplo2.UseVisualStyleBackColor = true;
            this.rbExemplo2.CheckedChanged += new System.EventHandler(this.rbExemplo2_CheckedChanged);
            // 
            // rbExemplo1
            // 
            this.rbExemplo1.AutoSize = true;
            this.rbExemplo1.Checked = true;
            this.rbExemplo1.Location = new System.Drawing.Point(13, 20);
            this.rbExemplo1.Name = "rbExemplo1";
            this.rbExemplo1.Size = new System.Drawing.Size(74, 17);
            this.rbExemplo1.TabIndex = 0;
            this.rbExemplo1.TabStop = true;
            this.rbExemplo1.Text = "Exemplo 1";
            this.rbExemplo1.UseVisualStyleBackColor = true;
            this.rbExemplo1.CheckedChanged += new System.EventHandler(this.rbExemplo1_CheckedChanged);
            // 
            // txtLeitura
            // 
            this.txtLeitura.BackColor = System.Drawing.SystemColors.Window;
            this.txtLeitura.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeitura.Location = new System.Drawing.Point(424, 26);
            this.txtLeitura.Multiline = true;
            this.txtLeitura.Name = "txtLeitura";
            this.txtLeitura.ReadOnly = true;
            this.txtLeitura.Size = new System.Drawing.Size(300, 400);
            this.txtLeitura.TabIndex = 1;
            // 
            // txtJson
            // 
            this.txtJson.BackColor = System.Drawing.SystemColors.Window;
            this.txtJson.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJson.Location = new System.Drawing.Point(12, 26);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.ReadOnly = true;
            this.txtJson.Size = new System.Drawing.Size(300, 400);
            this.txtJson.TabIndex = 2;
            this.txtJson.WordWrap = false;
            // 
            // btnLerJson
            // 
            this.btnLerJson.Location = new System.Drawing.Point(318, 112);
            this.btnLerJson.Name = "btnLerJson";
            this.btnLerJson.Size = new System.Drawing.Size(100, 50);
            this.btnLerJson.TabIndex = 0;
            this.btnLerJson.Text = "Ler JSON";
            this.btnLerJson.UseVisualStyleBackColor = true;
            this.btnLerJson.Click += new System.EventHandler(this.btnLerJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 437);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessar campos JSON";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLeitura;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.Button btnLerJson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbExemplo2;
        private System.Windows.Forms.RadioButton rbExemplo1;
    }
}

