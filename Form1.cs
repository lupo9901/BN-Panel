using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxComm
{
    public partial class Form1 : Form
    {
        bool connected = false;
        string message;
        string incomingString;

        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;

        SerialPort sp;       


        public Form1()
        {
            InitializeComponent();

            this.Text = "BN Control Panel";
            this.Icon = Properties.Resources.Icon1;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            


            var ports = SerialPort.GetPortNames();
            portComboBox.DataSource = ports;

            progressBar1.Value = 25; //int.Parse(sollSliderVal.Text);

            systemInfo.Text = "Offline";

            this.myDelegate = new AddDataDelegate(AddDataMethod);

        }

        public void AddDataMethod(String myString)
        {
            

            if(myString.StartsWith("/a"))
            {
                myString = myString.Replace("/a ", string.Empty);
                myString = myString.Replace(".", ",");
                myString = myString.Replace("\r\n", string.Empty);

                if (myString.Any(char.IsNumber))
                {
                 
                    currentAngle.Text = myString;
                    
                    myString = "";
                   
                }
                else
                {
                    currentAngle.Text = "0";
                    
                }


            }          
           
           else if(myString.StartsWith("Exit application"))
            {
                if (connected)
                {
                    connected = false;

                    onlineStatus.Text = "OFFLINE";
                    onlineStatus.BackColor = Color.Red;

                    connectButton.Text = "Connect";

                    sp.Close();
                    sp.Dispose();

                    myString = "";

                    MessageBox.Show("Verbindung wurde vom Client terminiert.", "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            else
            {
                receivedTextBox.AppendText(myString);
            }

            


        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if(connected)
                {

                    sp.Write("exit" + "\n");

                    sp.Close();
                    sp.Dispose();
                    connected = false;

                    onlineStatus.Text = "OFFLINE";
                    onlineStatus.BackColor = Color.Red;

                    connectButton.Text = "Connect";
                    MessageBox.Show("Serial port disconnected.", "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;


                }

                if (!connected)
                {
                    systemInfo.Text = "Bitte warten... verbindet.";

                    if (portComboBox.SelectedItem != null)
                    {
                        sp = new SerialPort(portComboBox.SelectedItem.ToString(), 115200);

                        sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                    }
                    else
                    {
                        MessageBox.Show("Kein Port ausgewählt!", "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                                                                                                                      
                    sp.Open();
                    connected = true;
                    connectButton.Text = "Disconnect";

                    onlineStatus.Text = "ONLINE";
                    onlineStatus.BackColor = Color.Green;

                    

                    Thread.Sleep(500);      //Warte auf Antwort

                    sp.DtrEnable = true;

                    Thread.Sleep(5000);      //Warte auf Antwort

                    sp.Write("Start" + "\n");

                    Thread.Sleep(1000);      //Warte auf Antwort

                    sp.Write("Dynacord" + "\n");      //Passwort

                    Thread.Sleep(200);
                    MessageBox.Show("Serial port connected.\nStartknopf drücken.","BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    systemInfo.Text = "Verbunden.";

                    sendText.Focus();

                    return;

                    
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendInputLineData();
            Console.WriteLine("Button Click");
        }

        private void refDriveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connected)
                {
                    sp.Write("/test/motion" + '\n');
                    
                }
                else
                {
                    MessageBox.Show("Connect to a port before sending", "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void driveStartButton_Click(object sender, EventArgs e)
        {

            if (connected)
            {
                try
                {
                    var parseSliderValue = double.Parse(sollWinkel.Text);

                    if (parseSliderValue > winkelSlider.Maximum / 2 || parseSliderValue < winkelSlider.Minimum)
                    {
                        MessageBox.Show("Wert muss zwischen " + winkelSlider.Minimum + " und " + winkelSlider.Maximum / 2 + " liegen.");
                        sollWinkel.Text = "";
                    }
                    else
                    {
                        winkelSlider.Value = (int)(parseSliderValue * 2);

                        try
                        {

                            string sollWinkelVar = sollWinkel.Text;

                            sp.Write("/drive/soll " + sollWinkelVar + '\n');
                            Thread.Sleep(10);
                            sp.Write("/drive/moveplate");

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }            

            }
            else
            {
                MessageBox.Show("Connect to a port before sending", "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void sendText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendInputLineData();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            portComboBox.DataSource = ports;

            if(ports == null || ports.Length == 0)
            {
                portComboBox.Text = "";
            }
        }

        private void winkelSlider_ValueChanged(object sender, EventArgs e)
        {
            double sliderSollWert = (double)winkelSlider.Value;

            sliderSollWert /= 2;

            sollSliderVal.Text = sliderSollWert.ToString();

            sollWinkel.Text = sliderSollWert.ToString();

            
        }

        private void SendInputLineData()
        {
            try
            {
                if (connected)
                {
                    message = sendText.Text;
                    sp.Write(message);
                    sendText.Text = "";
                    sendText.Focus();
                }
                else
                {
                    MessageBox.Show("Connect to a port before sending", "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)      //object sender, SerialDataReceivedEventArgs e
        {

            SerialPort sp = (SerialPort)sender;
            String indata = sp.ReadTo("\n");
            incomingString = indata;

            receivedTextBox.BeginInvoke(this.myDelegate, new Object[] { indata });
            currentAngle.BeginInvoke(this.myDelegate, new Object[] { indata });


            if (incomingString.Contains("**Full Remote access**"))
            {
                MessageBox.Show("Verbunden.", "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (incomingString.StartsWith("FATAL ERROR"))
            {
                MessageBox.Show("Fehlerfall erkannt. \nGerät ist deaktiviert.", "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void offsetButton_Click(object sender, EventArgs e)
        { 
            try
            {
                if (connected)
                {
                    var offsetValue = offsetTextBox.Text;


                    sp.Write("/settings/offset " + offsetValue);

                }
                else
                {
                    MessageBox.Show("Connect to a port before sending", "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void receivedTextBox_TextChanged(object sender, EventArgs e)
        {
            receivedTextBox.SelectionStart = receivedTextBox.Text.Length;

            receivedTextBox.ScrollToCaret();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void aboutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Boxenneiger Control Panel v0.1 \n" +
                            "Created by Luca Ponzio 2020 \n" +
                            "Betrieblicher Auftrag.",
                            "BN Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void currentAngle_TextChanged(object sender, EventArgs e)
        {
            String istWinkelString= currentAngle.Text.Replace(".", ",");

            String sollWinkelString = sollSliderVal.Text;

            int istWinkelInt = Convert.ToInt32(Convert.ToDouble(istWinkelString)*100);
            int sollWinkelInt = Convert.ToInt32(Convert.ToDouble(sollWinkelString)*100);

            //progressBar1.Maximum = sollWinkelInt;

            progressBar1.Maximum = 2500;

            if (istWinkelInt < 2500)
            {
                progressBar1.Value = istWinkelInt;
            }

            //  if (istWinkelInt > sollWinkelInt)
            // {
            //     progressBar1.Value = progressBar1.Maximum;
            //  }
            //  else
            //   {
            //      progressBar1.Value = istWinkelInt;
            //  }







        }
    }
}
