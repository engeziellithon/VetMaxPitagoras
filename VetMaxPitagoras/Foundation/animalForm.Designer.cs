﻿namespace VetMaxPitagoras.Foundation
{
    partial class animalForm
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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.lbNomeDoAnimal = new System.Windows.Forms.Label();
            this.lbRaça = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNomeDono = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNomeDoDono = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grupoCadAnimal = new System.Windows.Forms.GroupBox();
            this.txtTempoDeVida = new System.Windows.Forms.TextBox();
            this.txtUnicoDono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtTelefoneDoDono = new System.Windows.Forms.MaskedTextBox();
            this.telefoneDono = new System.Windows.Forms.Label();
            this.dataCadAnimal = new System.Windows.Forms.DataGridView();
            this.validacaoAnimalCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.grupoCadAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCadAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacaoAnimalCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomeDoAnimal
            // 
            this.lbNomeDoAnimal.AutoSize = true;
            this.lbNomeDoAnimal.Location = new System.Drawing.Point(14, 44);
            this.lbNomeDoAnimal.Name = "lbNomeDoAnimal";
            this.lbNomeDoAnimal.Size = new System.Drawing.Size(91, 13);
            this.lbNomeDoAnimal.TabIndex = 0;
            this.lbNomeDoAnimal.Text = "*Nome do Animal:";
            // 
            // lbRaça
            // 
            this.lbRaça.AutoSize = true;
            this.lbRaça.Location = new System.Drawing.Point(322, 44);
            this.lbRaça.Name = "lbRaça";
            this.lbRaça.Size = new System.Drawing.Size(36, 13);
            this.lbRaça.TabIndex = 1;
            this.lbRaça.Text = "Raça:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(327, 79);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbNomeDono
            // 
            this.lbNomeDono.AutoSize = true;
            this.lbNomeDono.Location = new System.Drawing.Point(13, 79);
            this.lbNomeDono.Name = "lbNomeDono";
            this.lbNomeDono.Size = new System.Drawing.Size(86, 13);
            this.lbNomeDono.TabIndex = 4;
            this.lbNomeDono.Text = "*Nome do Dono:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(127, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(374, 37);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(97, 20);
            this.txtRaca.TabIndex = 6;
            this.txtRaca.TextChanged += new System.EventHandler(this.txtRaca_TextChanged);
            this.txtRaca.Enter += new System.EventHandler(this.txtRaca_Enter);
            this.txtRaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRaca_KeyPress);
            this.txtRaca.Leave += new System.EventHandler(this.txtRaca_Leave);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(374, 76);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(97, 20);
            this.txtTipo.TabIndex = 7;
            this.txtTipo.Enter += new System.EventHandler(this.txtTipo_Enter);
            this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipo_KeyPress);
            this.txtTipo.Leave += new System.EventHandler(this.txtTipo_Leave);
            // 
            // txtNomeDoDono
            // 
            this.txtNomeDoDono.Location = new System.Drawing.Point(127, 76);
            this.txtNomeDoDono.Name = "txtNomeDoDono";
            this.txtNomeDoDono.Size = new System.Drawing.Size(174, 20);
            this.txtNomeDoDono.TabIndex = 9;
            this.txtNomeDoDono.Enter += new System.EventHandler(this.txtNomeDoDono_Enter);
            this.txtNomeDoDono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeDoDono_KeyPress);
            this.txtNomeDoDono.Leave += new System.EventHandler(this.txtNomeDoDono_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(209, 200);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 26);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grupoCadAnimal
            // 
            this.grupoCadAnimal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grupoCadAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.grupoCadAnimal.Controls.Add(this.txtTempoDeVida);
            this.grupoCadAnimal.Controls.Add(this.txtUnicoDono);
            this.grupoCadAnimal.Controls.Add(this.label2);
            this.grupoCadAnimal.Controls.Add(this.label1);
            this.grupoCadAnimal.Controls.Add(this.btnSair);
            this.grupoCadAnimal.Controls.Add(this.txtTelefoneDoDono);
            this.grupoCadAnimal.Controls.Add(this.txtNome);
            this.grupoCadAnimal.Controls.Add(this.telefoneDono);
            this.grupoCadAnimal.Controls.Add(this.lbNomeDono);
            this.grupoCadAnimal.Controls.Add(this.btnCadastrar);
            this.grupoCadAnimal.Controls.Add(this.lbTipo);
            this.grupoCadAnimal.Controls.Add(this.lbNomeDoAnimal);
            this.grupoCadAnimal.Controls.Add(this.txtNomeDoDono);
            this.grupoCadAnimal.Controls.Add(this.lbRaça);
            this.grupoCadAnimal.Controls.Add(this.txtRaca);
            this.grupoCadAnimal.Controls.Add(this.txtTipo);
            this.grupoCadAnimal.Location = new System.Drawing.Point(179, 12);
            this.grupoCadAnimal.Name = "grupoCadAnimal";
            this.grupoCadAnimal.Size = new System.Drawing.Size(605, 244);
            this.grupoCadAnimal.TabIndex = 11;
            this.grupoCadAnimal.TabStop = false;
            this.grupoCadAnimal.Text = "Cadastro de animal";
            this.grupoCadAnimal.Enter += new System.EventHandler(this.grupoCadAnimal_Enter);
            // 
            // txtTempoDeVida
            // 
            this.txtTempoDeVida.Location = new System.Drawing.Point(127, 155);
            this.txtTempoDeVida.Name = "txtTempoDeVida";
            this.txtTempoDeVida.Size = new System.Drawing.Size(169, 20);
            this.txtTempoDeVida.TabIndex = 18;
            // 
            // txtUnicoDono
            // 
            this.txtUnicoDono.Location = new System.Drawing.Point(374, 114);
            this.txtUnicoDono.Name = "txtUnicoDono";
            this.txtUnicoDono.Size = new System.Drawing.Size(100, 20);
            this.txtUnicoDono.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Único Dono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Idade do Animal:";
           // this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(325, 200);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 26);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txtTelefoneDoDono
            // 
            this.txtTelefoneDoDono.Location = new System.Drawing.Point(127, 117);
            this.txtTelefoneDoDono.Mask = "(99) 0000-0000";
            this.txtTelefoneDoDono.Name = "txtTelefoneDoDono";
            this.txtTelefoneDoDono.Size = new System.Drawing.Size(80, 20);
            this.txtTelefoneDoDono.TabIndex = 13;
            this.txtTelefoneDoDono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneDoDono_KeyPress);
            // 
            // telefoneDono
            // 
            this.telefoneDono.AutoSize = true;
            this.telefoneDono.Location = new System.Drawing.Point(14, 117);
            this.telefoneDono.Name = "telefoneDono";
            this.telefoneDono.Size = new System.Drawing.Size(52, 13);
            this.telefoneDono.TabIndex = 12;
            this.telefoneDono.Text = "Telefone:";
            // 
            // dataCadAnimal
            // 
            this.dataCadAnimal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataCadAnimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCadAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCadAnimal.Location = new System.Drawing.Point(179, 279);
            this.dataCadAnimal.Name = "dataCadAnimal";
            this.dataCadAnimal.Size = new System.Drawing.Size(605, 381);
            this.dataCadAnimal.TabIndex = 12;
            // 
            // validacaoAnimalCampos
            // 
            this.validacaoAnimalCampos.BlinkRate = 100;
            this.validacaoAnimalCampos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validacaoAnimalCampos.ContainerControl = this;
            // 
            // animalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 733);
            this.Controls.Add(this.dataCadAnimal);
            this.Controls.Add(this.grupoCadAnimal);
            this.Name = "animalForm";
            this.Text = "animalForm";
            this.Load += new System.EventHandler(this.animalForm_Load);
            this.grupoCadAnimal.ResumeLayout(false);
            this.grupoCadAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCadAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacaoAnimalCampos)).EndInit();
            this.ResumeLayout(false);

=======
            this.lbNome = new System.Windows.Forms.Label();
            this.lbRaça = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNomeDono = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtTelefoneDoDono = new System.Windows.Forms.TextBox();
            this.txtNomeDoDono = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grupoCadAnimal = new System.Windows.Forms.GroupBox();
            this.telefoneDono = new System.Windows.Forms.Label();
            this.gridCadastroAnimal = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grupoCadAnimal.SuspendLayout();
            this.gridCadastroAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(16, 44);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbRaça
            // 
            this.lbRaça.AutoSize = true;
            this.lbRaça.Location = new System.Drawing.Point(18, 84);
            this.lbRaça.Name = "lbRaça";
            this.lbRaça.Size = new System.Drawing.Size(36, 13);
            this.lbRaça.TabIndex = 1;
            this.lbRaça.Text = "Raça:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(18, 192);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbNomeDono
            // 
            this.lbNomeDono.AutoSize = true;
            this.lbNomeDono.Location = new System.Drawing.Point(16, 121);
            this.lbNomeDono.Name = "lbNomeDono";
            this.lbNomeDono.Size = new System.Drawing.Size(82, 13);
            this.lbNomeDono.TabIndex = 4;
            this.lbNomeDono.Text = "Nome do Dono:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(129, 77);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(174, 20);
            this.txtRaca.TabIndex = 6;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(129, 185);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(174, 20);
            this.txtTipo.TabIndex = 7;
            // 
            // txtTelefoneDoDono
            // 
            this.txtTelefoneDoDono.Location = new System.Drawing.Point(129, 150);
            this.txtTelefoneDoDono.Name = "txtTelefoneDoDono";
            this.txtTelefoneDoDono.Size = new System.Drawing.Size(174, 20);
            this.txtTelefoneDoDono.TabIndex = 8;
            // 
            // txtNomeDoDono
            // 
            this.txtNomeDoDono.Location = new System.Drawing.Point(129, 114);
            this.txtNomeDoDono.Name = "txtNomeDoDono";
            this.txtNomeDoDono.Size = new System.Drawing.Size(174, 20);
            this.txtNomeDoDono.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(163, 239);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grupoCadAnimal
            // 
            this.grupoCadAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grupoCadAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.grupoCadAnimal.Controls.Add(this.btnExcluir);
            this.grupoCadAnimal.Controls.Add(this.txtNome);
            this.grupoCadAnimal.Controls.Add(this.telefoneDono);
            this.grupoCadAnimal.Controls.Add(this.lbNomeDono);
            this.grupoCadAnimal.Controls.Add(this.btnCadastrar);
            this.grupoCadAnimal.Controls.Add(this.lbTipo);
            this.grupoCadAnimal.Controls.Add(this.lbNome);
            this.grupoCadAnimal.Controls.Add(this.txtNomeDoDono);
            this.grupoCadAnimal.Controls.Add(this.lbRaça);
            this.grupoCadAnimal.Controls.Add(this.txtRaca);
            this.grupoCadAnimal.Controls.Add(this.txtTelefoneDoDono);
            this.grupoCadAnimal.Controls.Add(this.txtTipo);
            this.grupoCadAnimal.Location = new System.Drawing.Point(329, 153);
            this.grupoCadAnimal.Name = "grupoCadAnimal";
            this.grupoCadAnimal.Size = new System.Drawing.Size(320, 341);
            this.grupoCadAnimal.TabIndex = 11;
            this.grupoCadAnimal.TabStop = false;
            this.grupoCadAnimal.Text = "Cadastro de animal";
            // 
            // telefoneDono
            // 
            this.telefoneDono.AutoSize = true;
            this.telefoneDono.Location = new System.Drawing.Point(16, 157);
            this.telefoneDono.Name = "telefoneDono";
            this.telefoneDono.Size = new System.Drawing.Size(99, 13);
            this.telefoneDono.TabIndex = 12;
            this.telefoneDono.Text = "Telefone do Dono :";
            // 
            // gridCadastroAnimal
            // 
            this.gridCadastroAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridCadastroAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.gridCadastroAnimal.ColumnCount = 3;
            this.gridCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gridCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gridCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gridCadastroAnimal.Controls.Add(this.grupoCadAnimal, 1, 0);
            this.gridCadastroAnimal.Location = new System.Drawing.Point(0, 1);
            this.gridCadastroAnimal.Name = "gridCadastroAnimal";
            this.gridCadastroAnimal.RowCount = 1;
            this.gridCadastroAnimal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridCadastroAnimal.Size = new System.Drawing.Size(980, 647);
            this.gridCadastroAnimal.TabIndex = 12;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(239, 239);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // animalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 648);
            this.Controls.Add(this.gridCadastroAnimal);
            this.Name = "animalForm";
            this.Text = "animalForm";
            this.Load += new System.EventHandler(this.animalForm_Load);
            this.grupoCadAnimal.ResumeLayout(false);
            this.grupoCadAnimal.PerformLayout();
            this.gridCadastroAnimal.ResumeLayout(false);
            this.ResumeLayout(false);

>>>>>>> 68ff2e8d1bf849f48768c15de953210a5b13a79e
        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbRaça;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label telefoneDono;
        private System.Windows.Forms.Label lbNomeDono;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtTelefoneDoDono;
        private System.Windows.Forms.TextBox txtNomeDoDono;

        private System.Windows.Forms.Button btnCadastrar;

        private System.Windows.Forms.GroupBox grupoCadAnimal;
        private System.Windows.Forms.TableLayoutPanel gridCadastroAnimal;
        private System.Windows.Forms.Button btnExcluir; 
    }
}