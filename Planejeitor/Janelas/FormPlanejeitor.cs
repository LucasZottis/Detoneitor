using Microsoft.Win32.TaskScheduler;
using System;
using System.Windows.Forms;
using System.IO;
using BibliotecaPublica.Classes.Estaticas;
using System.Text;

namespace Detoneitor.Planejeitor.Janelas {
    public partial class FormPlanejeitor : Form {
        #region Propriedades e Atributos

        private string _sCaminhoExecuteitor;
        private string _sDescricaoTarefa;

        public string Dia { private get; set; }
        public string CaminhoPasta { private get; set; }

        #endregion

        public FormPlanejeitor()
        {
            InitializeComponent();

            _sCaminhoExecuteitor = Environment.CurrentDirectory + @"\Executeitor.exe";
#if (DEBUG)
            _sCaminhoExecuteitor = Environment.GetCommandLineArgs()[0];
#endif
            _sDescricaoTarefa = $"Limpar a pasta {CaminhoPasta}";
        }

        private void FormPlanejeitor_Load(object sender, EventArgs e)
        {
            StringBuilder sbMensagem = new StringBuilder();

            // Verifica se é um dia do mês válido.
            if (Dia.ParaInt() < 1 || Dia.ParaInt() > 31) sbMensagem.AppendLine(" - Dia informado é inválido!");

            // Verifica se a pasta existe.
            if (Directory.Exists(CaminhoPasta) == false) sbMensagem.AppendLine(" - Caminho informado não existe!");

            // Verifica se a mensagem tem algum conteúdo, caso tenha, irá aprensentar a mensagem em tela.
            if (Verificadores.TemConteudo(sbMensagem))
                MessageBox.Show(sbMensagem.ToString(), ".:: Planejêitor ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txtDia.Text = Dia;
            TxtCaminhoPasta.Text = CaminhoPasta;
        }

        private void BtnBuscarPasta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = fbdPasta.ShowDialog();
            if (resultado == DialogResult.OK || resultado == DialogResult.Yes)
            {
                TxtCaminhoPasta.Text = fbdPasta.SelectedPath;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _arquivoConfiguracao.AlterarDia(txtDia.Text);
                _arquivoConfiguracao.AlterarCaminhoPasta(TxtCaminhoPasta.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, ".:: Planejêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MonthlyTrigger gatilho = new MonthlyTrigger(int.Parse(txtDia.Text), MonthsOfTheYear.AllMonths);
                TaskDefinition tarefa = TaskService.Instance.NewTask();

                tarefa.RegistrationInfo.Description = _sDescricaoTarefa;
                tarefa.Triggers.Add(gatilho);
                tarefa.Actions.Add(_sCaminhoExecuteitor);

                TaskService.Instance.RootFolder.RegisterTaskDefinition("Detonêitor", tarefa);

                MessageBox.Show("Concluído!", ".:: Planejêitor ::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, ".:: Planejêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
