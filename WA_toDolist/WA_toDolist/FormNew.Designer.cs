namespace WA_toDolist
{
    partial class FormNew
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
            btn_back = new Button();
            txt_title2 = new TextBox();
            txt_descriptionDuty = new TextBox();
            txt_title = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBoxDone = new ComboBox();
            btn_new = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(41, 36);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 0;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_title2
            // 
            txt_title2.Location = new Point(149, 97);
            txt_title2.Name = "txt_title2";
            txt_title2.Size = new Size(100, 23);
            txt_title2.TabIndex = 1;
            // 
            // txt_descriptionDuty
            // 
            txt_descriptionDuty.Location = new Point(255, 97);
            txt_descriptionDuty.Name = "txt_descriptionDuty";
            txt_descriptionDuty.Size = new Size(100, 23);
            txt_descriptionDuty.TabIndex = 2;
            // 
            // txt_title
            // 
            txt_title.AutoSize = true;
            txt_title.Location = new Point(154, 77);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(29, 15);
            txt_title.TabIndex = 4;
            txt_title.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 77);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Description duty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 78);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Done";
            // 
            // comboBoxDone
            // 
            comboBoxDone.Enabled = false;
            comboBoxDone.FormattingEnabled = true;
            comboBoxDone.Location = new Point(374, 97);
            comboBoxDone.Name = "comboBoxDone";
            comboBoxDone.Size = new Size(54, 23);
            comboBoxDone.TabIndex = 10;
            comboBoxDone.Text = "n";
            // 
            // btn_new
            // 
            btn_new.Location = new Point(458, 96);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(75, 23);
            btn_new.TabIndex = 11;
            btn_new.Text = "new";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(149, 36);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 12;
            label3.Text = "Adding a row";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 169);
            Controls.Add(label3);
            Controls.Add(btn_new);
            Controls.Add(comboBoxDone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_title);
            Controls.Add(txt_descriptionDuty);
            Controls.Add(txt_title2);
            Controls.Add(btn_back);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private TextBox txt_title2;
        private TextBox txt_descriptionDuty;
        private Label txt_title;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxDone;
        private Button btn_new;
        private Label label3;
    }
}