
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
            this.Solve = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.ForSorting = new System.Windows.Forms.DataGridView();
            this.CloseForm = new System.Windows.Forms.Button();
            this.ForDecision = new System.Windows.Forms.DataGridView();
            this.ForArcs = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ForSorting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForDecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForArcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(12, 12);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(88, 40);
            this.Solve.TabIndex = 0;
            this.Solve.Text = "Решить";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(106, 12);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(88, 40);
            this.Sort.TabIndex = 1;
            this.Sort.Text = "Сортировать";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // ForSorting
            // 
            this.ForSorting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForSorting.Location = new System.Drawing.Point(200, 12);
            this.ForSorting.Name = "ForSorting";
            this.ForSorting.Size = new System.Drawing.Size(210, 211);
            this.ForSorting.TabIndex = 2;
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(12, 58);
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
            this.ForDecision.Location = new System.Drawing.Point(416, 12);
            this.ForDecision.Name = "ForDecision";
            this.ForDecision.Size = new System.Drawing.Size(160, 211);
            this.ForDecision.TabIndex = 4;
            // 
            // ForArcs
            // 
            this.ForArcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForArcs.Location = new System.Drawing.Point(582, 12);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ForArcs);
            this.Controls.Add(this.ForDecision);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.ForSorting);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Solve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ForSorting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForDecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForArcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.DataGridView ForSorting;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.DataGridView ForDecision;
        private System.Windows.Forms.DataGridView ForArcs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

