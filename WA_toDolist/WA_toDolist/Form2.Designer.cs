namespace WA_toDolist
{
    partial class Form2
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
            lbl_id = new Label();
            txt_title = new TextBox();
            txt_descriptionDuty = new TextBox();
            lbl_title = new Label();
            label1 = new Label();
            label2 = new Label();
            btn_edit = new Button();
            comboBoxDone = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(65, 29);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 0;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(78, 104);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(36, 15);
            lbl_id.TabIndex = 1;
            lbl_id.Text = "testId";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(161, 101);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(100, 23);
            txt_title.TabIndex = 2;
            // 
            // txt_descriptionDuty
            // 
            txt_descriptionDuty.Location = new Point(267, 101);
            txt_descriptionDuty.Name = "txt_descriptionDuty";
            txt_descriptionDuty.Size = new Size(100, 23);
            txt_descriptionDuty.TabIndex = 3;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(190, 79);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(29, 15);
            lbl_title.TabIndex = 5;
            lbl_title.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 79);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 6;
            label1.Text = "Description duty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 79);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Done";
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(499, 101);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // comboBoxDone
            // 
            comboBoxDone.FormattingEnabled = true;
            comboBoxDone.Location = new Point(380, 101);
            comboBoxDone.Name = "comboBoxDone";
            comboBoxDone.Size = new Size(54, 23);
            comboBoxDone.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(161, 29);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 13;
            label3.Text = "Editing a row";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 157);
            Controls.Add(label3);
            Controls.Add(comboBoxDone);
            Controls.Add(btn_edit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_title);
            Controls.Add(txt_descriptionDuty);
            Controls.Add(txt_title);
            Controls.Add(lbl_id);
            Controls.Add(btn_back);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Label lbl_id;
        private TextBox txt_title;
        private TextBox txt_descriptionDuty;
        private Label lbl_title;
        private Label label1;
        private Label label2;
        private Button btn_edit;
        private ComboBox comboBoxDone;
        private Label label3;
    }
}