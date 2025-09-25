namespace masControles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.rdbFeliz = new System.Windows.Forms.RadioButton();
            this.rdbPensativo = new System.Windows.Forms.RadioButton();
            this.rdbTriste = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboEstadoAnimico = new System.Windows.Forms.ComboBox();
            this.pbxEstado = new System.Windows.Forms.PictureBox();
            this.btn_Ir_juego = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.Location = new System.Drawing.Point(74, 67);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(65, 24);
            this.rdbUser.TabIndex = 0;
            this.rdbUser.TabStop = true;
            this.rdbUser.Text = "user";
            this.rdbUser.UseVisualStyleBackColor = true;
            this.rdbUser.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbFeliz
            // 
            this.rdbFeliz.AutoSize = true;
            this.rdbFeliz.Location = new System.Drawing.Point(74, 108);
            this.rdbFeliz.Name = "rdbFeliz";
            this.rdbFeliz.Size = new System.Drawing.Size(62, 24);
            this.rdbFeliz.TabIndex = 1;
            this.rdbFeliz.TabStop = true;
            this.rdbFeliz.Text = "feliz";
            this.rdbFeliz.UseVisualStyleBackColor = true;
            this.rdbFeliz.CheckedChanged += new System.EventHandler(this.rdbFeliz_CheckedChanged);
            // 
            // rdbPensativo
            // 
            this.rdbPensativo.AutoSize = true;
            this.rdbPensativo.Location = new System.Drawing.Point(74, 152);
            this.rdbPensativo.Name = "rdbPensativo";
            this.rdbPensativo.Size = new System.Drawing.Size(102, 24);
            this.rdbPensativo.TabIndex = 2;
            this.rdbPensativo.TabStop = true;
            this.rdbPensativo.Text = "pensativo";
            this.rdbPensativo.UseVisualStyleBackColor = true;
            this.rdbPensativo.CheckedChanged += new System.EventHandler(this.rdbPensativo_CheckedChanged);
            // 
            // rdbTriste
            // 
            this.rdbTriste.AutoSize = true;
            this.rdbTriste.Location = new System.Drawing.Point(74, 201);
            this.rdbTriste.Name = "rdbTriste";
            this.rdbTriste.Size = new System.Drawing.Size(69, 24);
            this.rdbTriste.TabIndex = 3;
            this.rdbTriste.TabStop = true;
            this.rdbTriste.Text = "triste";
            this.rdbTriste.UseVisualStyleBackColor = true;
            this.rdbTriste.CheckedChanged += new System.EventHandler(this.rdbTriste_CheckedChanged);
            // 
            // cboEstadoAnimico
            // 
            this.cboEstadoAnimico.FormattingEnabled = true;
            this.cboEstadoAnimico.Items.AddRange(new object[] {
            "user",
            "feliz",
            "pensativo",
            "triste"});
            this.cboEstadoAnimico.Location = new System.Drawing.Point(724, 67);
            this.cboEstadoAnimico.Name = "cboEstadoAnimico";
            this.cboEstadoAnimico.Size = new System.Drawing.Size(347, 28);
            this.cboEstadoAnimico.TabIndex = 4;
            this.cboEstadoAnimico.SelectedIndexChanged += new System.EventHandler(this.cboEstadoAnimico_SelectedIndexChanged);
            // 
            // pbxEstado
            // 
            this.pbxEstado.Location = new System.Drawing.Point(305, 67);
            this.pbxEstado.Name = "pbxEstado";
            this.pbxEstado.Size = new System.Drawing.Size(384, 338);
            this.pbxEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEstado.TabIndex = 5;
            this.pbxEstado.TabStop = false;
            // 
            // btn_Ir_juego
            // 
            this.btn_Ir_juego.Location = new System.Drawing.Point(824, 406);
            this.btn_Ir_juego.Name = "btn_Ir_juego";
            this.btn_Ir_juego.Size = new System.Drawing.Size(146, 57);
            this.btn_Ir_juego.TabIndex = 6;
            this.btn_Ir_juego.Text = "ir a juego";
            this.btn_Ir_juego.UseVisualStyleBackColor = true;
            this.btn_Ir_juego.Click += new System.EventHandler(this.btn_Ir_juego_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 645);
            this.Controls.Add(this.btn_Ir_juego);
            this.Controls.Add(this.pbxEstado);
            this.Controls.Add(this.cboEstadoAnimico);
            this.Controls.Add(this.rdbTriste);
            this.Controls.Add(this.rdbPensativo);
            this.Controls.Add(this.rdbFeliz);
            this.Controls.Add(this.rdbUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.RadioButton rdbFeliz;
        private System.Windows.Forms.RadioButton rdbPensativo;
        private System.Windows.Forms.RadioButton rdbTriste;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboEstadoAnimico;
        private System.Windows.Forms.PictureBox pbxEstado;
        private System.Windows.Forms.Button btn_Ir_juego;
    }
}

