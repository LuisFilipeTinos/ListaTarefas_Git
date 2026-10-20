namespace IntroWinForms
{
    // Esta parte da classe Form1 é "gerada pelo designer".
    // No Visual Studio, ela é montada automaticamente quando você
    // arrasta controles da Toolbox para o formulário.
    // Aqui, ela está escrita manualmente para fins didáticos.
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // --- Declaração dos controles (os "objetos visuais") ---
        private Label lblTitulo;
        private Label lblNovaTarefa;
        private TextBox txtNovaTarefa;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnLimparConcluidas;
        private ListBox lstTarefas;
        private CheckBox chkMostrarConcluidas;
        private Label lblContador;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;

        // Método que monta o layout: posição, tamanho e propriedades de cada controle
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            lblNovaTarefa = new Label();
            txtNovaTarefa = new TextBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnLimparConcluidas = new Button();
            lstTarefas = new ListBox();
            chkMostrarConcluidas = new CheckBox();
            lblContador = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnConcluido = new Button();
            pictureBox1 = new PictureBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 25);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Minhas Tarefas";
            // 
            // lblNovaTarefa
            // 
            lblNovaTarefa.AutoSize = true;
            lblNovaTarefa.Location = new Point(20, 65);
            lblNovaTarefa.Name = "lblNovaTarefa";
            lblNovaTarefa.Size = new Size(71, 15);
            lblNovaTarefa.TabIndex = 8;
            lblNovaTarefa.Text = "Nova tarefa:";
            // 
            // txtNovaTarefa
            // 
            txtNovaTarefa.Location = new Point(20, 85);
            txtNovaTarefa.Name = "txtNovaTarefa";
            txtNovaTarefa.PlaceholderText = "Digite uma tarefa e pressione Enter...";
            txtNovaTarefa.Size = new Size(260, 23);
            txtNovaTarefa.TabIndex = 7;
            txtNovaTarefa.KeyDown += TxtNovaTarefaKeyDown;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(290, 84);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(90, 25);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += BtnAdicionarClick;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(171, 325);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(85, 25);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += BtnRemoverClick;
            // 
            // btnLimparConcluidas
            // 
            btnLimparConcluidas.Location = new Point(295, 355);
            btnLimparConcluidas.Name = "btnLimparConcluidas";
            btnLimparConcluidas.Size = new Size(85, 25);
            btnLimparConcluidas.TabIndex = 3;
            btnLimparConcluidas.Text = "Limpar ✓";
            btnLimparConcluidas.UseVisualStyleBackColor = true;
            btnLimparConcluidas.Click += BtnLimparConcluidasClick;
            // 
            // lstTarefas
            // 
            lstTarefas.FormattingEnabled = true;
            lstTarefas.Location = new Point(20, 120);
            lstTarefas.Name = "lstTarefas";
            lstTarefas.Size = new Size(360, 199);
            lstTarefas.TabIndex = 5;
            // 
            // chkMostrarConcluidas
            // 
            chkMostrarConcluidas.AutoSize = true;
            chkMostrarConcluidas.Checked = true;
            chkMostrarConcluidas.CheckState = CheckState.Checked;
            chkMostrarConcluidas.Location = new Point(20, 330);
            chkMostrarConcluidas.Name = "chkMostrarConcluidas";
            chkMostrarConcluidas.Size = new Size(127, 19);
            chkMostrarConcluidas.TabIndex = 2;
            chkMostrarConcluidas.Text = "Mostrar concluídas";
            chkMostrarConcluidas.UseVisualStyleBackColor = true;
            chkMostrarConcluidas.CheckedChanged += ChkMostrarConcluidasCheckedChanged;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.ForeColor = SystemColors.GrayText;
            lblContador.Location = new Point(20, 360);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(95, 15);
            lblContador.TabIndex = 1;
            lblContador.Text = "0 tarefas no total";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 389);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(400, 22);
            statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(43, 17);
            toolStripStatusLabel1.Text = "Pronto";
            // 
            // btnConcluido
            // 
            btnConcluido.Location = new Point(261, 325);
            btnConcluido.Name = "btnConcluido";
            btnConcluido.Size = new Size(118, 25);
            btnConcluido.TabIndex = 10;
            btnConcluido.Text = "Marcar Concluído";
            btnConcluido.UseVisualStyleBackColor = true;
            btnConcluido.Click += BtnConcluidoClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(295, 15);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 411);
            Controls.Add(pictureBox1);
            Controls.Add(btnConcluido);
            Controls.Add(statusStrip1);
            Controls.Add(lblContador);
            Controls.Add(chkMostrarConcluidas);
            Controls.Add(btnLimparConcluidas);
            Controls.Add(btnRemover);
            Controls.Add(lstTarefas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNovaTarefa);
            Controls.Add(lblNovaTarefa);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Introdução ao Windows Forms - Lista de Tarefas";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnConcluido;
        private PictureBox pictureBox1;
    }
}
