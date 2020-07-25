namespace OOP
{
    partial class FMain
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
            this.rbRegister = new System.Windows.Forms.RadioButton();
            this.rbTransistor = new System.Windows.Forms.RadioButton();
            this.rbCapacitor = new System.Windows.Forms.RadioButton();
            this.rbDiode = new System.Windows.Forms.RadioButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.Schema = new OOP.Scheme(this.components);
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbRegister
            // 
            this.rbRegister.AutoSize = true;
            this.rbRegister.BackColor = System.Drawing.Color.Transparent;
            this.rbRegister.Checked = true;
            this.rbRegister.Location = new System.Drawing.Point(3, 3);
            this.rbRegister.Name = "rbRegister";
            this.rbRegister.Size = new System.Drawing.Size(66, 17);
            this.rbRegister.TabIndex = 0;
            this.rbRegister.TabStop = true;
            this.rbRegister.Text = "Регистр";
            this.rbRegister.UseVisualStyleBackColor = false;
            // 
            // rbTransistor
            // 
            this.rbTransistor.AutoSize = true;
            this.rbTransistor.BackColor = System.Drawing.Color.Transparent;
            this.rbTransistor.Location = new System.Drawing.Point(3, 26);
            this.rbTransistor.Name = "rbTransistor";
            this.rbTransistor.Size = new System.Drawing.Size(85, 17);
            this.rbTransistor.TabIndex = 1;
            this.rbTransistor.Text = "Транзистор";
            this.rbTransistor.UseVisualStyleBackColor = false;
            // 
            // rbCapacitor
            // 
            this.rbCapacitor.AutoSize = true;
            this.rbCapacitor.Location = new System.Drawing.Point(3, 49);
            this.rbCapacitor.Name = "rbCapacitor";
            this.rbCapacitor.Size = new System.Drawing.Size(91, 17);
            this.rbCapacitor.TabIndex = 2;
            this.rbCapacitor.TabStop = true;
            this.rbCapacitor.Text = "Конденсатор";
            this.rbCapacitor.UseVisualStyleBackColor = true;
            // 
            // rbDiode
            // 
            this.rbDiode.AutoSize = true;
            this.rbDiode.Location = new System.Drawing.Point(3, 72);
            this.rbDiode.Name = "rbDiode";
            this.rbDiode.Size = new System.Drawing.Size(52, 17);
            this.rbDiode.TabIndex = 3;
            this.rbDiode.TabStop = true;
            this.rbDiode.Text = "Диод";
            this.rbDiode.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Panel.Controls.Add(this.rbRegister);
            this.Panel.Controls.Add(this.rbDiode);
            this.Panel.Controls.Add(this.rbTransistor);
            this.Panel.Controls.Add(this.rbCapacitor);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel.Location = new System.Drawing.Point(503, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(163, 399);
            this.Panel.TabIndex = 4;
            // 
            // Schema
            // 
            this.Schema.BackColor = System.Drawing.Color.Gray;
            this.Schema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schema.Location = new System.Drawing.Point(0, 0);
            this.Schema.Name = "Schema";
            this.Schema.Size = new System.Drawing.Size(503, 399);
            this.Schema.TabIndex = 5;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 399);
            this.Controls.Add(this.Schema);
            this.Controls.Add(this.Panel);
            this.DoubleBuffered = true;
            this.Name = "FMain";
            this.ShowIcon = false;
            this.Text = "Схема";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRegister;
        private System.Windows.Forms.RadioButton rbTransistor;
        private System.Windows.Forms.RadioButton rbCapacitor;
        private System.Windows.Forms.RadioButton rbDiode;
        private System.Windows.Forms.Panel Panel;
        private Scheme Schema;
    }
}

