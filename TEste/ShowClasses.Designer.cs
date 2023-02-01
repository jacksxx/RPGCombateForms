namespace TEste
{
    partial class ShowClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowClasses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btonClérigo = new System.Windows.Forms.Button();
            this.btonMago = new System.Windows.Forms.Button();
            this.btonGuerreiro = new System.Windows.Forms.Button();
            this.btonAssassino = new System.Windows.Forms.Button();
            this.labelClérigo = new System.Windows.Forms.Label();
            this.labelMago = new System.Windows.Forms.Label();
            this.labelGuerreiro = new System.Windows.Forms.Label();
            this.labelAssassino = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btonClérigo);
            this.panel1.Controls.Add(this.btonMago);
            this.panel1.Controls.Add(this.btonGuerreiro);
            this.panel1.Controls.Add(this.btonAssassino);
            this.panel1.Controls.Add(this.labelClérigo);
            this.panel1.Controls.Add(this.labelMago);
            this.panel1.Controls.Add(this.labelGuerreiro);
            this.panel1.Controls.Add(this.labelAssassino);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 558);
            this.panel1.TabIndex = 0;
            // 
            // btonClérigo
            // 
            this.btonClérigo.BackColor = System.Drawing.SystemColors.Info;
            this.btonClérigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonClérigo.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonClérigo.Location = new System.Drawing.Point(395, 527);
            this.btonClérigo.Name = "btonClérigo";
            this.btonClérigo.Size = new System.Drawing.Size(373, 31);
            this.btonClérigo.TabIndex = 8;
            this.btonClérigo.Text = "Clérigo";
            this.btonClérigo.UseVisualStyleBackColor = false;
            this.btonClérigo.Click += new System.EventHandler(this.btonClérigo_Click);
            // 
            // btonMago
            // 
            this.btonMago.BackColor = System.Drawing.SystemColors.Info;
            this.btonMago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonMago.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonMago.Location = new System.Drawing.Point(3, 527);
            this.btonMago.Name = "btonMago";
            this.btonMago.Size = new System.Drawing.Size(373, 31);
            this.btonMago.TabIndex = 7;
            this.btonMago.Text = "Mago";
            this.btonMago.UseVisualStyleBackColor = false;
            this.btonMago.Click += new System.EventHandler(this.btonMago_Click);
            // 
            // btonGuerreiro
            // 
            this.btonGuerreiro.BackColor = System.Drawing.SystemColors.Info;
            this.btonGuerreiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonGuerreiro.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonGuerreiro.Location = new System.Drawing.Point(395, 261);
            this.btonGuerreiro.Name = "btonGuerreiro";
            this.btonGuerreiro.Size = new System.Drawing.Size(373, 31);
            this.btonGuerreiro.TabIndex = 6;
            this.btonGuerreiro.Text = "Guerreiro";
            this.btonGuerreiro.UseVisualStyleBackColor = false;
            this.btonGuerreiro.Click += new System.EventHandler(this.btonGuerreiro_Click);
            // 
            // btonAssassino
            // 
            this.btonAssassino.BackColor = System.Drawing.SystemColors.Info;
            this.btonAssassino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonAssassino.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonAssassino.Location = new System.Drawing.Point(3, 261);
            this.btonAssassino.Name = "btonAssassino";
            this.btonAssassino.Size = new System.Drawing.Size(373, 31);
            this.btonAssassino.TabIndex = 5;
            this.btonAssassino.Text = "Assassino";
            this.btonAssassino.UseVisualStyleBackColor = false;
            this.btonAssassino.Click += new System.EventHandler(this.btonAssassino_Click);
            // 
            // labelClérigo
            // 
            this.labelClérigo.AutoSize = true;
            this.labelClérigo.BackColor = System.Drawing.Color.Transparent;
            this.labelClérigo.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClérigo.Location = new System.Drawing.Point(441, 317);
            this.labelClérigo.Name = "labelClérigo";
            this.labelClérigo.Size = new System.Drawing.Size(282, 180);
            this.labelClérigo.TabIndex = 4;
            this.labelClérigo.Text = "Nome: Clérigo\r\nModificador de Força: 0\r\nModificador de Habilidade: 0\r\nModificador" +
    " de Vida: 0\r\nModificador de Mana: 5\r\nVantagens: Magia Sagrada\r\n";
            // 
            // labelMago
            // 
            this.labelMago.AutoSize = true;
            this.labelMago.BackColor = System.Drawing.Color.Transparent;
            this.labelMago.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMago.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelMago.Location = new System.Drawing.Point(49, 317);
            this.labelMago.Name = "labelMago";
            this.labelMago.Size = new System.Drawing.Size(282, 180);
            this.labelMago.TabIndex = 3;
            this.labelMago.Text = "Nome: Mago\r\nModificador de Força: 0\r\nModificador de Habilidade: 0\r\nModificador de" +
    " Vida: 0\r\nModificador de Mana: 5\r\nVantagens: Magia Arcana";
            // 
            // labelGuerreiro
            // 
            this.labelGuerreiro.AutoSize = true;
            this.labelGuerreiro.BackColor = System.Drawing.Color.Transparent;
            this.labelGuerreiro.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuerreiro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelGuerreiro.Location = new System.Drawing.Point(441, 31);
            this.labelGuerreiro.Name = "labelGuerreiro";
            this.labelGuerreiro.Size = new System.Drawing.Size(282, 180);
            this.labelGuerreiro.TabIndex = 1;
            this.labelGuerreiro.Text = "Nome: Guerreiro\r\nModificador de Força: 1\r\nModificador de Habilidade: 0\r\nModificad" +
    "or de Vida: 5\r\nModificador de Mana: 0\r\nVantagens: Nenhuma ";
            // 
            // labelAssassino
            // 
            this.labelAssassino.AutoSize = true;
            this.labelAssassino.BackColor = System.Drawing.Color.Transparent;
            this.labelAssassino.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssassino.Location = new System.Drawing.Point(12, 31);
            this.labelAssassino.Name = "labelAssassino";
            this.labelAssassino.Size = new System.Drawing.Size(357, 180);
            this.labelAssassino.TabIndex = 0;
            this.labelAssassino.Text = "Nome: Assassino\r\nModificador de Força: 0\r\nModificador de Habilidade: 2\r\nModificad" +
    "or de Vida: 0\r\nModificador de Mana: 0\r\nVantagens: Ataque Base(Habilidade)";
            // 
            // ShowClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowClasses";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPGCombate";
            this.Load += new System.EventHandler(this.ShowClasses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAssassino;
        private System.Windows.Forms.Button btonClérigo;
        private System.Windows.Forms.Button btonMago;
        private System.Windows.Forms.Button btonGuerreiro;
        private System.Windows.Forms.Button btonAssassino;
        private System.Windows.Forms.Label labelClérigo;
        private System.Windows.Forms.Label labelMago;
        private System.Windows.Forms.Label labelGuerreiro;
    }
}