using EBookReaderWithStateDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookReaderWithStateDesignPattern.Services
{
    //below class manage different states reading,sleeping,off of ebook reader and allows switching between them
    public class EBookReaderService
    {
        //below these are properties to store different states reading,sleeping,off ebook reader can be in
        public IEBookReaderState ReadingState { get; set; }
        public IEBookReaderState SleepingState { get; set; }
        public IEBookReaderState OffState { get; set; }

        //below variable keep track of current state of ebook reader
        private IEBookReaderState _currentState;

        //in constructor these run when instance of EBookReaderService is created
        //and it set up different states and start ebook reader in off state
        public EBookReaderService()
        {
            //creating instances of states and passing this service to them so they can manage state transition
            ReadingState = new ReadingState(this);
            SleepingState = new SleepingState(this);
            OffState = new OffState(this);

            //ebook reader is turned off so current state is set to off
            _currentState = OffState; 
        }

        //below method changes current state of ebook reader to new state passed to it
        public void SetState(IEBookReaderState newState)
        {
            _currentState = newState; //switches current state to new state provided
        }

        //below method is called when user presses power button and
        //it pass on action to current state of ebook reader
        public string PressPowerButton()
        {
            return _currentState.PressPowerButton();//call current state power button action
        }

        //below method is called when user want to start reading and
        //it asks current state what to do when reading is requested
        public string StartReading()
        {
            return _currentState.StartReading();//call current states start reading action
        }

        //below method is called when user want to stop reading
        //and it ask current state what to do when stopping reading is requested
        public string StopReading()
        {
            return _currentState.StopReading();//call current state stop reading action
        }
    }
}