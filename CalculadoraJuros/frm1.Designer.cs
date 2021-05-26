
namespace CalculadoraJuros
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnJUROScompostos = new System.Windows.Forms.Button();
            this.btnDescontosRacionalSimples = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA DE JUROS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnJUROScompostos
            // 
            this.btnJUROScompostos.AutoEllipsis = true;
            this.btnJUROScompostos.AutoSize = true;
            this.btnJUROScompostos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJUROScompostos.BackgroundImage")));
            this.btnJUROScompostos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJUROScompostos.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJUROScompostos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJUROScompostos.Location = new System.Drawing.Point(12, 482);
            this.btnJUROScompostos.Name = "btnJUROScompostos";
            this.btnJUROScompostos.Size = new System.Drawing.Size(192, 155);
            this.btnJUROScompostos.TabIndex = 1;
            this.btnJUROScompostos.Text = "Juros Compostos.";
            this.btnJUROScompostos.UseVisualStyleBackColor = true;
            this.btnJUROScompostos.Click += new System.EventHandler(this.btnJUROSSIMPLES_Click);
            // 
            // btnDescontosRacionalSimples
            // 
            this.btnDescontosRacionalSimples.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDescontosRacionalSimples.BackgroundImage")));
            this.btnDescontosRacionalSimples.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDescontosRacionalSimples.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescontosRacionalSimples.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDescontosRacionalSimples.Location = new System.Drawing.Point(436, 482);
            this.btnDescontosRacionalSimples.Name = "btnDescontosRacionalSimples";
            this.btnDescontosRacionalSimples.Size = new System.Drawing.Size(195, 155);
            this.btnDescontosRacionalSimples.TabIndex = 2;
            this.btnDescontosRacionalSimples.Text = "Descontos Racionais Simples.";
            this.btnDescontosRacionalSimples.UseVisualStyleBackColor = true;
            this.btnDescontosRacionalSimples.Click += new System.EventHandler(this.btnCAPITAL_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(643, 649);
            this.Controls.Add(this.btnDescontosRacionalSimples);
            this.Controls.Add(this.btnJUROScompostos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm1";
            this.Text = "frm1";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJUROScompostos;
        private System.Windows.Forms.Button btnDescontosRacionalSimples;
    }
}

