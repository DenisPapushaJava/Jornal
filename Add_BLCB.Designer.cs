/*
 * Создано в SharpDevelop.
 * Пользователь: papusha
 * Дата: 08.06.2022
 * Время: 15:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Jornal
{
	partial class Add_BLCB
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label_InfoBLCB;
		private System.Windows.Forms.TextBox textBox_NumberBLCB;
		private System.Windows.Forms.Button button_OK_BLCB;
		private System.Windows.Forms.Button button_CancelAddBLCB;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_BLCB));
            this.label_InfoBLCB = new System.Windows.Forms.Label();
            this.textBox_NumberBLCB = new System.Windows.Forms.TextBox();
            this.button_OK_BLCB = new System.Windows.Forms.Button();
            this.button_CancelAddBLCB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_InfoBLCB
            // 
            this.label_InfoBLCB.AutoSize = true;
            this.label_InfoBLCB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_InfoBLCB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InfoBLCB.Location = new System.Drawing.Point(13, 10);
            this.label_InfoBLCB.Name = "label_InfoBLCB";
            this.label_InfoBLCB.Padding = new System.Windows.Forms.Padding(5);
            this.label_InfoBLCB.Size = new System.Drawing.Size(10, 25);
            this.label_InfoBLCB.TabIndex = 0;
            // 
            // textBox_NumberBLCB
            // 
            this.textBox_NumberBLCB.AllowDrop = true;
            this.textBox_NumberBLCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NumberBLCB.Location = new System.Drawing.Point(381, 69);
            this.textBox_NumberBLCB.Name = "textBox_NumberBLCB";
            this.textBox_NumberBLCB.Size = new System.Drawing.Size(90, 20);
            this.textBox_NumberBLCB.TabIndex = 1;
            // 
            // button_OK_BLCB
            // 
            this.button_OK_BLCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK_BLCB.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_OK_BLCB.Location = new System.Drawing.Point(316, 120);
            this.button_OK_BLCB.Name = "button_OK_BLCB";
            this.button_OK_BLCB.Size = new System.Drawing.Size(75, 29);
            this.button_OK_BLCB.TabIndex = 2;
            this.button_OK_BLCB.Text = "OK";
            this.button_OK_BLCB.UseVisualStyleBackColor = false;
            this.button_OK_BLCB.Click += new System.EventHandler(this.Button_OK_BLCBClick);
            // 
            // button_CancelAddBLCB
            // 
            this.button_CancelAddBLCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CancelAddBLCB.BackColor = System.Drawing.Color.RosyBrown;
            this.button_CancelAddBLCB.Location = new System.Drawing.Point(397, 120);
            this.button_CancelAddBLCB.Name = "button_CancelAddBLCB";
            this.button_CancelAddBLCB.Size = new System.Drawing.Size(75, 29);
            this.button_CancelAddBLCB.TabIndex = 3;
            this.button_CancelAddBLCB.Text = "Отмена";
            this.button_CancelAddBLCB.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "  Реализацию №";
            // 
            // Add_BLCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CancelAddBLCB);
            this.Controls.Add(this.button_OK_BLCB);
            this.Controls.Add(this.textBox_NumberBLCB);
            this.Controls.Add(this.label_InfoBLCB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 900);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Add_BLCB";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить БЛЦБ";
            this.Load += new System.EventHandler(this.Add_BLCBLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label label1;
    }
}
