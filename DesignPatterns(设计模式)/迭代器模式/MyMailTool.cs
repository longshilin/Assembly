namespace DesignPatterns.迭代器模式
{
    public class MyMailTool : MailInterface
    {
        private MailTool yourMailTool;

        public MyMailTool()
        {
            yourMailTool = new MailTool();
        }

        public int getMail()
        {
            return GetYourMailTool.retrieveMail();
        }

        public MailTool GetYourMailTool => yourMailTool;

        public MailTool SetYourMailTool
        {
            get => yourMailTool;
            set => yourMailTool = value;
        }
    }
}