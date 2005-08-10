using NLog;

namespace MyNamespace
{
    [Target("MyFirst")]
    public sealed class MyFirstTarget: Target
    {
        private string _host = "localhost";

        public string Host
        {
            get { return _host; }
            set { _host = value; }
        }
        protected override void Append(LogEventInfo ev)
        {
            string logMessage = CompiledLayout.GetFormattedMessage(ev);

            SendTheMessageToRemoteHost(this.Host, logMessage);
        }

        private void SendTheMessageToRemoteHost(string host, string message)
        {
            // TODO - write me
        }
    }
}