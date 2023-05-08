namespace SeparadorDeRegistros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPath = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            textBoxGuias = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxPath
            // 
            textBoxPath.BorderStyle = BorderStyle.FixedSingle;
            textBoxPath.Location = new Point(12, 88);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(617, 27);
            textBoxPath.TabIndex = 0;
            textBoxPath.Click += textBoxPath_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 1;
            label1.Text = "Caminho do Arquivo de Exportação";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxGuias
            // 
            textBoxGuias.BorderStyle = BorderStyle.FixedSingle;
            textBoxGuias.Location = new Point(12, 161);
            textBoxGuias.Multiline = true;
            textBoxGuias.Name = "textBoxGuias";
            textBoxGuias.Size = new Size(617, 217);
            textBoxGuias.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(284, 20);
            label2.TabIndex = 3;
            label2.Text = "Guias que deseja separar (Utilizar virgula)";
            // 
            // button1
            // 
            button1.Location = new Point(12, 395);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 4;
            button1.Text = "Processar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(226, 4);
            label3.Name = "label3";
            label3.Size = new Size(288, 35);
            label3.TabIndex = 5;
            label3.Text = "Separador Registro 330";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBoxGuias);
            Controls.Add(label1);
            Controls.Add(textBoxPath);
            Name = "Form1";
            Text = "Separador Arquivo Exportação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPath;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBoxGuias;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}