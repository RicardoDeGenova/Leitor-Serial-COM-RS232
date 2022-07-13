namespace ProjetoLeitorSerial;

partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPortaSerial = new System.Windows.Forms.ComboBox();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfoSeriais = new System.Windows.Forms.Label();
            this.richTextBoxDadosRecebidos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porta Serial:";
            // 
            // comboBoxPortaSerial
            // 
            this.comboBoxPortaSerial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxPortaSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPortaSerial.FormattingEnabled = true;
            this.comboBoxPortaSerial.Location = new System.Drawing.Point(115, 45);
            this.comboBoxPortaSerial.Name = "comboBoxPortaSerial";
            this.comboBoxPortaSerial.Size = new System.Drawing.Size(92, 29);
            this.comboBoxPortaSerial.TabIndex = 1;
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStartStop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartStop.Location = new System.Drawing.Point(367, 21);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(136, 53);
            this.buttonStartStop.TabIndex = 2;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 2);
            this.panel1.TabIndex = 3;
            // 
            // labelInfoSeriais
            // 
            this.labelInfoSeriais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInfoSeriais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfoSeriais.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfoSeriais.Location = new System.Drawing.Point(213, 7);
            this.labelInfoSeriais.Name = "labelInfoSeriais";
            this.labelInfoSeriais.Size = new System.Drawing.Size(148, 80);
            this.labelInfoSeriais.TabIndex = 4;
            this.labelInfoSeriais.Text = "Baud Rate: 9600\r\nBits de Dados: 8\r\nParidade: Nenhuma\r\nBits de Parada: 1";
            // 
            // richTextBoxDadosRecebidos
            // 
            this.richTextBoxDadosRecebidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDadosRecebidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDadosRecebidos.Location = new System.Drawing.Point(12, 106);
            this.richTextBoxDadosRecebidos.Name = "richTextBoxDadosRecebidos";
            this.richTextBoxDadosRecebidos.ReadOnly = true;
            this.richTextBoxDadosRecebidos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxDadosRecebidos.Size = new System.Drawing.Size(594, 558);
            this.richTextBoxDadosRecebidos.TabIndex = 5;
            this.richTextBoxDadosRecebidos.Text = "";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(618, 676);
            this.Controls.Add(this.richTextBoxDadosRecebidos);
            this.Controls.Add(this.labelInfoSeriais);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.comboBoxPortaSerial);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(634, 715);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor Serial";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private ComboBox comboBoxPortaSerial;
    private Button buttonStartStop;
    private Panel panel1;
    private Label labelInfoSeriais;
    private RichTextBox richTextBoxDadosRecebidos;
}
