﻿
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.br = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bl = new System.Windows.Forms.Button();
            this.cr = new System.Windows.Forms.Button();
            this.cc = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.tr = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.Button();
            this.tl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.remis = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.br, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cr, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tr, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // br
            // 
            this.br.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.br.Location = new System.Drawing.Point(203, 203);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(93, 93);
            this.br.TabIndex = 8;
            this.br.UseVisualStyleBackColor = true;
            this.br.Click += new System.EventHandler(this.Mark);
            // 
            // bc
            // 
            this.bc.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bc.Location = new System.Drawing.Point(103, 203);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(93, 93);
            this.bc.TabIndex = 7;
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.Mark);
            // 
            // bl
            // 
            this.bl.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bl.Location = new System.Drawing.Point(3, 203);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(93, 93);
            this.bl.TabIndex = 6;
            this.bl.UseVisualStyleBackColor = true;
            this.bl.Click += new System.EventHandler(this.Mark);
            // 
            // cr
            // 
            this.cr.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cr.Location = new System.Drawing.Point(203, 103);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(93, 93);
            this.cr.TabIndex = 5;
            this.cr.UseVisualStyleBackColor = true;
            this.cr.Click += new System.EventHandler(this.Mark);
            // 
            // cc
            // 
            this.cc.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cc.Location = new System.Drawing.Point(103, 103);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(93, 93);
            this.cc.TabIndex = 4;
            this.cc.UseVisualStyleBackColor = true;
            this.cc.Click += new System.EventHandler(this.Mark);
            // 
            // cl
            // 
            this.cl.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cl.Location = new System.Drawing.Point(3, 103);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(93, 93);
            this.cl.TabIndex = 3;
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.Mark);
            // 
            // tr
            // 
            this.tr.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tr.Location = new System.Drawing.Point(203, 3);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(93, 93);
            this.tr.TabIndex = 2;
            this.tr.UseVisualStyleBackColor = true;
            this.tr.Click += new System.EventHandler(this.Mark);
            // 
            // tc
            // 
            this.tc.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tc.Location = new System.Drawing.Point(103, 3);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(93, 93);
            this.tc.TabIndex = 1;
            this.tc.UseVisualStyleBackColor = true;
            this.tc.Click += new System.EventHandler(this.Mark);
            // 
            // tl
            // 
            this.tl.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.tl.Location = new System.Drawing.Point(3, 3);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(93, 93);
            this.tl.TabIndex = 0;
            this.tl.UseVisualStyleBackColor = true;
            this.tl.Click += new System.EventHandler(this.Mark);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teraz ruch ma: ";
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Location = new System.Drawing.Point(93, 315);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(35, 13);
            this.currentPlayerLabel.TabIndex = 2;
            this.currentPlayerLabel.Text = "label2";
            this.currentPlayerLabel.Click += new System.EventHandler(this.Mark);
            // 
            // remis
            // 
            this.remis.AutoSize = true;
            this.remis.Location = new System.Drawing.Point(236, 325);
            this.remis.Name = "remis";
            this.remis.Size = new System.Drawing.Size(31, 13);
            this.remis.TabIndex = 3;
            this.remis.Text = "remis";
            this.remis.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 347);
            this.Controls.Add(this.remis);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Kolko i krzyzyk";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button br;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bl;
        private System.Windows.Forms.Button cr;
        private System.Windows.Forms.Button cc;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button tr;
        private System.Windows.Forms.Button tc;
        private System.Windows.Forms.Button tl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Label remis;
    }
}

