using System.IO.Ports;

namespace ProjetoLeitorSerial;

public partial class Home : Form
{
    private static SerialPort PortaSerial;
    private bool isSerialRodando = false;
    private bool SerialIsRodando
    {
        get => isSerialRodando;
        set
        {
            isSerialRodando = value;

            if (value) buttonStartStop.Text = "Stop";
            else buttonStartStop.Text = "Start";
            BloqueiaComboBox(value);
        }
    }

    public Home()
    {
        InitializeComponent();

        PortaSerial = new SerialPort();
        PortaSerial.DataReceived += RecebeDadosSerial;
    }

    private void Home_Load(object sender, EventArgs e)
    {
        AssociaPortasSeriaisDisponiveisComComboBox();
    }

    private void AssociaPortasSeriaisDisponiveisComComboBox()
    {
        string[] portasDisponiveis = SerialPort.GetPortNames();

        if (portasDisponiveis.Length <= 0) return;

        comboBoxPortaSerial.Items.AddRange(portasDisponiveis);
    }

    private void buttonStartStop_Click(object sender, EventArgs e)
    {
        //Stop
        if (SerialIsRodando)
        {
            FechaConexaoSerial();
            return;
        }

        // Start
        if (!ChecaSeUmaPortaSerialFoiEscolhida()) return;
        if (!AbreConexaoSerialComAPortaEscolhida()) return;
    }

    private void FechaConexaoSerial()
    {
        try
        {
            PortaSerial.Close();
            SerialIsRodando = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao tentar fechar a porta serial {PortaSerial.PortName}.\n" +
                $"Detalhes: {ex.Message}", "Leitor Serial",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            SerialIsRodando = false;
        }
    }

    private void BloqueiaComboBox(bool valor)
    {
        comboBoxPortaSerial.Enabled = !valor;
    }

    private bool ChecaSeUmaPortaSerialFoiEscolhida()
    {
        if (comboBoxPortaSerial.SelectedIndex < 0)
        {
            MessageBox.Show("Nenhuma porta serial foi escolhida.", "Leitor Serial",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    private bool AbreConexaoSerialComAPortaEscolhida()
    {
        PortaSerial.PortName = comboBoxPortaSerial.Text;
        PortaSerial.BaudRate = 9600;
        PortaSerial.DataBits = 8;
        PortaSerial.Parity = Parity.None;
        PortaSerial.StopBits = StopBits.One;

        try
        {
            PortaSerial.Open();
            SerialIsRodando = true;
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro ao tentar abrir a porta serial {PortaSerial.PortName}.\n" +
                $"Detalhes: {ex.Message}", "Leitor Serial",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            SerialIsRodando = false;
            return false;
        }
    }

    private void RecebeDadosSerial(object sender, SerialDataReceivedEventArgs e)
    {
        string dadosRecebidos = PortaSerial.ReadLine();
        this.BeginInvoke(TrataDadosSerial, dadosRecebidos);
    }

    private void TrataDadosSerial(string dadosRecebidos)
    {
        dadosRecebidos = dadosRecebidos.Replace("\n", "").Trim();

        var hora = DateTime.Now.ToString("HH:mm:ss");
        richTextBoxDadosRecebidos.AppendText($"{hora} - {dadosRecebidos} \n");

        richTextBoxDadosRecebidos.Select(richTextBoxDadosRecebidos.Text.Length - 1, 0);
        richTextBoxDadosRecebidos.ScrollToCaret();
    }
}
