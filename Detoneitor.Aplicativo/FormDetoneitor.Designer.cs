
namespace Detoneitor.Aplicativo {
    partial class FormDetoneitor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetoneitor));
            this.btnExecuteitor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlanejeitor = new System.Windows.Forms.Button();
            this.gbxInformacoes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstadoTarefa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecuteitor
            // 
            this.btnExecuteitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteitor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExecuteitor.FlatAppearance.BorderSize = 2;
            this.btnExecuteitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExecuteitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnExecuteitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecuteitor.Image = global::Detoneitor.Aplicativo.Properties.Resources.data_cleaning_64;
            this.btnExecuteitor.Location = new System.Drawing.Point(359, 12);
            this.btnExecuteitor.Name = "btnExecuteitor";
            this.btnExecuteitor.Size = new System.Drawing.Size(128, 128);
            this.btnExecuteitor.TabIndex = 0;
            this.btnExecuteitor.Text = "Executêitor";
            this.btnExecuteitor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExecuteitor.UseVisualStyleBackColor = true;
            this.btnExecuteitor.Click += new System.EventHandler(this.btnExecuteitor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detonêitor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Detoneitor.Aplicativo.Properties.Resources.detonador;
            this.pictureBox1.Location = new System.Drawing.Point(220, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlanejeitor
            // 
            this.btnPlanejeitor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlanejeitor.FlatAppearance.BorderSize = 2;
            this.btnPlanejeitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPlanejeitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnPlanejeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanejeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanejeitor.Image = global::Detoneitor.Aplicativo.Properties.Resources.configuracao;
            this.btnPlanejeitor.Location = new System.Drawing.Point(12, 12);
            this.btnPlanejeitor.Name = "btnPlanejeitor";
            this.btnPlanejeitor.Size = new System.Drawing.Size(128, 128);
            this.btnPlanejeitor.TabIndex = 0;
            this.btnPlanejeitor.Text = "Planejêitor";
            this.btnPlanejeitor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlanejeitor.UseVisualStyleBackColor = true;
            this.btnPlanejeitor.Click += new System.EventHandler(this.btnPlanejeitor_Click);
            // 
            // gbxInformacoes
            // 
            this.gbxInformacoes.BackColor = System.Drawing.Color.Transparent;
            this.gbxInformacoes.Controls.Add(this.lblEstadoTarefa);
            this.gbxInformacoes.Controls.Add(this.label2);
            this.gbxInformacoes.ForeColor = System.Drawing.Color.White;
            this.gbxInformacoes.Location = new System.Drawing.Point(12, 147);
            this.gbxInformacoes.Name = "gbxInformacoes";
            this.gbxInformacoes.Size = new System.Drawing.Size(475, 100);
            this.gbxInformacoes.TabIndex = 3;
            this.gbxInformacoes.TabStop = false;
            this.gbxInformacoes.Text = "Informações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status da tarefa:";
            // 
            // lblEstadoTarefa
            // 
            this.lblEstadoTarefa.Location = new System.Drawing.Point(344, 23);
            this.lblEstadoTarefa.Name = "lblEstadoTarefa";
            this.lblEstadoTarefa.Size = new System.Drawing.Size(125, 16);
            this.lblEstadoTarefa.TabIndex = 1;
            this.lblEstadoTarefa.Text = "Status";
            this.lblEstadoTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDetoneitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(499, 256);
            this.Controls.Add(this.gbxInformacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExecuteitor);
            this.Controls.Add(this.btnPlanejeitor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormDetoneitor";
            this.Text = ".:: Detonêitor ::.";
            this.Load += new System.EventHandler(this.FormDetoneitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxInformacoes.ResumeLayout(false);
            this.gbxInformacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlanejeitor;
        private System.Windows.Forms.Button btnExecuteitor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxInformacoes;
        private System.Windows.Forms.Label lblEstadoTarefa;
        private System.Windows.Forms.Label label2;
    }
}

