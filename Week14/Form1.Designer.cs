
namespace Week14
{
    partial class Form1
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelTopScorer = new System.Windows.Forms.Label();
            this.labelWorstDiscipline = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DisplayTeamName = new System.Windows.Forms.Label();
            this.DisplayManager = new System.Windows.Forms.Label();
            this.DisplayStadium = new System.Windows.Forms.Label();
            this.DisplayTopScorer = new System.Windows.Forms.Label();
            this.DisplayWorstDiscipline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(13, 13);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(94, 13);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(177, 13);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(258, 13);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(13, 99);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(89, 17);
            this.labelTeamName.TabIndex = 4;
            this.labelTeamName.Text = "Team Name:";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(13, 127);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(68, 17);
            this.labelManager.TabIndex = 5;
            this.labelManager.Text = "Manager:";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(13, 156);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(63, 17);
            this.labelStadium.TabIndex = 6;
            this.labelStadium.Text = "Stadium:";
            // 
            // labelTopScorer
            // 
            this.labelTopScorer.AutoSize = true;
            this.labelTopScorer.Location = new System.Drawing.Point(13, 184);
            this.labelTopScorer.Name = "labelTopScorer";
            this.labelTopScorer.Size = new System.Drawing.Size(83, 17);
            this.labelTopScorer.TabIndex = 7;
            this.labelTopScorer.Text = "Top Scorer:";
            // 
            // labelWorstDiscipline
            // 
            this.labelWorstDiscipline.AutoSize = true;
            this.labelWorstDiscipline.Location = new System.Drawing.Point(13, 210);
            this.labelWorstDiscipline.Name = "labelWorstDiscipline";
            this.labelWorstDiscipline.Size = new System.Drawing.Size(113, 17);
            this.labelWorstDiscipline.TabIndex = 8;
            this.labelWorstDiscipline.Text = "Worst Discipline:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // DisplayTeamName
            // 
            this.DisplayTeamName.AutoSize = true;
            this.DisplayTeamName.Location = new System.Drawing.Point(109, 99);
            this.DisplayTeamName.Name = "DisplayTeamName";
            this.DisplayTeamName.Size = new System.Drawing.Size(46, 17);
            this.DisplayTeamName.TabIndex = 10;
            this.DisplayTeamName.Text = "label1";
            // 
            // DisplayManager
            // 
            this.DisplayManager.AutoSize = true;
            this.DisplayManager.Location = new System.Drawing.Point(88, 127);
            this.DisplayManager.Name = "DisplayManager";
            this.DisplayManager.Size = new System.Drawing.Size(46, 17);
            this.DisplayManager.TabIndex = 11;
            this.DisplayManager.Text = "label2";
            // 
            // DisplayStadium
            // 
            this.DisplayStadium.AutoSize = true;
            this.DisplayStadium.Location = new System.Drawing.Point(83, 156);
            this.DisplayStadium.Name = "DisplayStadium";
            this.DisplayStadium.Size = new System.Drawing.Size(46, 17);
            this.DisplayStadium.TabIndex = 12;
            this.DisplayStadium.Text = "label3";
            // 
            // DisplayTopScorer
            // 
            this.DisplayTopScorer.AutoSize = true;
            this.DisplayTopScorer.Location = new System.Drawing.Point(103, 184);
            this.DisplayTopScorer.Name = "DisplayTopScorer";
            this.DisplayTopScorer.Size = new System.Drawing.Size(46, 17);
            this.DisplayTopScorer.TabIndex = 13;
            this.DisplayTopScorer.Text = "label4";
            // 
            // DisplayWorstDiscipline
            // 
            this.DisplayWorstDiscipline.AutoSize = true;
            this.DisplayWorstDiscipline.Location = new System.Drawing.Point(133, 210);
            this.DisplayWorstDiscipline.Name = "DisplayWorstDiscipline";
            this.DisplayWorstDiscipline.Size = new System.Drawing.Size(46, 17);
            this.DisplayWorstDiscipline.TabIndex = 14;
            this.DisplayWorstDiscipline.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayWorstDiscipline);
            this.Controls.Add(this.DisplayTopScorer);
            this.Controls.Add(this.DisplayStadium);
            this.Controls.Add(this.DisplayManager);
            this.Controls.Add(this.DisplayTeamName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelWorstDiscipline);
            this.Controls.Add(this.labelTopScorer);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelTopScorer;
        private System.Windows.Forms.Label labelWorstDiscipline;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DisplayTeamName;
        private System.Windows.Forms.Label DisplayManager;
        private System.Windows.Forms.Label DisplayStadium;
        private System.Windows.Forms.Label DisplayTopScorer;
        private System.Windows.Forms.Label DisplayWorstDiscipline;
    }
}

