﻿namespace FootballMatch.Umasou.Business
{
    partial class ScheduleExcelImport
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
            this.dataGridView_ExcelImport = new System.Windows.Forms.DataGridView();
            this.button_deleteMultiRows = new System.Windows.Forms.Button();
            this.button_saveSchedule = new System.Windows.Forms.Button();
            this.button_deleteCurrentRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExcelImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ExcelImport
            // 
            this.dataGridView_ExcelImport.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_ExcelImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ExcelImport.Location = new System.Drawing.Point(-1, 31);
            this.dataGridView_ExcelImport.Name = "dataGridView_ExcelImport";
            this.dataGridView_ExcelImport.RowTemplate.Height = 23;
            this.dataGridView_ExcelImport.Size = new System.Drawing.Size(532, 213);
            this.dataGridView_ExcelImport.TabIndex = 0;
             // 
            // button_deleteMultiRows
            // 
            this.button_deleteMultiRows.Location = new System.Drawing.Point(203, 305);
            this.button_deleteMultiRows.Name = "button_deleteMultiRows";
            this.button_deleteMultiRows.Size = new System.Drawing.Size(75, 30);
            this.button_deleteMultiRows.TabIndex = 3;
            this.button_deleteMultiRows.Text = "删除多行";
            this.button_deleteMultiRows.UseVisualStyleBackColor = true;
            this.button_deleteMultiRows.Click += new System.EventHandler(this.button_deleteMultiRows_Click);
            // 
            // button_saveSchedule
            // 
            this.button_saveSchedule.Location = new System.Drawing.Point(319, 305);
            this.button_saveSchedule.Name = "button_saveSchedule";
            this.button_saveSchedule.Size = new System.Drawing.Size(75, 30);
            this.button_saveSchedule.TabIndex = 4;
            this.button_saveSchedule.Text = "保存赛程";
            this.button_saveSchedule.UseVisualStyleBackColor = true;
            this.button_saveSchedule.Click += new System.EventHandler(this.button_saveSchedule_Click);
            // 
            // button_deleteCurrentRow
            // 
            this.button_deleteCurrentRow.Location = new System.Drawing.Point(83, 305);
            this.button_deleteCurrentRow.Name = "button_deleteCurrentRow";
            this.button_deleteCurrentRow.Size = new System.Drawing.Size(75, 30);
            this.button_deleteCurrentRow.TabIndex = 5;
            this.button_deleteCurrentRow.Text = "删除当前行";
            this.button_deleteCurrentRow.UseVisualStyleBackColor = true;
            this.button_deleteCurrentRow.Click += new System.EventHandler(this.button_deleteCurrentRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "文件名";
      
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(74, 264);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(327, 21);
            this.textBox_fileName.TabIndex = 7;
             // 
            // button_openFile
            // 
            this.button_openFile.Location = new System.Drawing.Point(425, 264);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(75, 23);
            this.button_openFile.TabIndex = 8;
            this.button_openFile.Text = "导入文件";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(425, 305);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 30);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "关闭并返回";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // ScheduleExcelImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(531, 353);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_deleteMultiRows);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_saveSchedule);
            this.Controls.Add(this.button_deleteCurrentRow);
            this.Controls.Add(this.dataGridView_ExcelImport);
            this.Name = "ScheduleExcelImport";
            this.Text = "赛程导入";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExcelImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ExcelImport;
        private System.Windows.Forms.Button button_deleteMultiRows;
        private System.Windows.Forms.Button button_saveSchedule;
        private System.Windows.Forms.Button button_deleteCurrentRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_exit;
    }
}