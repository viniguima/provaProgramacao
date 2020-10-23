namespace CadastroClientes.FormsClientes
{
    partial class AlterarCliente
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
            this.richTextBoxListar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxListar
            // 
            this.richTextBoxListar.Location = new System.Drawing.Point(121, 274);
            this.richTextBoxListar.Name = "richTextBoxListar";
            this.richTextBoxListar.Size = new System.Drawing.Size(610, 164);
            this.richTextBoxListar.TabIndex = 0;
            this.richTextBoxListar.Text = "";
            this.richTextBoxListar.TextChanged += new System.EventHandler(this.richTextBoxListar_TextChanged);
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 453);
            this.Controls.Add(this.richTextBoxListar);
            this.Name = "AlterarCliente";
            this.Text = "AlterarCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxListar;
    }
}