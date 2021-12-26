
namespace Kruskal_s_algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ForSorting = new System.Windows.Forms.DataGridView();
            this.CloseForm = new System.Windows.Forms.Button();
            this.ForDecision = new System.Windows.Forms.DataGridView();
            this.ForArcs = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.withSorting = new System.Windows.Forms.RadioButton();
            this.withoutSorting = new System.Windows.Forms.RadioButton();
            this.showPicture = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ForSorting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForDecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForArcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ForSorting
            // 
            this.ForSorting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForSorting.Location = new System.Drawing.Point(200, 12);
            this.ForSorting.Name = "ForSorting";
            this.ForSorting.Size = new System.Drawing.Size(260, 211);
            this.ForSorting.TabIndex = 2;
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(12, 127);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(88, 40);
            this.CloseForm.TabIndex = 3;
            this.CloseForm.Text = "Выход";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // ForDecision
            // 
            this.ForDecision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForDecision.Location = new System.Drawing.Point(466, 12);
            this.ForDecision.Name = "ForDecision";
            this.ForDecision.Size = new System.Drawing.Size(160, 211);
            this.ForDecision.TabIndex = 4;
            // 
            // ForArcs
            // 
            this.ForArcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForArcs.Location = new System.Drawing.Point(632, 12);
            this.ForArcs.Name = "ForArcs";
            this.ForArcs.Size = new System.Drawing.Size(260, 211);
            this.ForArcs.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 397);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(12, 81);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(88, 40);
            this.ExecuteButton.TabIndex = 7;
            this.ExecuteButton.Text = "Решить";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // withSorting
            // 
            this.withSorting.AutoSize = true;
            this.withSorting.Location = new System.Drawing.Point(15, 12);
            this.withSorting.Name = "withSorting";
            this.withSorting.Size = new System.Drawing.Size(141, 17);
            this.withSorting.TabIndex = 8;
            this.withSorting.Text = "Используя сортировку";
            this.withSorting.UseVisualStyleBackColor = true;
            // 
            // withoutSorting
            // 
            this.withoutSorting.AutoSize = true;
            this.withoutSorting.Location = new System.Drawing.Point(15, 35);
            this.withoutSorting.Name = "withoutSorting";
            this.withoutSorting.Size = new System.Drawing.Size(106, 17);
            this.withoutSorting.TabIndex = 9;
            this.withoutSorting.Text = "Без сортировки";
            this.withoutSorting.UseVisualStyleBackColor = true;
            // 
            // showPicture
            // 
            this.showPicture.AutoSize = true;
            this.showPicture.Location = new System.Drawing.Point(15, 58);
            this.showPicture.Name = "showPicture";
            this.showPicture.Size = new System.Drawing.Size(121, 17);
            this.showPicture.TabIndex = 12;
            this.showPicture.TabStop = true;
            this.showPicture.Text = "Показать решение";
            this.showPicture.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1304, 749);
            this.Controls.Add(this.showPicture);
            this.Controls.Add(this.withoutSorting);
            this.Controls.Add(this.withSorting);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ForArcs);
            this.Controls.Add(this.ForDecision);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.ForSorting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ForSorting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForDecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForArcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ForSorting;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.DataGridView ForDecision;
        private System.Windows.Forms.DataGridView ForArcs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.RadioButton withSorting;
        private System.Windows.Forms.RadioButton withoutSorting;
        private System.Windows.Forms.RadioButton showPicture;
    }
}

