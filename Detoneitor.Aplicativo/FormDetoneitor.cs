using Microsoft.Win32.TaskScheduler;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Detoneitor.Aplicativo {
    public partial class FormDetoneitor : Form {
        private static readonly string _planejeitor = @"\Planejeitor.exe";
        private static readonly string _executeitor = @"\Executeitor.exe";
        private string _pastaRaiz;
        private string _pastaAlvo;
        private bool _debug = false;
        private Configuration _arquivoConfiguracao;

        public FormDetoneitor() {
            InitializeComponent();

#if (DEBUG)
            _debug = true;
#endif
            if (_debug) _pastaRaiz = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            else _pastaRaiz = Environment.CurrentDirectory;

            try {
                _arquivoConfiguracao = ConfigurationManager.OpenExeConfiguration(_pastaRaiz + _planejeitor);
                _pastaAlvo = _arquivoConfiguracao.AppSettings.Settings["CaminhoPasta"].Value;
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Detonêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDetoneitor_Load(object sender, EventArgs e) {
            try {
                long somaTamanhoArquivos = 0;
                double tamanhoPasta = 0;

                using (TaskService tarefaServico = new TaskService()) {
                    Task tarefa = tarefaServico.FindTask("Detonêitor");
                    
                    switch (tarefa.State) {
                        case TaskState.Unknown: lblEstadoTarefa.Text = "Desconhecido"; break;
                        case TaskState.Disabled: lblEstadoTarefa.Text = "Desabilitado"; break;
                        case TaskState.Running: lblEstadoTarefa.Text = "Rodando"; break;
                        case TaskState.Ready: lblEstadoTarefa.Text = "Pronto"; break;
                    }
                }

                FileInfo[] arquivos = new DirectoryInfo(_pastaAlvo).GetFiles();
                foreach (FileInfo arquivo in arquivos) {
                    somaTamanhoArquivos += arquivo.Length;
                }

                tamanhoPasta = somaTamanhoArquivos / 1048576;

                
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Detonêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlanejeitor_Click(object sender, EventArgs e) {
            try {
                Process.Start(_pastaRaiz + _planejeitor);
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Detonêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExecuteitor_Click(object sender, EventArgs e) {
            try {
                Process.Start(_pastaRaiz + _executeitor);
            } catch (Exception erro) {
                MessageBox.Show(erro.Message, ".:: Detonêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
