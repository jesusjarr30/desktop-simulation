
namespace Escritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pan_barra = new System.Windows.Forms.Panel();
            this.btn_explorador = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pan_fondo = new System.Windows.Forms.Panel();
            this.pan_barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_barra
            // 
            this.pan_barra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pan_barra.Controls.Add(this.btn_explorador);
            this.pan_barra.Controls.Add(this.button3);
            this.pan_barra.Controls.Add(this.button1);
            this.pan_barra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_barra.Location = new System.Drawing.Point(0, 906);
            this.pan_barra.Name = "pan_barra";
            this.pan_barra.Size = new System.Drawing.Size(1382, 47);
            this.pan_barra.TabIndex = 0;
            // 
            // btn_explorador
            // 
            this.btn_explorador.BackgroundImage = global::Escritorio.Properties.Resources._3;
            this.btn_explorador.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_explorador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_explorador.Location = new System.Drawing.Point(247, 0);
            this.btn_explorador.Name = "btn_explorador";
            this.btn_explorador.Size = new System.Drawing.Size(67, 47);
            this.btn_explorador.TabIndex = 3;
            this.btn_explorador.UseVisualStyleBackColor = true;
            this.btn_explorador.Click += new System.EventHandler(this.btn_explorador_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Escritorio.Properties.Resources._2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(178, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 47);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Escritorio.Properties.Resources._1;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 47);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pan_fondo
            // 
            this.pan_fondo.BackgroundImage = global::Escritorio.Properties.Resources.fondo;
            this.pan_fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_fondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_fondo.Location = new System.Drawing.Point(0, 0);
            this.pan_fondo.Name = "pan_fondo";
            this.pan_fondo.Size = new System.Drawing.Size(1382, 906);
            this.pan_fondo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 953);
            this.Controls.Add(this.pan_fondo);
            this.Controls.Add(this.pan_barra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windos 10";
            this.pan_barra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_barra;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pan_fondo;
        private System.Windows.Forms.Button btn_explorador;
    }
}

