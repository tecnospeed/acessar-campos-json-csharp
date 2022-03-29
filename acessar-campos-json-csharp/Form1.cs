
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace acessar_json_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLerJson_Click(object sender, EventArgs e)
        {
            txtLeitura.Clear();

            // Deserealizando do JSON
            dynamic obj = JsonConvert.DeserializeObject(txtJson.Text);

            // Lendo o JSON
            if(rbExemplo1.Checked)
            {
                string status = obj._status;
                string sucessoIdIntegracao = obj._dados._sucesso[0].idintegracao;
                string sucessoSituacao = obj._dados._sucesso[0].situacao;

                string falhaIdIntegracao = obj._dados._falha[0].idintegracao;
                string falhaSituacao = obj._dados._falha[0].situacao;

                txtLeitura.AppendText("Leitura do JSON\r\n");
                txtLeitura.AppendText("-------------------------\r\n");
                txtLeitura.AppendText("Status: " + status + "\r\n");
                txtLeitura.AppendText("-------------------------\r\n");
                txtLeitura.AppendText("\r\n");
                txtLeitura.AppendText("Dados com Sucesso:\r\n");
                txtLeitura.AppendText("\r\n");
                txtLeitura.AppendText("idIntegracao: " + sucessoIdIntegracao + "\r\n");
                txtLeitura.AppendText("situacao: " + sucessoSituacao + "\r\n");
                txtLeitura.AppendText("-------------------------\r\n");
                txtLeitura.AppendText("\r\n");
                txtLeitura.AppendText("Dados com Falha:\r\n");
                txtLeitura.AppendText("\r\n");
                txtLeitura.AppendText("idIntegracao: " + falhaIdIntegracao + "\r\n");
                txtLeitura.AppendText("situacao: " + falhaSituacao + "\r\n");
                txtLeitura.AppendText("-------------------------\r\n");
            } else
            {
                string status = obj._status;
                var dados = obj._dados;

                txtLeitura.AppendText("Leitura do JSON\r\n");
                txtLeitura.AppendText("-------------------------\r\n");
                txtLeitura.AppendText("Status: " + status + "\r\n");
                txtLeitura.AppendText("-------------------------\r\n");

                txtLeitura.AppendText("\r\n");
                txtLeitura.AppendText("Dados com Sucesso:\r\n");
                txtLeitura.AppendText("\r\n");
                foreach (var item in dados._sucesso)
                {
                    txtLeitura.AppendText("idIntegracao: " + item.idintegracao + "\r\n");
                    txtLeitura.AppendText("situacao: " + item.situacao + "\r\n");
                    txtLeitura.AppendText("-------------------------\r\n");
                }

                txtLeitura.AppendText("\r\n");
                txtLeitura.AppendText("Dados com Falha:\r\n");
                txtLeitura.AppendText("\r\n");
                foreach (var item in dados._falha)
                {
                    txtLeitura.AppendText("idIntegracao: " + item.idintegracao + "\r\n");
                    txtLeitura.AppendText("situacao: " + item.situacao + "\r\n");
                    txtLeitura.AppendText("-------------------------\r\n");
                }
            }
        }

        private void rbExemplo1_CheckedChanged(object sender, EventArgs e)
        {
            string json = @"{
  '_status': 'sucesso',
  '_dados': {
    '_sucesso': [
      {
        'idintegracao': '04HNvir2_',
        'situacao': 'SALVO'
      }
    ],
    '_falha': [
      {
        'idintegracao': 'CSShMUoaaf',
        'situacao': 'FALHA'
      }
    ]    
  }  
}";
            txtJson.Text = json;
            txtLeitura.Clear();
        }

        private void rbExemplo2_CheckedChanged(object sender, EventArgs e)
        {
            string json = @"{
  '_status': 'sucesso',
  '_dados': {
    '_sucesso': [
      {
        'idintegracao': '04HNvir2_',
        'situacao': 'SALVO'
      },
      {
        'idintegracao': '18O1_ZGRQ',
        'situacao': 'EMITIDO'
      }
    ],
    '_falha': [
      {
        'idintegracao': 'CSShMUoaaf',
        'situacao': 'FALHA'
      },
      {
        'idintegracao': 'QR4EaaPHR',
        'situacao': 'REJEITADO'
      }
    ]    
  }  
}";
            txtJson.Text = json;
            txtLeitura.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbExemplo1_CheckedChanged(sender, e);
        }
    }
}
