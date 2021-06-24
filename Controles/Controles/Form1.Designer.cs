namespace Controles
{
    partial class Form1
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
            this.gpbcontroles = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numvalores = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.btnvisivel = new System.Windows.Forms.Button();
            this.btninvisivel = new System.Windows.Forms.Button();
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.btndesabilitar = new System.Windows.Forms.Button();
            this.gpbcontroles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numvalores)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbcontroles
            // 
            this.gpbcontroles.Controls.Add(this.button2);
            this.gpbcontroles.Controls.Add(this.numvalores);
            this.gpbcontroles.Controls.Add(this.button1);
            this.gpbcontroles.Controls.Add(this.cbestado);
            this.gpbcontroles.Location = new System.Drawing.Point(12, 12);
            this.gpbcontroles.Name = "gpbcontroles";
            this.gpbcontroles.Size = new System.Drawing.Size(318, 194);
            this.gpbcontroles.TabIndex = 0;
            this.gpbcontroles.TabStop = false;
            this.gpbcontroles.Text = "Controles";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numvalores
            // 
            this.numvalores.Location = new System.Drawing.Point(6, 109);
            this.numvalores.Name = "numvalores";
            this.numvalores.Size = new System.Drawing.Size(173, 20);
            this.numvalores.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbestado
            // 
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "PE"});
            this.cbestado.Location = new System.Drawing.Point(6, 49);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(173, 21);
            this.cbestado.TabIndex = 0;
            // 
            // btnvisivel
            // 
            this.btnvisivel.Location = new System.Drawing.Point(12, 243);
            this.btnvisivel.Name = "btnvisivel";
            this.btnvisivel.Size = new System.Drawing.Size(75, 23);
            this.btnvisivel.TabIndex = 1;
            this.btnvisivel.Text = "Visivel";
            this.btnvisivel.UseVisualStyleBackColor = true;
            this.btnvisivel.Click += new System.EventHandler(this.btnvisivel_Click);
            // 
            // btninvisivel
            // 
            this.btninvisivel.Location = new System.Drawing.Point(93, 243);
            this.btninvisivel.Name = "btninvisivel";
            this.btninvisivel.Size = new System.Drawing.Size(75, 23);
            this.btninvisivel.TabIndex = 2;
            this.btninvisivel.Text = "Invisivel";
            this.btninvisivel.UseVisualStyleBackColor = true;
            this.btninvisivel.Click += new System.EventHandler(this.btninvisivel_Click);
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.Location = new System.Drawing.Point(174, 243);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnhabilitar.TabIndex = 3;
            this.btnhabilitar.Text = "Habilitar";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            this.btnhabilitar.Click += new System.EventHandler(this.btnhabilitar_Click);
            // 
            // btndesabilitar
            // 
            this.btndesabilitar.Location = new System.Drawing.Point(255, 243);
            this.btndesabilitar.Name = "btndesabilitar";
            this.btndesabilitar.Size = new System.Drawing.Size(75, 23);
            this.btndesabilitar.TabIndex = 4;
            this.btndesabilitar.Text = "Desabilitar";
            this.btndesabilitar.UseVisualStyleBackColor = true;
            this.btndesabilitar.Click += new System.EventHandler(this.btndesabilitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 292);
            this.Controls.Add(this.btndesabilitar);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.btninvisivel);
            this.Controls.Add(this.btnvisivel);
            this.Controls.Add(this.gpbcontroles);
            this.Name = "Form1";
            this.Text = "Novos Controles e Propriedades";
            this.gpbcontroles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numvalores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbcontroles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numvalores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Button btnvisivel;
        private System.Windows.Forms.Button btninvisivel;
        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.Button btndesabilitar;

    }
}

