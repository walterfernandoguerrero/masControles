namespace masControles
{
    partial class frmJuego
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
            this.btn_intentar = new System.Windows.Forms.Button();
            this.txtNroInicial = new System.Windows.Forms.TextBox();
            this.lblnroInicial = new System.Windows.Forms.Label();
            this.txt_intento = new System.Windows.Forms.TextBox();
            this.lbl_intento = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxEstado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_intentar
            // 
            this.btn_intentar.Location = new System.Drawing.Point(54, 318);
            this.btn_intentar.Name = "btn_intentar";
            this.btn_intentar.Size = new System.Drawing.Size(177, 60);
            this.btn_intentar.TabIndex = 0;
            this.btn_intentar.Text = "Intentar";
            this.btn_intentar.UseVisualStyleBackColor = true;
            this.btn_intentar.Click += new System.EventHandler(this.btn_intentar_Click);
            // 
            // txtNroInicial
            // 
            this.txtNroInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroInicial.Location = new System.Drawing.Point(54, 67);
            this.txtNroInicial.Multiline = true;
            this.txtNroInicial.Name = "txtNroInicial";
            this.txtNroInicial.PasswordChar = '*';
            this.txtNroInicial.ReadOnly = true;
            this.txtNroInicial.Size = new System.Drawing.Size(82, 62);
            this.txtNroInicial.TabIndex = 1;
            this.txtNroInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnroInicial
            // 
            this.lblnroInicial.AutoSize = true;
            this.lblnroInicial.Location = new System.Drawing.Point(50, 34);
            this.lblnroInicial.Name = "lblnroInicial";
            this.lblnroInicial.Size = new System.Drawing.Size(129, 20);
            this.lblnroInicial.TabIndex = 2;
            this.lblnroInicial.Text = "Numero Secreto:";
            // 
            // txt_intento
            // 
            this.txt_intento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_intento.Location = new System.Drawing.Point(54, 221);
            this.txt_intento.MaxLength = 2;
            this.txt_intento.Multiline = true;
            this.txt_intento.Name = "txt_intento";
            this.txt_intento.Size = new System.Drawing.Size(82, 58);
            this.txt_intento.TabIndex = 3;
            this.txt_intento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_intento
            // 
            this.lbl_intento.AutoSize = true;
            this.lbl_intento.Location = new System.Drawing.Point(50, 188);
            this.lbl_intento.Name = "lbl_intento";
            this.lbl_intento.Size = new System.Drawing.Size(205, 20);
            this.lbl_intento.TabIndex = 4;
            this.lbl_intento.Text = "Ingrese un Nro entre 1 y 12:";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(50, 413);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(107, 20);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "RESPUESTA";
            this.lblRespuesta.Click += new System.EventHandler(this.lblRespuesta_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(606, 67);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(147, 54);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Volver a jugar";
            // 
            // pbxEstado
            // 
            this.pbxEstado.Location = new System.Drawing.Point(466, 176);
            this.pbxEstado.Name = "pbxEstado";
            this.pbxEstado.Size = new System.Drawing.Size(241, 216);
            this.pbxEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEstado.TabIndex = 8;
            this.pbxEstado.TabStop = false;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 493);
            this.Controls.Add(this.pbxEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lbl_intento);
            this.Controls.Add(this.txt_intento);
            this.Controls.Add(this.lblnroInicial);
            this.Controls.Add(this.txtNroInicial);
            this.Controls.Add(this.btn_intentar);
            this.Name = "frmJuego";
            this.Text = "frmJuego";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_intentar;
        private System.Windows.Forms.TextBox txtNroInicial;
        private System.Windows.Forms.Label lblnroInicial;
        private System.Windows.Forms.TextBox txt_intento;
        private System.Windows.Forms.Label lbl_intento;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxEstado;
    }
}