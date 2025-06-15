namespace CRUD
{
    partial class Form1
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
            dgvUsuarios = new DataGridView();
            txtNome = new TextBox();
            txtSobreNome = new TextBox();
            lblNome = new Label();
            lblSobrenome = new Label();
            txtUsuarioId = new TextBox();
            btnGravar = new Button();
            btnListar = new Button();
            btnApagar = new Button();
            btnNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 115);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(659, 169);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(241, 27);
            txtNome.TabIndex = 1;
            // 
            // txtSobreNome
            // 
            txtSobreNome.Location = new Point(376, 41);
            txtSobreNome.Name = "txtSobreNome";
            txtSobreNome.Size = new Size(295, 27);
            txtSobreNome.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 18);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(376, 18);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(89, 20);
            lblSobrenome.TabIndex = 4;
            lblSobrenome.Text = "SobreNome";
            // 
            // txtUsuarioId
            // 
            txtUsuarioId.Location = new Point(94, 15);
            txtUsuarioId.Name = "txtUsuarioId";
            txtUsuarioId.Size = new Size(45, 27);
            txtUsuarioId.TabIndex = 5;
            txtUsuarioId.Visible = false;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(544, 290);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(127, 29);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(411, 290);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(127, 29);
            btnListar.TabIndex = 7;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(12, 290);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(127, 29);
            btnApagar.TabIndex = 8;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(544, 74);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(127, 29);
            btnNovo.TabIndex = 9;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 331);
            Controls.Add(btnNovo);
            Controls.Add(btnApagar);
            Controls.Add(btnListar);
            Controls.Add(btnGravar);
            Controls.Add(txtUsuarioId);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            Controls.Add(txtSobreNome);
            Controls.Add(txtNome);
            Controls.Add(dgvUsuarios);
            Name = "Form1";
            Text = "CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private TextBox txtNome;
        private TextBox txtSobreNome;
        private Label lblNome;
        private Label lblSobrenome;
        private TextBox txtUsuarioId;
        private Button btnGravar;
        private Button btnListar;
        private Button btnApagar;
        private Button btnNovo;
    }
}
