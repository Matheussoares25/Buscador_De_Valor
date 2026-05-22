using OfficeOpenXml;
using Ookii.Dialogs.WinForms;

namespace BuscadorMoedaInterface
{

    public partial class Form1 : Form
    {

        private string moedaAtual = "";
     
            public Form1()
            {
                InitializeComponent();

                ExcelPackage.License.SetNonCommercialPersonal("Matheus");

                progressBar1.Visible = false;
                limpaTabelas.Enabled = false;
                txtProgresso.Visible = false;
                botaoSalva.Enabled = false;
                dataGridView2.Visible = false;


            }




            private void label1_Click(object sender, EventArgs e)
            {

            }

            private async void Buscar_Click(object sender, EventArgs e)
            {
                try
                {
                    


                    string moeda = "USD";
                    moedaAtual = "USD";


                    var resposta = await consultar(moeda);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Feche o arquivo excel e tente novamente");
                }
            }



            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

            private void dtFIM_ValueChanged(object sender, EventArgs e)
            {

            }



            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void TipoMoeda_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
            {

            }

            private async Task<string> consultar(string moeda)
            {
                try
                {
                
                progressBar1.Visible = true;
                txtProgresso.Visible = true;
                progressBar1.Value = 15;
                

               

                    var service = new CotacaoService();
                    var cotacao = new Cotacao();

                    DateTime inicio = DateTime.Now.AddDays(-5);
                    DateTime fim = DateTime.Now;
              

                    cotacao.inicio = inicio;
                    cotacao.fim = fim;
                    cotacao.moeda = moeda;

                    var confirmacao = MessageBox.Show("Periodo da Consulta: de" +
                        inicio.ToString("\ndd/MM/yyyy") + " até " + fim.ToString("dd/MM/yyyy") +
                        "\nDeseja continuar?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );



                    if (confirmacao == DialogResult.No)
                    {
                        MessageBox.Show("Operação cancelada!");

                    progressBar1.Visible = false;
                    txtProgresso.Visible = false;

                    return "canceled";

                    
                }


                dataGridView2.Visible = false;
                switch (moeda)
                {
                    case "USD":
                        atualMoeda.Clear();
                        atualMoeda.Text = "Dólar"; break;
                    case "EUR":
                        atualMoeda.Clear();
                        atualMoeda.Text += "Euro"; break;
                }

                progressBar1.Value = 55;
                var dados = await service.BuscarCotacoes(cotacao);
                progressBar1.Value = 85;
                if (dados.lista == null || dados.lista.Count == 0)
                    {
                        MessageBox.Show("Nenhum dado encontrado!");
                        return "Notdados";
                    }

                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();


                foreach (var item in dados.lista)
                    {
                        dataGridView1.Rows.Add(DateTime.Parse(item[0]).ToString("dd/MM/yyyy"), item[1], item[2]);
                    }

                progressBar1.Value = 95;

                //Essa versao é a media sem arredondar
                //dataGridView2.Rows.Add(decimal.Round(dados.media, 4, MidpointRounding.ToZero));

                dataGridView2.Rows.Add(dados.media.ToString("F4"));

                limpaTabelas.Enabled = true;
                    botaoSalva.Enabled = true;
                    dataGridView2.Visible = true;

                await Task.Delay(800);
                progressBar1.Value = 100;
                progressBar1.Visible = false;
                txtProgresso.Visible = false;

                return "true";

                }
                catch (Exception ex)
                {
                    return "error";
                }
            }

            public async Task<string> execute(string moeda)
            {

                try
                {
                progressBar1.Visible = true;
                progressBar1.Value = 15;
                txtProgresso.Visible=true;


                var caminhoDoCampo = caminhoSelecionado.Text.Trim();



                    var service = new CotacaoService();
                    var gerarExcel = new Excel();

                var cotacao = new Cotacao
                {
                    inicio = DateTime.Now.AddDays(-5),
                    fim = DateTime.Now,
                    moeda = moedaAtual
                };
                progressBar1.Value = 35;

               


                     var dados = await service.BuscarCotacoes(cotacao);

                progressBar1.Value = 65;

                     gerarExcel.ProcessarExcel(dados.lista, moeda, caminhoDoCampo);

                    var openExcel = MessageBox.Show(" Deseja abrir o aquivo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                progressBar1.Value = 100;


                    if (openExcel == DialogResult.Yes)
                    {

                        string caminho = Path.Combine(caminhoDoCampo, "Cotações.xlsx");

                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {

                            FileName = caminho,
                            UseShellExecute = true
                        });
                        await Task.Delay(500);
                       
                        progressBar1.Visible = false;
                        txtProgresso.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("O arquivo foi gerado e salvo em:" + caminhoDoCampo);
                        await Task.Delay(500);
                       
                        progressBar1.Visible = false;
                        txtProgresso.Visible = false;
                    }




                    if (dataGridView1.Rows.Count != 1 || dataGridView2.Rows.Count != 1)
                    {
                        limpaTabelas.Enabled = true;

                    }

                    return "success";
                }
                catch (IOException)
                {
                    MessageBox.Show(" Feche o Excel antes de continuar!");
                    return "error";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Feche o Excel antes de continuar!");
                    return "error";
                }
            }

            private async void btEuro_Click(object sender, EventArgs e)
            {
                try
                {
                    


                    string moeda = "EUR";
                    moedaAtual = "EUR";

                    var resposta = await consultar(moeda);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
            {

            }

            private void label1_Click_1(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {

                VistaFolderBrowserDialog pasta = new VistaFolderBrowserDialog();

                pasta.Description = "Escolha uma pasta";

                if (pasta.ShowDialog() == DialogResult.OK)
                {
                    caminhoSelecionado.Text = pasta.SelectedPath;

                    Settings1.Default.caminhoPasta = pasta.SelectedPath;
                    Settings1.Default.Save();
                }
            }

            private void caminhoSelecionado_TextChanged(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

                caminhoSelecionado.Text = Settings1.Default.caminhoPasta;

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void label1_Click_2(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {


                var confirmacao = MessageBox.Show("\nDeseja prosseguir com a limpeza?", "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirmacao != DialogResult.No)
                {

                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();
                    

                    atualMoeda.Clear();

                    limpaTabelas.Enabled = false;
                    dataGridView2.Visible = false;
                    botaoSalva.Enabled = false;



                }


            }

            private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
            {

            }

            private void pictureBox1_Click_1(object sender, EventArgs e)
            {

            }

            private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private async void button2_Click_1(object sender, EventArgs e)
            {

            if (caminhoSelecionado.Text == "")
            {
                MessageBox.Show("Antes de prosseguir, selecione o caminho desejado!");
                return;

            }
            var confirmacao = MessageBox.Show("\nDeseja Gerar o Arquivo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            var gerarExcel = new Excel();
            var variavelEnvia = moedaAtual;

                if (confirmacao == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada");
                }
                else
                {
                var res =  await execute(variavelEnvia);
                    

                }




            }
        
    }
}
