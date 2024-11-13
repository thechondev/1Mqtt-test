using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;



namespace _1Mqtt_test
{
    public partial class Winicio : Form
    {
        public MqttClient mqtClient;

        public Winicio()
        {
            InitializeComponent();

            mqtClient = new MqttClient("test.mosquitto.org");
            mqtClient.Connect("");
            if (mqtClient.IsConnected)
            {
                mqtClient.MqttMsgPublishReceived += MqtClient_MqttMsgPublishReceived;
            }
            else
            {
                MessageBox.Show("No conectado");
            }

            string[] topics = new string[2];
            topics[0] = "hadi/tag1";
            topics[1] = "hadi/tag2";

            byte[] msg = new byte[2];
            msg[0] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
            msg[1] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;

            mqtClient.Subscribe(topics, msg);

        }

        private void MqtClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string topic = e.Topic;
            string value = Encoding.UTF8.GetString(e.Message);

            if (topic == "hadi/tag1")
            {
                lblvalue1.Invoke(new Action(() => lblvalue1.Text = value));
            }
            else if (topic == "hadi/tag2")
            {
                lblvalue2.Invoke(new Action(() => lblvalue2.Text = value));
            }

        }

        private void cmdagregar1_Click(object sender, EventArgs e)
        {
            mqtClient.Publish("hadi/tag1", Encoding.UTF8.GetBytes(txtValue1.Text));
        }

        private void txtValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Winicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            mqtClient.Disconnect();
            mqtClient = null;
        }

        private void txtValue2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmdagregar2_Click(object sender, EventArgs e)
        {
            mqtClient.Publish("hadi/tag2", Encoding.UTF8.GetBytes(txtValue1.Text));
        }
    }
}
