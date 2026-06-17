namespace BuscadorMoedaInterface
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Compra = new DataGridViewTextBoxColumn();
            Venda = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Media = new DataGridViewTextBoxColumn();
            btEuro = new Button();
            btDolar = new Button();
            caminhoSelecionado = new TextBox();
            button1 = new Button();
            txtProgresso = new Label();
            limpaTabelas = new Button();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            botaoSalva = new Button();
            atualMoeda = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Data, Compra, Venda });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(69, 427);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(509, 207);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Data
            // 
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Data.DefaultCellStyle = dataGridViewCellStyle2;
            Data.HeaderText = "Data";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            // 
            // Compra
            // 
            Compra.HeaderText = "Cotação de Compra";
            Compra.MinimumWidth = 6;
            Compra.Name = "Compra";
            // 
            // Venda
            // 
            Venda.HeaderText = "Cotação de Venda";
            Venda.MinimumWidth = 6;
            Venda.Name = "Venda";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Media });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.GridColor = SystemColors.Desktop;
            dataGridView2.Location = new Point(235, 644);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RightToLeft = RightToLeft.No;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.ScrollBars = ScrollBars.None;
            dataGridView2.Size = new Size(170, 64);
            dataGridView2.TabIndex = 12;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Media
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Media.DefaultCellStyle = dataGridViewCellStyle5;
            Media.HeaderText = "   Média do Período";
            Media.MinimumWidth = 6;
            Media.Name = "Media";
            // 
            // btEuro
            // 
            btEuro.BackColor = Color.FromArgb(255, 192, 128);
            btEuro.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btEuro.Location = new Point(315, 235);
            btEuro.Name = "btEuro";
            btEuro.Size = new Size(210, 57);
            btEuro.TabIndex = 13;
            btEuro.Text = "Consultar em Euro";
            btEuro.UseVisualStyleBackColor = false;
            btEuro.Click += btEuro_Click;
            // 
            // btDolar
            // 
            btDolar.BackColor = Color.FromArgb(128, 255, 128);
            btDolar.FlatAppearance.BorderColor = Color.Red;
            btDolar.FlatAppearance.BorderSize = 100;
            btDolar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btDolar.Font = new Font("Nirmala UI", 11F, FontStyle.Bold);
            btDolar.Location = new Point(101, 235);
            btDolar.Name = "btDolar";
            btDolar.Size = new Size(210, 57);
            btDolar.TabIndex = 6;
            btDolar.Text = "Consultar em Dólar";
            btDolar.UseVisualStyleBackColor = false;
            btDolar.Click += Buscar_Click;
            // 
            // caminhoSelecionado
            // 
            caminhoSelecionado.BorderStyle = BorderStyle.None;
            caminhoSelecionado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            caminhoSelecionado.Location = new Point(315, 173);
            caminhoSelecionado.Name = "caminhoSelecionado";
            caminhoSelecionado.Size = new Size(263, 20);
            caminhoSelecionado.TabIndex = 14;
            caminhoSelecionado.TextChanged += caminhoSelecionado_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(69, 169);
            button1.Name = "button1";
            button1.Size = new Size(240, 28);
            button1.TabIndex = 16;
            button1.Text = "Definir Pasta de Destino:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtProgresso
            // 
            txtProgresso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProgresso.AutoEllipsis = true;
            txtProgresso.AutoSize = true;
            txtProgresso.Location = new Point(222, 715);
            txtProgresso.Name = "txtProgresso";
            txtProgresso.Size = new Size(77, 20);
            txtProgresso.TabIndex = 17;
            txtProgresso.Text = "Progresso:";
            txtProgresso.Click += label1_Click_2;
            // 
            // limpaTabelas
            // 
            limpaTabelas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            limpaTabelas.Location = new Point(315, 323);
            limpaTabelas.Name = "limpaTabelas";
            limpaTabelas.Size = new Size(139, 29);
            limpaTabelas.TabIndex = 18;
            limpaTabelas.Text = "Limpar Dados";
            limpaTabelas.UseVisualStyleBackColor = true;
            limpaTabelas.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.BackColor = SystemColors.ActiveCaptionText;
            progressBar1.ForeColor = Color.FromArgb(128, 255, 128);
            progressBar1.Location = new Point(310, 721);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(139, 13);
            progressBar1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(222, -96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // botaoSalva
            // 
            botaoSalva.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botaoSalva.Location = new Point(170, 323);
            botaoSalva.Name = "botaoSalva";
            botaoSalva.Size = new Size(139, 29);
            botaoSalva.TabIndex = 21;
            botaoSalva.Text = "Salvar Dados";
            botaoSalva.UseVisualStyleBackColor = true;
            botaoSalva.Click += button2_Click_1;
            // 
            // atualMoeda
            // 
            atualMoeda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            atualMoeda.BorderStyle = BorderStyle.None;
            atualMoeda.Location = new Point(315, 392);
            atualMoeda.Name = "atualMoeda";
            atualMoeda.Size = new Size(139, 20);
            atualMoeda.TabIndex = 22;
            atualMoeda.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 393);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 23;
            label1.Text = "Moeda Selecionada:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(645, 776);
            Controls.Add(label1);
            Controls.Add(botaoSalva);
            Controls.Add(progressBar1);
            Controls.Add(limpaTabelas);
            Controls.Add(txtProgresso);
            Controls.Add(button1);
            Controls.Add(caminhoSelecionado);
            Controls.Add(btEuro);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btDolar);
            Controls.Add(pictureBox1);
            Controls.Add(atualMoeda);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotação ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btEuro;
        private Button btDolar;
        private TextBox caminhoSelecionado;
        private Button button1;
        private Label txtProgresso;
        private Button limpaTabelas;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Button botaoSalva;
        private TextBox atualMoeda;
        private Label label1;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Compra;
        private DataGridViewTextBoxColumn Venda;
        private DataGridViewTextBoxColumn Media;
    }
}
