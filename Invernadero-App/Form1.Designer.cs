namespace Invernadero_App
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.btnConectarArduino = new System.Windows.Forms.Button();
            this.dgbDatos = new System.Windows.Forms.DataGridView();
            this.TiempoActualizacion = new System.Windows.Forms.Timer(this.components);
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnInitSocket = new System.Windows.Forms.Button();
            this.lblSocketInit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(74, 27);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(123, 20);
            this.txtPuerto.TabIndex = 1;
            // 
            // btnConectarArduino
            // 
            this.btnConectarArduino.Location = new System.Drawing.Point(74, 53);
            this.btnConectarArduino.Name = "btnConectarArduino";
            this.btnConectarArduino.Size = new System.Drawing.Size(123, 23);
            this.btnConectarArduino.TabIndex = 2;
            this.btnConectarArduino.Text = "Conectar arduino";
            this.btnConectarArduino.UseVisualStyleBackColor = true;
            this.btnConectarArduino.Click += new System.EventHandler(this.btnConectarArduino_Click);
            // 
            // dgbDatos
            // 
            this.dgbDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbDatos.Location = new System.Drawing.Point(451, 27);
            this.dgbDatos.Name = "dgbDatos";
            this.dgbDatos.Size = new System.Drawing.Size(340, 411);
            this.dgbDatos.TabIndex = 3;
            // 
            // TiempoActualizacion
            // 
            this.TiempoActualizacion.Interval = 5000;
            this.TiempoActualizacion.Tick += new System.EventHandler(this.TiempoActualizacion_Tick);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.Location = new System.Drawing.Point(74, 82);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(123, 23);
            this.btnDesconectar.TabIndex = 4;
            this.btnDesconectar.Text = "Desconectar arduino";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnInitSocket
            // 
            this.btnInitSocket.Location = new System.Drawing.Point(74, 111);
            this.btnInitSocket.Name = "btnInitSocket";
            this.btnInitSocket.Size = new System.Drawing.Size(123, 23);
            this.btnInitSocket.TabIndex = 5;
            this.btnInitSocket.Text = "Iniciar Socket";
            this.btnInitSocket.UseVisualStyleBackColor = true;
            this.btnInitSocket.Click += new System.EventHandler(this.btnInitSocket_Click);
            // 
            // lblSocketInit
            // 
            this.lblSocketInit.AutoSize = true;
            this.lblSocketInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocketInit.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSocketInit.Location = new System.Drawing.Point(59, 137);
            this.lblSocketInit.Name = "lblSocketInit";
            this.lblSocketInit.Size = new System.Drawing.Size(158, 25);
            this.lblSocketInit.TabIndex = 7;
            this.lblSocketInit.Text = "Socket Iniciado";
            this.lblSocketInit.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.lblSocketInit);
            this.Controls.Add(this.btnInitSocket);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.dgbDatos);
            this.Controls.Add(this.btnConectarArduino);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Arduino Server";
            ((System.ComponentModel.ISupportInitialize)(this.dgbDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Button btnConectarArduino;
        private System.Windows.Forms.DataGridView dgbDatos;
        private System.Windows.Forms.Timer TiempoActualizacion;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnInitSocket;
        private System.Windows.Forms.Label lblSocketInit;
    }
}

