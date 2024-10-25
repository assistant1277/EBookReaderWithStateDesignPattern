using EBookReaderWithStateDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookReaderWithStateDesignPattern.Models
{
    //below class represent reading state of ebook reader means reader is currently in reading mode
    public class ReadingState:IEBookReaderState
    {
        //below variable hold reference to eBookReaderService so we can switch states when needed
        private readonly EBookReaderService _readerService;

        //constructor take in eBookReaderService and assigns it to private _readerService variable
        public ReadingState(EBookReaderService readerService)
        {
            _readerService = readerService;
        }

        //below method handle what happen when power button is press while reader is in reading mode and
        //it changes state to sleeping and return message indicating reader is going to sleep
        public string PressPowerButton()
        {
            _readerService.SetState(_readerService.SleepingState);
            return "\nPutting ebook reader to sleep";
        }

        //below method is called when user tries to start reading while already in reading mode
        //it return message saying you are already in reading mode
        public string StartReading()
        {
            return "\nYou are in reading mode";
        }

        //below method is called when user want to stop reading
        //and it switch state to off and return message indicating reading has stopped and reader is off
        public string StopReading()
        {
            _readerService.SetState(_readerService.OffState); //switch to off state
            return "\nStopping reading and turning off ebook reader";
        }
    }
}