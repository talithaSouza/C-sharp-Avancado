
namespace Loja
{
    partial class Form_Cadastro_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_cadastro = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.cbx_situacao = new System.Windows.Forms.ComboBox();
            this.cbx_perfil = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cadastro:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Situação:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Perfil:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(92, 90);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(259, 20);
            this.tb_nome.TabIndex = 0;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(92, 150);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(259, 20);
            this.tb_email.TabIndex = 2;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(92, 180);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(259, 20);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.Location = new System.Drawing.Point(92, 210);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Size = new System.Drawing.Size(153, 20);
            this.tb_cadastro.TabIndex = 4;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(92, 120);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(259, 20);
            this.tb_login.TabIndex = 1;
            // 
            // cbx_situacao
            // 
            this.cbx_situacao.FormattingEnabled = true;
            this.cbx_situacao.Items.AddRange(new object[] {
            "Administrador",
            "Operador",
            "Gerencial"});
            this.cbx_situacao.Location = new System.Drawing.Point(92, 265);
            this.cbx_situacao.Name = "cbx_situacao";
            this.cbx_situacao.Size = new System.Drawing.Size(127, 21);
            this.cbx_situacao.TabIndex = 6;
            // 
            // cbx_perfil
            // 
            this.cbx_perfil.FormattingEnabled = true;
            this.cbx_perfil.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbx_perfil.Location = new System.Drawing.Point(92, 238);
            this.cbx_perfil.Name = "cbx_perfil";
            this.cbx_perfil.Size = new System.Drawing.Size(127, 21);
            this.cbx_perfil.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.LightGreen;
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(432, 90);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(91, 33);
            this.btn_novo.TabIndex = 18;
            this.btn_novo.Text = "NOVO";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Red;
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.Location = new System.Drawing.Point(626, 90);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(91, 33);
            this.btn_deletar.TabIndex = 19;
            this.btn_deletar.Text = "DELETAR";
            this.btn_deletar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Yellow;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(529, 90);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(91, 33);
            this.btn_editar.TabIndex = 20;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(432, 171);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(285, 23);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(432, 137);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(285, 23);
            this.btn_confirmar.TabIndex = 22;
            this.btn_confirmar.Text = "CONFIRMAR";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // Form_Cadastro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_perfil);
            this.Controls.Add(this.cbx_situacao);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_cadastro);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Cadastro_Usuario";
            this.Text = "Form_Cadastro_Usuario";
            this.Load += new System.EventHandler(this.Form_Cadastro_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_cadastro;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.ComboBox cbx_situacao;
        private System.Windows.Forms.ComboBox cbx_perfil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
    }
}