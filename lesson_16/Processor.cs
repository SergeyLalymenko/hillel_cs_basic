namespace lesson_16
{
    class Processor
    {
        private readonly Provider _provider;
        private readonly Sender _sender;

        public Processor(Provider provider, Sender sender)
        {
            _provider = provider;
            _sender = sender;
        }

        public void Process()
        {
            string content = _provider.Provide();
            _sender.Send(content);
        }
    }
}
