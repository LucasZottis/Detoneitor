
namespace Detoneitor.Planejeitor.Janelas {
    partial class FormPlanejeitor {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanejeitor));
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCaminhoPasta = new System.Windows.Forms.TextBox();
            this.BtnBuscarPasta = new System.Windows.Forms.Button();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fbdPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.ForeColor = System.Drawing.Color.Black;
            this.BtnSalvar.Location = new System.Drawing.Point(371, 52);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(217, 32);
            this.BtnSalvar.TabIndex = 12;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pasta: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.895833F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCaminhoPasta, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnBuscarPasta, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 30);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // txtCaminhoPasta
            // 
            this.txtCaminhoPasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoPasta.Location = new System.Drawing.Point(60, 3);
            this.txtCaminhoPasta.Name = "txtCaminhoPasta";
            this.txtCaminhoPasta.Size = new System.Drawing.Size(426, 22);
            this.txtCaminhoPasta.TabIndex = 13;
            this.txtCaminhoPasta.Validating += new System.ComponentModel.CancelEventHandler(this.txtCaminhoPasta_Validating);
            // 
            // BtnBuscarPasta
            // 
            this.BtnBuscarPasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBuscarPasta.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarPasta.Location = new System.Drawing.Point(492, 3);
            this.BtnBuscarPasta.Name = "BtnBuscarPasta";
            this.BtnBuscarPasta.Size = new System.Drawing.Size(81, 24);
            this.BtnBuscarPasta.TabIndex = 15;
            this.BtnBuscarPasta.Text = "Escolher";
            this.BtnBuscarPasta.UseVisualStyleBackColor = true;
            this.BtnBuscarPasta.Click += new System.EventHandler(this.BtnBuscarPasta_Click);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(72, 56);
            this.txtDia.MaxLength = 2;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(57, 22);
            this.txtDia.TabIndex = 16;
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia.TextChanged += new System.EventHandler(this.txtDia_TextChanged);
            this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_KeyPress);
            this.txtDia.Validating += new System.ComponentModel.CancelEventHandler(this.txtDia_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dia:";
            // 
            // fbdPasta
            // 
            this.fbdPasta.Description = "Pasta onde será executado a limpeza.";
            // 
            // FormPlanejeitor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 94);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.BtnSalvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlanejeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planejêitor";
            this.Load += new System.EventHandler(this.FormPlanejeitor_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox txtCaminhoPasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnBuscarPasta;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog fbdPasta;
    }
}

