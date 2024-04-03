namespace _22125_22127_RelProj2
{
    partial class frmMapa
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
            groupBox1 = new GroupBox();
            lsbArquivo = new ListBox();
            nudCoordenadaY = new NumericUpDown();
            label4 = new Label();
            nudCoordenadaX = new NumericUpDown();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            pcMapa = new PictureBox();
            dlgAbrir = new OpenFileDialog();
            btnInicio = new ToolStripButton();
            btnAnterior = new ToolStripButton();
            btnProximo = new ToolStripButton();
            btnUltimo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnProcurar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnNovo = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnSalvar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            btnExcluir = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnSair = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            dlgSalvar = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            c1 = new DataGridViewTextBoxColumn();
            c2 = new DataGridViewTextBoxColumn();
            c3 = new DataGridViewTextBoxColumn();
            c4 = new DataGridViewTextBoxColumn();
            c5 = new DataGridViewTextBoxColumn();
            c6 = new DataGridViewTextBoxColumn();
            c7 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label11 = new Label();
            tbCidades = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnAcharCaminho = new Button();
            dataGridView2 = new DataGridView();
            c8 = new DataGridViewTextBoxColumn();
            label17 = new Label();
            cbDestino2 = new ComboBox();
            cbOrigem2 = new ComboBox();
            nudCusto2 = new NumericUpDown();
            nudTempo2 = new NumericUpDown();
            nudDistancia2 = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            comboBox3 = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCoordenadaY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCoordenadaX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcMapa).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbCidades.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCusto2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTempo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lsbArquivo);
            groupBox1.Controls.Add(nudCoordenadaY);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudCoordenadaX);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 423);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cidades";
            // 
            // lsbArquivo
            // 
            lsbArquivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsbArquivo.FormattingEnabled = true;
            lsbArquivo.ItemHeight = 15;
            lsbArquivo.Location = new Point(6, 112);
            lsbArquivo.Name = "lsbArquivo";
            lsbArquivo.Size = new Size(321, 304);
            lsbArquivo.TabIndex = 8;
            // 
            // nudCoordenadaY
            // 
            nudCoordenadaY.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudCoordenadaY.Location = new Point(126, 83);
            nudCoordenadaY.Name = "nudCoordenadaY";
            nudCoordenadaY.Size = new Size(191, 23);
            nudCoordenadaY.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(15, 85);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Coordenada Y: ";
            // 
            // nudCoordenadaX
            // 
            nudCoordenadaX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudCoordenadaX.Location = new Point(126, 54);
            nudCoordenadaX.Name = "nudCoordenadaX";
            nudCoordenadaX.Size = new Size(191, 23);
            nudCoordenadaX.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(15, 56);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Coordenada X: ";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(126, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(191, 23);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(15, 27);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome da cidade:";
            // 
            // pcMapa
            // 
            pcMapa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcMapa.Image = Properties.Resources.mapaEspanhaPortugal;
            pcMapa.Location = new Point(368, 57);
            pcMapa.Name = "pcMapa";
            pcMapa.Size = new Size(582, 473);
            pcMapa.SizeMode = PictureBoxSizeMode.StretchImage;
            pcMapa.TabIndex = 2;
            pcMapa.TabStop = false;
            pcMapa.Paint += pcMapa_Paint;
            // 
            // dlgAbrir
            // 
            dlgAbrir.FileName = "openFileDialog1";
            // 
            // btnInicio
            // 
            btnInicio.Image = Properties.Resources.first;
            btnInicio.ImageTransparentColor = Color.Magenta;
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(40, 35);
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Image = Properties.Resources.prior;
            btnAnterior.ImageTransparentColor = Color.Magenta;
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(54, 35);
            btnAnterior.Text = "Anterior";
            btnAnterior.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Image = Properties.Resources.next;
            btnProximo.ImageTransparentColor = Color.Magenta;
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(56, 35);
            btnProximo.Text = "Próximo";
            btnProximo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Image = Properties.Resources.last;
            btnUltimo.ImageTransparentColor = Color.Magenta;
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(47, 35);
            btnUltimo.Text = "Último";
            btnUltimo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // btnProcurar
            // 
            btnProcurar.Image = Properties.Resources.Oeil2;
            btnProcurar.ImageTransparentColor = Color.Magenta;
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(56, 35);
            btnProcurar.Text = "Procurar";
            btnProcurar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // btnNovo
            // 
            btnNovo.Image = Properties.Resources.Add;
            btnNovo.ImageTransparentColor = Color.Magenta;
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(40, 35);
            btnNovo.Text = "Novo";
            btnNovo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.UNDO;
            btnCancelar.ImageTransparentColor = Color.Magenta;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(57, 35);
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.Save;
            btnSalvar.ImageTransparentColor = Color.Magenta;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(42, 35);
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 38);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 38);
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.Minus;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(46, 35);
            btnExcluir.Text = "Excluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 38);
            // 
            // btnSair
            // 
            btnSair.Image = Properties.Resources.CLOSE1;
            btnSair.ImageTransparentColor = Color.Magenta;
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(30, 35);
            btnSair.Text = "Sair";
            btnSair.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSair.Click += btnSair_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInicio, btnAnterior, btnProximo, btnUltimo, toolStripSeparator1, btnProcurar, toolStripSeparator2, btnNovo, btnCancelar, btnSalvar, toolStripSeparator3, toolStripSeparator4, btnExcluir, toolStripSeparator5, btnSair });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(510, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 694);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(962, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "Registros: ";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(58, 17);
            toolStripStatusLabel1.Text = "Registros:";
            // 
            // dlgSalvar
            // 
            dlgSalvar.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { c1, c2, c3, c4, c5, c6, c7 });
            dataGridView1.Location = new Point(368, 536);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(582, 155);
            dataGridView1.TabIndex = 4;
            // 
            // c1
            // 
            c1.HeaderText = "1a";
            c1.Name = "c1";
            c1.Width = 77;
            // 
            // c2
            // 
            c2.HeaderText = "2a";
            c2.Name = "c2";
            c2.Width = 77;
            // 
            // c3
            // 
            c3.HeaderText = "3a";
            c3.Name = "c3";
            c3.Width = 77;
            // 
            // c4
            // 
            c4.HeaderText = "4a";
            c4.Name = "c4";
            c4.Width = 77;
            // 
            // c5
            // 
            c5.HeaderText = "5a";
            c5.Name = "c5";
            c5.Width = 77;
            // 
            // c6
            // 
            c6.HeaderText = "6a";
            c6.Name = "c6";
            c6.Width = 77;
            // 
            // c7
            // 
            c7.HeaderText = "7a";
            c7.Name = "c7";
            c7.Width = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 545);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 5;
            label1.Text = "Caminhos encontrados";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(142, 570);
            label11.Name = "label11";
            label11.Size = new Size(220, 15);
            label11.TabIndex = 6;
            label11.Text = "Km do caminho selecionado (xxxxx Km)";
            // 
            // tbCidades
            // 
            tbCidades.Controls.Add(tabPage1);
            tbCidades.Controls.Add(tabPage2);
            tbCidades.Location = new Point(12, 57);
            tbCidades.Name = "tbCidades";
            tbCidades.SelectedIndex = 0;
            tbCidades.Size = new Size(350, 463);
            tbCidades.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(342, 435);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cidades";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAcharCaminho);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(cbDestino2);
            tabPage2.Controls.Add(cbOrigem2);
            tabPage2.Controls.Add(nudCusto2);
            tabPage2.Controls.Add(nudTempo2);
            tabPage2.Controls.Add(nudDistancia2);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label16);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(342, 435);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Busca";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAcharCaminho
            // 
            btnAcharCaminho.Location = new Point(32, 156);
            btnAcharCaminho.Name = "btnAcharCaminho";
            btnAcharCaminho.Size = new Size(70, 58);
            btnAcharCaminho.TabIndex = 40;
            btnAcharCaminho.Text = "Achar caminhos";
            btnAcharCaminho.UseVisualStyleBackColor = true;
            btnAcharCaminho.Click += btnAcharCaminho_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { c8 });
            dataGridView2.Location = new Point(143, 156);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(180, 273);
            dataGridView2.TabIndex = 39;
            // 
            // c8
            // 
            c8.HeaderText = "Passando por";
            c8.Name = "c8";
            c8.Width = 120;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(143, 134);
            label17.Name = "label17";
            label17.Size = new Size(180, 19);
            label17.TabIndex = 38;
            label17.Text = "Melhor caminho (yyyyy Km)";
            // 
            // cbDestino2
            // 
            cbDestino2.FormattingEnabled = true;
            cbDestino2.Location = new Point(172, 33);
            cbDestino2.Name = "cbDestino2";
            cbDestino2.Size = new Size(151, 23);
            cbDestino2.TabIndex = 37;
            // 
            // cbOrigem2
            // 
            cbOrigem2.FormattingEnabled = true;
            cbOrigem2.Location = new Point(15, 33);
            cbOrigem2.Name = "cbOrigem2";
            cbOrigem2.Size = new Size(151, 23);
            cbOrigem2.TabIndex = 36;
            // 
            // nudCusto2
            // 
            nudCusto2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudCusto2.Location = new Point(79, 104);
            nudCusto2.Name = "nudCusto2";
            nudCusto2.Size = new Size(62, 23);
            nudCusto2.TabIndex = 33;
            // 
            // nudTempo2
            // 
            nudTempo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudTempo2.Location = new Point(237, 69);
            nudTempo2.Name = "nudTempo2";
            nudTempo2.Size = new Size(62, 23);
            nudTempo2.TabIndex = 32;
            // 
            // nudDistancia2
            // 
            nudDistancia2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudDistancia2.Location = new Point(79, 69);
            nudDistancia2.Name = "nudDistancia2";
            nudDistancia2.Size = new Size(62, 23);
            nudDistancia2.TabIndex = 25;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(173, 71);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 31;
            label12.Text = "Tempo:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(15, 106);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 30;
            label13.Text = "Custo:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(15, 71);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 29;
            label14.Text = "Distância:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(120, 33);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(0, 23);
            comboBox3.TabIndex = 28;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(172, 15);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 27;
            label15.Text = "Destino:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(15, 15);
            label16.Name = "label16";
            label16.Size = new Size(50, 15);
            label16.TabIndex = 26;
            label16.Text = "Origem:";
            // 
            // frmMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 716);
            Controls.Add(tbCidades);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(pcMapa);
            Controls.Add(toolStrip1);
            Name = "frmMapa";
            Text = "Mapeamento de cidades";
            Load += frmMapa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCoordenadaY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCoordenadaX).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcMapa).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbCidades.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCusto2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTempo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lsbArquivo;
        private NumericUpDown nudCoordenadaY;
        private Label label4;
        private NumericUpDown nudCoordenadaX;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private PictureBox pcMapa;
        private OpenFileDialog dlgAbrir;
        private ToolStripButton btnInicio;
        private ToolStripButton btnAnterior;
        private ToolStripButton btnProximo;
        private ToolStripButton btnUltimo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnProcurar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnNovo;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnSalvar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnSair;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private OpenFileDialog dlgSalvar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn c1;
        private DataGridViewTextBoxColumn c2;
        private DataGridViewTextBoxColumn c3;
        private DataGridViewTextBoxColumn c4;
        private DataGridViewTextBoxColumn c5;
        private DataGridViewTextBoxColumn c6;
        private DataGridViewTextBoxColumn c7;
        private Label label1;
        private Label label11;
        private TabControl tbCidades;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cbDestino2;
        private ComboBox cbOrigem2;
        private NumericUpDown nudCusto2;
        private NumericUpDown nudTempo2;
        private NumericUpDown nudDistancia2;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox comboBox3;
        private Label label15;
        private Label label16;
        private Label label17;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn c8;
        private Button btnAcharCaminho;
    }
}