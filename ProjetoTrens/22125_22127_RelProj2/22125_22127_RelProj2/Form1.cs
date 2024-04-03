using System.Windows.Forms;

//Eloisa Paixão de Oliveira - 22127
//Eduarda Graziele de Paiva - 22125

namespace _22125_22127_RelProj2
{
    public partial class frmMapa : Form
    {
        public frmMapa()
        {
            InitializeComponent();
        }

        Cidade cidade = new Cidade();
        ListaDupla<Cidade> listaDupla = new ListaDupla<Cidade>();

        ListaDupla<Ligacoes> listaDuplaCaminho;
        int indexOrigem;
        int indexDestino;
        GrafoBackTracking<Ligacoes> oGrafoDestinoOrigem;
        Cidade[] cidadeArray;

        private void frmMapa_Load(object sender, EventArgs e)
        {

            nudCoordenadaX.DecimalPlaces = 3;
            nudCoordenadaY.DecimalPlaces = 3;

            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listaDupla.LerDados(dlgAbrir.FileName);
                    listaDupla.ExibirDados(lsbArquivo);
                    cidadeArray = new Cidade[listaDupla.Tamanho];
                    
                }
                catch (IOException)
                {
                    Console.WriteLine("Erro de leitura no arquivo");
                }
            }

            listaDupla.PosicionarNoPrimeiro();
            while (listaDupla.DadoAtual() != null)
            {

                for (int i = 0; i < listaDupla.Tamanho; i++)
                {
                    cidadeArray[i] = listaDupla.DadoAtual();
                }

                listaDupla.AvancarPosicao();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            nudCoordenadaX.Value = 0;
            nudCoordenadaY.Value = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dlgSalvar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listaDupla.GravarDados(dlgSalvar.FileName);

                }
                catch (IOException)
                {
                    Console.WriteLine("Erro de leitura no arquivo");
                }
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            listaDupla.PosicionarNoPrimeiro();
            cidade = listaDupla.DadoAtual();
            txtNome.Text = cidade.Nome.ToString();
            nudCoordenadaX.Value = cidade.X;
            nudCoordenadaY.Value = cidade.Y;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            listaDupla.RetrocederPosicao();
            cidade = listaDupla.DadoAtual();
            txtNome.Text = cidade.Nome.ToString();
            nudCoordenadaX.Value = cidade.X;
            nudCoordenadaY.Value = cidade.Y;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            listaDupla.AvancarPosicao();
            cidade = listaDupla.DadoAtual();
            txtNome.Text = cidade.Nome.ToString();
            nudCoordenadaX.Value = cidade.X;
            nudCoordenadaY.Value = cidade.Y;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            listaDupla.PosicionarNoUltimo();
            cidade = listaDupla.DadoAtual();
            txtNome.Text = cidade.Nome.ToString();
            nudCoordenadaX.Value = cidade.X;
            nudCoordenadaY.Value = cidade.Y;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.PadRight(15, ' ');

            if (listaDupla.Existe(new Cidade(nome, 0, 0), out int posicao))
            {
                txtNome.Text = listaDupla.DadoAtual().Nome;
                nudCoordenadaX.Value = listaDupla.DadoAtual().X;
                nudCoordenadaY.Value = listaDupla.DadoAtual().Y;
            }
            else
            {
                MessageBox.Show("Cidade não localizada");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal x = nudCoordenadaX.Value;
            decimal y = nudCoordenadaY.Value;

            if (nome == "" || x == 0 || y == 0)
                MessageBox.Show("Dados inválidos para inclusão de nova cidade!");

            else
            {
                Cidade cidade = new Cidade(nome, x, y);

                if (!listaDupla.Existe(cidade, out _))
                {
                    // a inserimos na árvore
                    listaDupla.Incluir(cidade);
                    MessageBox.Show("Cidade incluída com sucesso!");
                    LimparCampos();
                    listaDupla.ExibirDados(lsbArquivo);
                    pcMapa.Invalidate();
                }

                else
                    MessageBox.Show("Cidade já existente!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && nudCoordenadaX.Value != 0 && nudCoordenadaY.Value != 0)
            {
                Cidade cidadeAExcluir = new Cidade(txtNome.Text, nudCoordenadaX.Value, nudCoordenadaY.Value);
                bool excluiu = listaDupla.Excluir(cidadeAExcluir);
                if (excluiu)
                {
                    txtNome.Text = "";
                    nudCoordenadaX.Value = 0;
                    nudCoordenadaY.Value = 0;
                    MessageBox.Show("Excluido com sucesso");
                    listaDupla.ExibirDados(lsbArquivo);
                    pcMapa.Invalidate();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir!");
                }
            }
            else
                MessageBox.Show("Verifique as informações!");
        }

        private void pcMapa_Paint(object sender, PaintEventArgs e)
        {
            Percorrer(listaDupla.Primeiro); // Inicia o percurso a partir do primeiro nó

            void Percorrer(NoDuplo<Cidade> no)
            {
                if (no == null)
                    return;

                Cidade c = no.Info;

                int x = (int)(c.X * pcMapa.Width);
                int y = (int)(c.Y * pcMapa.Height);

                // A cidade selecionada fica em destaque na cor vermelha, as demais
                // permanecem na cor preta
                Brush brush = Brushes.Black;

                e.Graphics.FillEllipse(brush, new Rectangle(x, y, 6, 6));

                e.Graphics.DrawString(
                    c.Nome,
                    new Font("Arial", 10),
                    brush,
                    x - c.Nome.Length * 2 - 10,
                    y - 15
                );

                Percorrer(no.Prox); // Chama o método recursivamente para percorrer os próximos nós
            }
        }

        public void LimparCampos()
        {
            txtNome.Text = "";
            nudCoordenadaX.Value = 0;
            nudCoordenadaY.Value = 0;
        }

        private void btnAcharCaminho_Click(object sender, EventArgs e)
        {
            var nomeOrigem = cbOrigem2.SelectedItem.ToString();
            var dadoProcurado(new Cidade(nomeOrigem, 0, 0);
            listaDupla.Existe(dadoProcurado, out indexOrigem)

            var nomeDestino = cbOrigem2.SelectedItem.ToString()
            var dadoProcurado(new Cidade(nomeDestino, 0, 0);
            listaDupla.Existe(dadoProcurado, out indexOrigem);


            if (indexDestino != 0 && indexOrigem != null)
            {
                int origem = indexOrigem;
                int destino = indexDestino;

                listaDuplaCaminho.PosicionarNoPrimeiro();

                oGrafoDestinoOrigem = new GrafoBackTracking<Ligacao>(listaDupla, listaDuplaCaminho);
                var pilhaCaminho = oGrafoDestinoOrigem.BuscarCaminho(origem, destino, listaDuplaCaminho);

                if (pilhaCaminho.Count == 0)
                {
                    dgvCaminhosEncontrados.Rows.Clear();
                    MessageBox.Show("Nenhum caminho foi encontrado!");
                }
                else
                {
                    dgvCaminhosEncontrados.Rows.Clear();
                    dgvCaminhosEncontrados.RowCount = pilhaCaminho.Count;

                    int linha = 0;

                    foreach (PilhaLista<Movimento> caminho in pilhaCaminho)
                    {
                        int celula = 0;
                        string destinoDgv = "";
                        int contador = 0;

                        foreach (Movimento movimento in caminho.DadosDaPilha())
                        {
                            listaDuplaCidade.PosicionarEm(movimento.Origem);

                            dgvCaminhosEncontrados.Rows[linha].Cells[celula++].Value = listaDuplaCidade.DadoAtual().Nome;

                            // Mostrar a última cidade

                            contador++;
                            if (contador == caminho.Tamanho)
                            {
                                listaDuplaCidade.PosicionarEm(movimento.Destino);
                                destinoDgv = listaDuplaCidade.DadoAtual().Nome;
                            }
                        }

                        dgvCaminhosEncontrados.Rows[linha].Cells[celula++].Value = destinoDgv;

                        linha++;

                        // Não funciona
                        //oGrafoDestinoOrigem.BuscarMelhorCaminho(caminho, listaDuplaCaminho);
                    }

                    // Foreach que seria usado para mostrar o melhor caminho.
                    foreach (Movimento movimento in oGrafoDestinoOrigem.MelhorCaminho)
                    {
                        linha = 0;
                        listaDuplaCidade.PosicionarEm(movimento.Origem);
                        dgvMelhorCaminho.Rows[linha++].Cells[0].Value = listaDuplaCidade.DadoAtual().Nome;
                    }

                }
            }
            else
            {
                MessageBox.Show("Clique em alguma cidade para origem ou destino!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}