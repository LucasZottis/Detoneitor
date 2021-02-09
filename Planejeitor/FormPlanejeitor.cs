using Microsoft.Win32.TaskScheduler;
using Detoneitor.Planejeitor.Modelo.Entidades;
using System;
using System.Windows.Forms;

namespace Detoneitor.Planejeitor {
    public partial class FormPlanejeitor : Form {
        private Configuracao _arquivoConfiguracao;
        private string _descricao;
        private string _caminhoExecuteitor;
        private bool _debug = false;

        public FormPlanejeitor() {
            InitializeComponent();
            _arquivoConfiguracao = new Configuracao();
#if (DEBUG)
            _debug = true;
#endif
            if (_debug) _caminhoExecuteitor = Environment.GetCommandLineArgs()[0];
            else _caminhoExecuteitor = Environment.CurrentDirectory + @"\Executeitor.exe";

            _descricao = $"Limpar a pasta {_arquivoConfiguracao.CaminhoPasta}";
        }

        private void FormPlanejeitor_Load(object sender, EventArgs e) {
            txtDia.Text = _arquivoConfiguracao.Dia;
            TxtCaminhoPasta.Text = _arquivoConfiguracao.CaminhoPasta;
        }
        private void BtnBuscarPasta_Click(object sender, EventArgs e) {
            DialogResult resultado = fbdPasta.ShowDialog();
            if (resultado == DialogResult.OK || resultado == DialogResult.Yes) {
                TxtCaminhoPasta.Text = fbdPasta.SelectedPath;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e) {
            try {
                _arquivoConfiguracao.AlterarDia(txtDia.Text);
                _arquivoConfiguracao.AlterarCaminhoPasta(TxtCaminhoPasta.Text);
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Planejêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            try {
                MonthlyTrigger gatilho = new MonthlyTrigger(int.Parse(txtDia.Text), MonthsOfTheYear.AllMonths);
                TaskDefinition tarefa = TaskService.Instance.NewTask();

                tarefa.RegistrationInfo.Description = _descricao;
                tarefa.Triggers.Add(gatilho);
                tarefa.Actions.Add(_caminhoExecuteitor);

                TaskService.Instance.RootFolder.RegisterTaskDefinition("Detonêitor", tarefa);

                MessageBox.Show("Concluído!", ".:: Planejêitor ::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Planejêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
