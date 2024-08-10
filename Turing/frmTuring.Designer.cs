namespace Turing
{
    partial class frmTuring
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
            this.txtTape = new System.Windows.Forms.TextBox();
            this.txtSourceCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPuntero = new System.Windows.Forms.Label();
            this.lblLapso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTape
            // 
            this.txtTape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTape.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTape.Location = new System.Drawing.Point(12, 12);
            this.txtTape.Name = "txtTape";
            this.txtTape.Size = new System.Drawing.Size(678, 25);
            this.txtTape.TabIndex = 0;
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceCode.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceCode.Location = new System.Drawing.Point(12, 38);
            this.txtSourceCode.Multiline = true;
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSourceCode.Size = new System.Drawing.Size(678, 569);
            this.txtSourceCode.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblPuntero);
            this.panel1.Controls.Add(this.lblLapso);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(696, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 595);
            this.panel1.TabIndex = 2;
            // 
            // lblPuntero
            // 
            this.lblPuntero.AutoSize = true;
            this.lblPuntero.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntero.Location = new System.Drawing.Point(11, 50);
            this.lblPuntero.Name = "lblPuntero";
            this.lblPuntero.Size = new System.Drawing.Size(52, 16);
            this.lblPuntero.TabIndex = 3;
            this.lblPuntero.Text = "Pointer:";
            // 
            // lblLapso
            // 
            this.lblLapso.AutoSize = true;
            this.lblLapso.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapso.Location = new System.Drawing.Point(11, 30);
            this.lblLapso.Name = "lblLapso";
            this.lblLapso.Size = new System.Drawing.Size(45, 16);
            this.lblLapso.TabIndex = 2;
            this.lblLapso.Text = "Lapse:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(11, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 16);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "State:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(147, 93);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSourceCode);
            this.Controls.Add(this.txtTape);
            this.Name = "Form1";
            this.Text = "Turing Machin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTape;
        private System.Windows.Forms.TextBox txtSourceCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPuntero;
        private System.Windows.Forms.Label lblLapso;
        private System.Windows.Forms.Label lblEstado;
    }
}

