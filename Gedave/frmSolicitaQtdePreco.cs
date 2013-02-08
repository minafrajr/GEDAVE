using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gedave
{
    public partial class frmSolicitaQtdePreco : Form
    {
        public short quantidade { get; set; }
        public float desconto { get; set; }

        public frmSolicitaQtdePreco()
        {
            InitializeComponent();
            nud_quantidade.Focus();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (nud_quantidade.Value.ToString() !="0")
            {
                this.quantidade = Convert.ToSByte(nud_quantidade.Value);
                if (msk_desc.Text != String.Empty)
                {
                    this.desconto = float.Parse(msk_desc.Text); 
                }
            }
            else
                throw new Exception("Erro ao informar quantidade!\nA quantidade deve ser maior que 1.");
        }

        private void InitializeComponent()
        {
            this.btn_OK = new System.Windows.Forms.Button();
            this.msk_desc = new Gedave.MeuMskTextBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_desconto = new System.Windows.Forms.Label();
            this.nud_quantidade = new System.Windows.Forms.NumericUpDown();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dicaporcentagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(240, 104);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // msk_desc
            // 
            this.msk_desc.Location = new System.Drawing.Point(134, 102);
            this.msk_desc.Name = "msk_desc";
            this.msk_desc.Size = new System.Drawing.Size(46, 20);
            this.msk_desc.TabIndex = 2;
            this.msk_desc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(38, 78);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(96, 20);
            this.lbl_quantidade.TabIndex = 3;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // lbl_desconto
            // 
            this.lbl_desconto.AutoSize = true;
            this.lbl_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desconto.Location = new System.Drawing.Point(53, 102);
            this.lbl_desconto.Name = "lbl_desconto";
            this.lbl_desconto.Size = new System.Drawing.Size(82, 20);
            this.lbl_desconto.TabIndex = 4;
            this.lbl_desconto.Text = "Desconto:";
            // 
            // nud_quantidade
            // 
            this.nud_quantidade.Location = new System.Drawing.Point(134, 78);
            this.nud_quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantidade.Name = "nud_quantidade";
            this.nud_quantidade.Size = new System.Drawing.Size(46, 20);
            this.nud_quantidade.TabIndex = 5;
            this.nud_quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(29, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(261, 29);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "Indique a quantidade e o ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "desconto do produto.";
            // 
            // lbl_dicaporcentagem
            // 
            this.lbl_dicaporcentagem.AutoSize = true;
            this.lbl_dicaporcentagem.Location = new System.Drawing.Point(186, 109);
            this.lbl_dicaporcentagem.Name = "lbl_dicaporcentagem";
            this.lbl_dicaporcentagem.Size = new System.Drawing.Size(48, 13);
            this.lbl_dicaporcentagem.TabIndex = 8;
            this.lbl_dicaporcentagem.Text = "5,0 = 5%";
            // 
            // frmSolicitaQtdePreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(319, 137);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_dicaporcentagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.nud_quantidade);
            this.Controls.Add(this.lbl_desconto);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.msk_desc);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSolicitaQtdePreco";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GEDAVE - Sistema de Gestão de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
