namespace FileHandlerWinForm
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
            chooseFilesBtm = new Button();
            saveFilesBrm = new Button();
            label1 = new Label();
            numberOfFilesLbl = new Label();
            SuspendLayout();
            // 
            // chooseFilesBtm
            // 
            chooseFilesBtm.Location = new Point(31, 19);
            chooseFilesBtm.Name = "chooseFilesBtm";
            chooseFilesBtm.Size = new Size(117, 54);
            chooseFilesBtm.TabIndex = 0;
            chooseFilesBtm.Text = "Выбрать файл(ы)";
            chooseFilesBtm.UseVisualStyleBackColor = true;
            // 
            // saveFilesBrm
            // 
            saveFilesBrm.Location = new Point(163, 19);
            saveFilesBrm.Name = "saveFilesBrm";
            saveFilesBrm.Size = new Size(117, 54);
            saveFilesBrm.TabIndex = 1;
            saveFilesBrm.Text = "Сохранить файл(ы)";
            saveFilesBrm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(31, 87);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 2;
            label1.Text = "Количество файлов: ";
            // 
            // numberOfFilesLbl
            // 
            numberOfFilesLbl.AutoSize = true;
            numberOfFilesLbl.ForeColor = SystemColors.ControlLight;
            numberOfFilesLbl.Location = new Point(160, 87);
            numberOfFilesLbl.Name = "numberOfFilesLbl";
            numberOfFilesLbl.Size = new Size(13, 15);
            numberOfFilesLbl.TabIndex = 3;
            numberOfFilesLbl.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(numberOfFilesLbl);
            Controls.Add(label1);
            Controls.Add(saveFilesBrm);
            Controls.Add(chooseFilesBtm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseFilesBtm;
        private Button saveFilesBrm;
        private Label label1;
        private Label numberOfFilesLbl;
    }
}