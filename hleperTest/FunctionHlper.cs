namespace hleperTest
{
    public class FunctionHlper
    {
        public string getFunctionName()
        {
            return "FunctionHlper";
        }
        public string test(string text)
        {
            string result = text + " " + getFunctionName();
            return result;
        }
    }
}
