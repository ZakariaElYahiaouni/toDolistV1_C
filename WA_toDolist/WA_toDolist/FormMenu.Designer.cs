﻿namespace WA_toDolist
{
    partial class FormMenu
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
            label1 = new Label();
            txt_search = new TextBox();
            lbl_search = new Label();
            btn_enter = new Button();
            RBtn_toDo = new RadioButton();
            RBtn_all = new RadioButton();
            button2 = new Button();
            dataGridView_layoutList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_layoutList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 0;
            label1.Text = "To-do-list Demo";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(120, 52);
            txt_search.Margin = new Padding(2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(156, 23);
            txt_search.TabIndex = 1;
            txt_search.KeyDown += txt_search_KeyDown;
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.Location = new Point(71, 53);
            lbl_search.Margin = new Padding(2, 0, 2, 0);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(42, 15);
            lbl_search.TabIndex = 2;
            lbl_search.Text = "Search";
            // 
            // btn_enter
            // 
            btn_enter.Location = new Point(293, 52);
            btn_enter.Margin = new Padding(2);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(78, 20);
            btn_enter.TabIndex = 3;
            btn_enter.Text = "Enter";
            btn_enter.UseVisualStyleBackColor = true;
            btn_enter.Click += btn_enter_Click;
            // 
            // RBtn_toDo
            // 
            RBtn_toDo.AutoSize = true;
            RBtn_toDo.Location = new Point(393, 56);
            RBtn_toDo.Margin = new Padding(2);
            RBtn_toDo.Name = "RBtn_toDo";
            RBtn_toDo.Size = new Size(53, 19);
            RBtn_toDo.TabIndex = 4;
            RBtn_toDo.TabStop = true;
            RBtn_toDo.Text = "to do";
            RBtn_toDo.UseVisualStyleBackColor = true;
            RBtn_toDo.CheckedChanged += RBtn_toDo_CheckedChanged;
            // 
            // RBtn_all
            // 
            RBtn_all.AutoSize = true;
            RBtn_all.Location = new Point(454, 56);
            RBtn_all.Margin = new Padding(2);
            RBtn_all.Name = "RBtn_all";
            RBtn_all.Size = new Size(37, 19);
            RBtn_all.TabIndex = 5;
            RBtn_all.TabStop = true;
            RBtn_all.Text = "all";
            RBtn_all.UseVisualStyleBackColor = true;
            RBtn_all.CheckedChanged += RBtn_all_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(508, 53);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(32, 20);
            button2.TabIndex = 6;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dataGridView_layoutList
            // 
            dataGridView_layoutList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_layoutList.Location = new Point(12, 107);
            dataGridView_layoutList.Name = "dataGridView_layoutList";
            dataGridView_layoutList.RowTemplate.Height = 25;
            dataGridView_layoutList.Size = new Size(545, 532);
            dataGridView_layoutList.TabIndex = 7;
            dataGridView_layoutList.CellContentClick += dataGridView_layoutList_CellContentClick;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 669);
            Controls.Add(dataGridView_layoutList);
            Controls.Add(button2);
            Controls.Add(RBtn_all);
            Controls.Add(RBtn_toDo);
            Controls.Add(btn_enter);
            Controls.Add(lbl_search);
            Controls.Add(txt_search);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menù";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_layoutList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_search;
        private Label lbl_search;
        private Button btn_enter;
        private RadioButton RBtn_toDo;
        private RadioButton RBtn_all;
        private Button button2;
        private DataGridView dataGridView_layoutList;
    }
}