namespace Presentacion
{
    partial class formVendedorInicio
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
            this.btnIngresarPedido = new System.Windows.Forms.Button();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarPedido
            // 
            this.btnIngresarPedido.Location = new System.Drawing.Point(44, 93);
            this.btnIngresarPedido.Name = "btnIngresarPedido";
            this.btnIngresarPedido.Size = new System.Drawing.Size(172, 51);
            this.btnIngresarPedido.TabIndex = 0;
            this.btnIngresarPedido.Text = "Ingresar pedido";
            this.btnIngresarPedido.UseVisualStyleBackColor = true;
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.Location = new System.Drawing.Point(249, 93);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(160, 51);
            this.btnIngresarCliente.TabIndex = 1;
            this.btnIngresarCliente.Text = "Ingresar cliente";
            this.btnIngresarCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario: Vendedor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(691, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lista de pedidos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // formVendedorInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresarCliente);
            this.Controls.Add(this.btnIngresarPedido);
            this.Name = "formVendedorInicio";
            this.Text = "Inicio Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarPedido;
        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}