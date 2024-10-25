using EBookReaderWithStateDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookReaderWithStateDesignPattern.Models
{
    //below class represent sleeping state of ebook reader means reader is in low power sleep mode
    public class SleepingState:IEBookReaderState
    {
        //below variable hold reference to eBookReaderService and so we can switch states when needed
        private readonly EBookReaderService _readerService;

        //constructor take in eBookReaderService and assign it to private _readerService variable
        public SleepingState(EBookReaderService readerService)
        {
            _readerService = readerService;
        }

        //below method handle what happens when power button is press while reader is in sleep mode and
        //it change state to reading and return message saying reader is waking up to start reading
        public string PressPowerButton()
        {
            _readerService.SetState(_readerService.ReadingState); //switch to reading state
            return "\nWaking up ebook reader to reading mode";
        }

        //below method is called when user tries to start reading while device is in sleep mode
        //and it return message saying you cant start reading from sleep mode and must power on first
        public string StartReading()
        {
            _readerService.SetState(_readerService.ReadingState); //switch to reading state
            return "\nCannot start reading in sleep mode and power on first";
        }

        //below method is called when user want to stop reading while device is in sleep mode
        //and it change state to off and return message saying device is turning off from sleep mode
        public string StopReading()
        {
            _readerService.SetState(_readerService.OffState); //switch to off state
            return "\nTurning off ebook reader from sleep mode";
        }
    }
}