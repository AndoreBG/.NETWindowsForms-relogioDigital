namespace relogioDigital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.relDig = new System.Windows.Forms.Label();
            this.btnSelec = new System.Windows.Forms.Button();
            this.btnVoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // relDig
            // 
            this.relDig.BackColor = System.Drawing.Color.Silver;
            this.relDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relDig.Location = new System.Drawing.Point(23, 26);
            this.relDig.Name = "relDig";
            this.relDig.Size = new System.Drawing.Size(449, 130);
            this.relDig.TabIndex = 0;
            this.relDig.Text = "00:00:00";
            this.relDig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelec
            // 
            this.btnSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelec.Location = new System.Drawing.Point(178, 174);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(134, 54);
            this.btnSelec.TabIndex = 1;
            this.btnSelec.UseVisualStyleBackColor = true;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // btnVoice
            // 
            this.btnVoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoice.Location = new System.Drawing.Point(317, 317);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(102, 42);
            this.btnVoice.TabIndex = 2;
            this.btnVoice.Text = "Click to listen to the Engineer";
            this.btnVoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(497, 386);
            this.Controls.Add(this.btnVoice);
            this.Controls.Add(this.btnSelec);
            this.Controls.Add(this.relDig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label relDig;
        private System.Windows.Forms.Button btnSelec;
        private System.Windows.Forms.Label btnVoice;
    }
}

