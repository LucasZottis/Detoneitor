using Microsoft.Win32.TaskScheduler;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Detoneitor.Aplicativo.Janelas {
    public partial class FormDetoneitor : Form {
        #region Propriedades e Atributos

        public string PastaRaiz { private get; set; }
        public string PastaAlvo { private get; set; }

        #endregion

        #region Construtores

        public FormDetoneitor()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos Privados

        private void VerificarTarefa()
        {
            using (TaskService tarefaServico = new TaskService())
            {
                Task tarefa = tarefaServico.FindTask("Detonêitor");
                switch (tarefa.State)
                {
                    case TaskState.Unknown: lblEstadoTarefa.Text = "Desconhecido"; break;
                    case TaskState.Disabled: lblEstadoTarefa.Text = "Desabilitado"; break;
                    case TaskState.Running: lblEstadoTarefa.Text = "Rodando"; break;
                    case TaskState.Ready: lblEstadoTarefa.Text = "Pronto"; break;
                }
            }
        }

        private void VerificarTamanhoPastaAlvo()
        {
            long somaTamanhoArquivos = 0;
            double tamanhoPasta = 0;
            FileInfo[] arquivos = new DirectoryInfo(PastaAlvo).GetFiles();

            foreach (FileInfo arquivo in arquivos)
                somaTamanhoArquivos += arquivo.Length;

            tamanhoPasta = somaTamanhoArquivos / 1048576;

            lblTamanhoPastaAlvo.Text = tamanhoPasta + " MB";
        }

        #endregion

        #region Evento de formulário
        
        private void FormDetoneitor_Load(object sender, EventArgs e)
        {
            try
            {
                VerificarTarefa();
                VerificarTamanhoPastaAlvo();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, ".:: Detonêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos de Button

        private void btnPlanejeitor_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(PastaRaiz + Program.Planejeitor);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, ".:: Detonêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExecuteitor_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(PastaRaiz + Program.Executeitor);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, ".:: Detonêitor ::. | Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
