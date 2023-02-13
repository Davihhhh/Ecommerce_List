namespace Ecommerce
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxPrezzo = new System.Windows.Forms.TextBox();
            this.textBoxProduttore = new System.Windows.Forms.TextBox();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonSvuota = new System.Windows.Forms.Button();
            this.textBoxCancella = new System.Windows.Forms.TextBox();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.OldLace;
            this.textBox.Enabled = false;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(58, 84);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(164, 26);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Nome";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(58, 130);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(164, 26);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OldLace;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(464, 84);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Prezzo";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OldLace;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(262, 84);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Produttore";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.OldLace;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(58, 199);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 26);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Descrizione";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrezzo
            // 
            this.textBoxPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrezzo.Location = new System.Drawing.Point(464, 130);
            this.textBoxPrezzo.Name = "textBoxPrezzo";
            this.textBoxPrezzo.Size = new System.Drawing.Size(164, 26);
            this.textBoxPrezzo.TabIndex = 5;
            // 
            // textBoxProduttore
            // 
            this.textBoxProduttore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduttore.Location = new System.Drawing.Point(262, 130);
            this.textBoxProduttore.Name = "textBoxProduttore";
            this.textBoxProduttore.Size = new System.Drawing.Size(164, 26);
            this.textBoxProduttore.TabIndex = 6;
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescrizione.Location = new System.Drawing.Point(58, 246);
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(570, 26);
            this.textBoxDescrizione.TabIndex = 7;
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonAggiungi.Location = new System.Drawing.Point(58, 427);
            this.buttonAggiungi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(101, 30);
            this.buttonAggiungi.TabIndex = 8;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonElimina.Location = new System.Drawing.Point(206, 427);
            this.buttonElimina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(101, 30);
            this.buttonElimina.TabIndex = 9;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // buttonSvuota
            // 
            this.buttonSvuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonSvuota.Location = new System.Drawing.Point(352, 427);
            this.buttonSvuota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSvuota.Name = "buttonSvuota";
            this.buttonSvuota.Size = new System.Drawing.Size(101, 30);
            this.buttonSvuota.TabIndex = 10;
            this.buttonSvuota.Text = "Svuota";
            this.buttonSvuota.UseVisualStyleBackColor = true;
            this.buttonSvuota.Click += new System.EventHandler(this.buttonSvuota_Click);
            // 
            // textBoxCancella
            // 
            this.textBoxCancella.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.textBoxCancella.Location = new System.Drawing.Point(206, 382);
            this.textBoxCancella.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCancella.Name = "textBoxCancella";
            this.textBoxCancella.Size = new System.Drawing.Size(102, 27);
            this.textBoxCancella.TabIndex = 11;
            // 
            // textBoxTip
            // 
            this.textBoxTip.BackColor = System.Drawing.Color.OldLace;
            this.textBoxTip.Enabled = false;
            this.textBoxTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTip.Location = new System.Drawing.Point(670, 84);
            this.textBoxTip.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(164, 26);
            this.textBoxTip.TabIndex = 12;
            this.textBoxTip.Text = "Tipo";
            this.textBoxTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipo.Location = new System.Drawing.Point(670, 130);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(164, 26);
            this.textBoxTipo.TabIndex = 13;
            this.textBoxTipo.TextChanged += new System.EventHandler(this.textBoxTipo_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 492);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.textBoxCancella);
            this.Controls.Add(this.buttonSvuota);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.textBoxDescrizione);
            this.Controls.Add(this.textBoxProduttore);
            this.Controls.Add(this.textBoxPrezzo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBox);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxPrezzo;
        private System.Windows.Forms.TextBox textBoxProduttore;
        private System.Windows.Forms.TextBox textBoxDescrizione;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonSvuota;
        private System.Windows.Forms.TextBox textBoxCancella;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.TextBox textBoxTipo;
    }
}

