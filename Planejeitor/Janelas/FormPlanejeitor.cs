using BibliotecaPublica.Classes.Estaticas;
using Microsoft.Win32.TaskScheduler;
using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using BibliotecaPublica.Classes.Gerenciadores;
using System.ComponentModel;

namespace Detoneitor.Planejeitor.Janelas {
    public partial class FormPlanejeitor : Form {
        #region Propriedades e Atributos

        private bool _bLetra = false;

        private string _sCaminhoExecuteitor;
        private string _sDescricaoTarefa;

        public string Dia { private get; set; }
        public string CaminhoPasta { private get; set; }

        #endregion

        #region Construtores

        public FormPlanejeitor()
        {
            InitializeComponent();

            _sCaminhoExecuteitor = Environment.CurrentDirectory + @"\Executeitor.exe";
#if (DEBUG)
            _sCaminhoExecuteitor = Environment.GetCommandLineArgs()[0];
#endif
            _sDescricaoTarefa = $"Limpar a pasta {CaminhoPasta}";
        }

        #endregion

        #region Métodos Privados

        public void ConfigurarTarefa()
        {
            MonthlyTrigger gatilho = new MonthlyTrigger(int.Parse(txtDia.Text), MonthsOfTheYear.AllMonths);
            TaskDefinition tarefa = TaskService.Instance.NewTask();

            tarefa.RegistrationInfo.Description = _sDescricaoTarefa;
            tarefa.Triggers.Add(gatilho);
            tarefa.Actions.Add(_sCaminhoExecuteitor);

            TaskService.Instance.RootFolder.RegisterTaskDefinition("Detonêitor", tarefa);
        }

        #endregion

        #region Eventos de formulário

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
            txtCaminhoPasta.Text = CaminhoPasta;
        }

        #endregion

        #region Eventos de Button

        private void BtnBuscarPasta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = fbdPasta.ShowDialog();

            if (resultado == DialogResult.OK || resultado == DialogResult.Yes)
                txtCaminhoPasta.Text = fbdPasta.SelectedPath;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                GerenciadorConfiguracao configurador = new GerenciadorConfiguracao();

                if (Verificadores.TemConteudo(txtDia.Text))
                    configurador.AlterarConfiguracao(Program._sChaveDia, txtDia.Text);

                if (Verificadores.TemConteudo(txtCaminhoPasta.Text))
                    configurador.AlterarConfiguracao(Program._sChaveCaminhoPasta, txtCaminhoPasta.Text);

                configurador.SalvarArquivoAlterado();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, ".:: Planejêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                ConfigurarTarefa();
                MessageBox.Show("Concluído!", ".:: Planejêitor ::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, ".:: Planejêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos de TextBox

        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Apenas números!", ".:: Planejêitor ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _bLetra = true;
            }
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {
            if (_bLetra) txtDia.Clear();
            _bLetra = false;
        }

        private void txtDia_Validating(object sender, CancelEventArgs e)
        {
            if (txtDia.Text.ParaInt() < 1 || txtDia.Text.ParaInt() > 31)
            {
                MessageBox.Show("Dia informado não existe!", ".:: Planejêitor ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDia.Clear();
                txtDia.Focus();
            }
        }

        private void txtCaminhoPasta_Validating(object sender, CancelEventArgs e)
        {
            if (!Directory.Exists(txtCaminhoPasta.Text) && Verificadores.TemConteudo(txtCaminhoPasta.Text))
            {
                MessageBox.Show("Pasta informada não existe!", ".:: Planejêitor ::.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCaminhoPasta.Clear();
            }
        }

        #endregion
    }
}