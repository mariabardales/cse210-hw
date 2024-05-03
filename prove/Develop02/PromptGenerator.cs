public class PromptGenerator
{
    public List<string> _prompts=new List<string> {"What spiritual experience did I have today?","Who should I remember?","What was the best part of my day?","What was the most interesting emotion today?","What lesson did I learn today?","What characteristic stands out about me today?"};
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, 5);
        return _prompts[index];
    }
}