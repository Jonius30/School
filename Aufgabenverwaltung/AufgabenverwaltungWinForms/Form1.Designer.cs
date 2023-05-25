namespace AufgabenverwaltungWinForms
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lbToDo = new System.Windows.Forms.ListBox();
            this.lbInProgress = new System.Windows.Forms.ListBox();
            this.lbReview = new System.Windows.Forms.ListBox();
            this.lbDone = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblReview, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblInProgress, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblToDo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDone, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbToDo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbInProgress, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbReview, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbDone, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(504, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReview.Location = new System.Drawing.Point(255, 22);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(120, 22);
            this.lblReview.TabIndex = 2;
            this.lblReview.Text = "Review";
            this.lblReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInProgress.Location = new System.Drawing.Point(129, 22);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(120, 22);
            this.lblInProgress.TabIndex = 1;
            this.lblInProgress.Text = "In Progress";
            this.lblInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToDo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToDo.Location = new System.Drawing.Point(3, 22);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(120, 22);
            this.lblToDo.TabIndex = 0;
            this.lblToDo.Text = "To Do";
            this.lblToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDone.Location = new System.Drawing.Point(381, 22);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(120, 22);
            this.lblDone.TabIndex = 3;
            this.lblDone.Text = "Done";
            this.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbToDo
            // 
            this.lbToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbToDo.FormattingEnabled = true;
            this.lbToDo.ItemHeight = 15;
            this.lbToDo.Location = new System.Drawing.Point(3, 47);
            this.lbToDo.Name = "lbToDo";
            this.lbToDo.Size = new System.Drawing.Size(120, 394);
            this.lbToDo.TabIndex = 4;
            this.lbToDo.SelectedIndexChanged += new System.EventHandler(this.lbSelectedIndexChanged);
            // 
            // lbInProgress
            // 
            this.lbInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInProgress.FormattingEnabled = true;
            this.lbInProgress.ItemHeight = 15;
            this.lbInProgress.Location = new System.Drawing.Point(129, 47);
            this.lbInProgress.Name = "lbInProgress";
            this.lbInProgress.Size = new System.Drawing.Size(120, 394);
            this.lbInProgress.TabIndex = 5;
            this.lbInProgress.SelectedIndexChanged += new System.EventHandler(this.lbSelectedIndexChanged);
            // 
            // lbReview
            // 
            this.lbReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbReview.FormattingEnabled = true;
            this.lbReview.ItemHeight = 15;
            this.lbReview.Location = new System.Drawing.Point(255, 47);
            this.lbReview.Name = "lbReview";
            this.lbReview.Size = new System.Drawing.Size(120, 394);
            this.lbReview.TabIndex = 6;
            this.lbReview.SelectedIndexChanged += new System.EventHandler(this.lbSelectedIndexChanged);
            // 
            // lbDone
            // 
            this.lbDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDone.FormattingEnabled = true;
            this.lbDone.ItemHeight = 15;
            this.lbDone.Location = new System.Drawing.Point(381, 47);
            this.lbDone.Name = "lbDone";
            this.lbDone.Size = new System.Drawing.Size(120, 394);
            this.lbDone.TabIndex = 7;
            this.lbDone.SelectedIndexChanged += new System.EventHandler(this.lbSelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnSettings, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(513, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(122, 444);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Location = new System.Drawing.Point(3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(116, 38);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Config";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnForward, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(116, 38);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnMoveClick);
            // 
            // btnForward
            // 
            this.btnForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward.Location = new System.Drawing.Point(61, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(52, 32);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = "->";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnMoveClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(116, 350);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 52);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Neu";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblDone;
        private Label lblReview;
        private Label lblInProgress;
        private Label lblToDo;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSettings;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnBack;
        private Button btnForward;
        private ListBox lbToDo;
        private ListBox lbInProgress;
        private ListBox lbReview;
        private ListBox lbDone;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnNew;
    }
}