namespace Proyecto_Excepciones
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            listBox2 = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(15, 277);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(64, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 92);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 9;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 159);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "Correo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(390, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 384);
            listBox1.TabIndex = 14;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Busqueda:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 27);
            textBox4.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(6, 87);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(452, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(310, 384);
            listBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button button2;
        private TextBox textBox4;
        private Label label4;
        private ListBox listBox2;
    }
}
