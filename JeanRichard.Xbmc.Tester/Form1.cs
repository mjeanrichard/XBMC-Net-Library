using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected virtual void BeginExecuteRequest(string jsonRequest, Action<string> resultAction)
        {
            WebRequest webRequest = WebRequest.Create("http://192.168.175.35:8080/jsonrpc");
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            webRequest.BeginGetRequestStream(ar => ExecuteRequest(ar, jsonRequest, resultAction), webRequest);
        }

        private void ExecuteRequest(IAsyncResult asyncResult, string jsonRequest, Action<string> resultAction)
        {
            WebRequest webRequest = (WebRequest)asyncResult.AsyncState;

            using (Stream stream = webRequest.EndGetRequestStream(asyncResult))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(jsonRequest);
                stream.Write(buffer, 0, buffer.Length);
            }
            webRequest.BeginGetResponse(ar => GetJsonResult(ar, resultAction), webRequest);
        }

        private string FormatJson(string unformatted)
        {
            try
            {
                JObject jsonSchema = JObject.Parse(unformatted);

                StringBuilder sbFormat = new StringBuilder();
                using (StringWriter sw = new StringWriter(sbFormat))
                {
                    using (JsonWriter jsonWriter = new JsonTextWriter(sw))
                    {
                        jsonWriter.Formatting = Formatting.Indented;
                        jsonSchema.WriteTo(jsonWriter);
                    }
                }
                lblError.Text = "";
                return sbFormat.ToString();
            }
            catch (Exception e)
            {
                lblError.Text = e.Message;
                return unformatted;
            }
        }

        protected void GetJsonResult(IAsyncResult asyncResult, Action<string> resultAction)
        {
            WebRequest webRequest = (WebRequest)asyncResult.AsyncState;

            using (HttpWebResponse response = (HttpWebResponse)webRequest.EndGetResponse(asyncResult))
            {
                using (Stream stream = response.GetResponseStream())
                {
                    string jsonData;
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        jsonData = reader.ReadToEnd();
                    }
                    resultAction(jsonData);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtInput.Text = FormatJson(txtInput.Text);
            BeginExecuteRequest(txtInput.Text, s => txtOutput.BeginInvoke(new MethodInvoker(() => txtOutput.Text = FormatJson(s))));
        }
    }
}