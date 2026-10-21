namespace IntroWinForms
{
    public partial class Form1 : Form
    {
        private List<Tarefa> tarefas = new List<Tarefa>();

        public Form1()
        {
            InitializeComponent(); // monta o layout definido no Form1.Designer.cs
        }

        private void BtnAdicionarClick(object sender, EventArgs e)
        {
            AdicionarTarefa();
        }

        private void AdicionarTarefa()
        {
            string descricao = txtNovaTarefa.Text.Trim();

            if (string.IsNullOrEmpty(descricao))
            {
                toolStripStatusLabel1.Text =
                    "Digite uma descrição antes de adicionar";
                return;
            }

            Tarefa novaTarefa = new Tarefa();
            novaTarefa.SetDescricao(descricao);
            tarefas.Add(novaTarefa);

            txtNovaTarefa.Clear();
            txtNovaTarefa.Focus();
            toolStripStatusLabel1.Text = "Tarefa adicionada!";

            //Atualizar a listagem visual:
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lstTarefas.Items.Clear();

            List<Tarefa> visiveis;

            if (chkMostrarConcluidas.Checked)
            {
                visiveis = tarefas;
            }
            else
            {
                visiveis = tarefas.Where(t => !t.GetConcluida()).ToList();
            }

            foreach (Tarefa tarefa in visiveis)
            {
                lstTarefas.Items.Add(tarefa);
            }

            AtualizarContador();
        }

        private void TxtNovaTarefaKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdicionarTarefa();
            }
        }

        private void AtualizarContador()
        {
            int total = tarefas.Count;
            int concluidas = tarefas.Count(t => t.GetConcluida() == true);
            lblContador.Text =
                $"{total} tarefa(s) no total - {concluidas} concluída(s)";
        }

        private void BtnConcluidoClick(object sender, EventArgs e)
        {
            if (lstTarefas.SelectedIndex == -1)
            {
                MessageBox.Show(
                        "Selecione uma tarefa na lista para marcar como concluída",
                        "Nenhuma tarefa selecionada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                return;
            }

            Tarefa? tarefaSelecionada = (Tarefa?)lstTarefas.SelectedItem;

            if (tarefaSelecionada != null)
            {
                tarefaSelecionada.SetConcluida(true);
            }

            AtualizarLista();
        }

        private void BtnLimparConcluidasClick(object sender, EventArgs e)
        {
            int removidas = tarefas.RemoveAll(t => t.GetConcluida());

            if (removidas > 0)
            {
                toolStripStatusLabel1.Text =
                    $"{removidas} tarefa(s) concluída(s) removida(s).";
            }
            else
            {
                toolStripStatusLabel1.Text =
                    "Nenhuma tarefa concluída para remover.";
            }

            AtualizarLista();
        }

        private void BtnRemoverClick(object sender, EventArgs e)
        {
            if (lstTarefas.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione uma tarefa na lista para remover",
                    "Nenhuma tarefa selecionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Tarefa? tarefaSelecionada = (Tarefa?)lstTarefas.SelectedItem;

            if (tarefaSelecionada != null)
            {
                tarefas.Remove(tarefaSelecionada);
            }

            AtualizarLista();
        }

        private void ChkMostrarConcluidasCheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
            // Teste de versionamento
            // Teste de outro branch
        }
    }
}
