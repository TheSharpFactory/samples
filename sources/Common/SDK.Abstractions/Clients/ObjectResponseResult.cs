namespace TheSharpFactory.SDK.Clients
{
    public struct ObjectResponseResult<T>
    {
        public T Object { get; }

        public string Text { get; }
        public ObjectResponseResult(T responseObject, string responseText)
        {
            Object = responseObject;
            Text = responseText;
        }
    }
}