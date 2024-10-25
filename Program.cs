using EBookReaderWithStateDesignPattern.Presentations;

namespace EBookReaderWithStateDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsolePresentation.RunEBookReader();
        }
    }
}
//[*important]State design pattern is used in this ebook reader to manage different modes states like reading,sleeping,off
//means each state like reading,sleeping,off has its own class with specific rules and behaviors
//and keeps code organized and easier to manage and each class only need to worry about it own state
//and if we want to add new state in future like pause then we can simply create new class for it
//we dont need to change existing code we just add new state class and define it behavior
//each state know what to do for actions like pressing power button or starting/stopping reading
//and it prevent main code from getting complicated with many if else statement checking which state is active
//and ebook reader can easily switch between states at runtime based on user actions
//eg->if reader is off and user press power button it transition to reading state
//so this flexibility makes ebook reader behave more naturally just like real device would and
//it is clear what each state does and how it behaves without mixing logic in one big class
//means in simple anyone reading code can easily understand purpose of each state and how they interact