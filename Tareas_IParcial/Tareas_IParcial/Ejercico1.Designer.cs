namespace Tareas_IParcial
{
    partial class Ejercico1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.Par0ImparLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Numero 1";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(147, 52);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Numero1TextBox.TabIndex = 1;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(144, 195);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(107, 43);
            this.EjecutarButton.TabIndex = 4;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // Par0ImparLabel
            // 
            this.Par0ImparLabel.AutoSize = true;
            this.Par0ImparLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Par0ImparLabel.Location = new System.Drawing.Point(121, 104);
            this.Par0ImparLabel.Name = "Par0ImparLabel";
            this.Par0ImparLabel.Size = new System.Drawing.Size(0, 22);
            this.Par0ImparLabel.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercico1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 283);
            this.Controls.Add(this.Par0ImparLabel);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercico1";
            this.Text = "Ejercico1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label Par0ImparLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}