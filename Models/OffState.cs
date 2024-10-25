using EBookReaderWithStateDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookReaderWithStateDesignPattern.Models
{
    //below class represent off state of ebook reader means reader is powered off
    public class OffState:IEBookReaderState
    {
        //below variable hold reference to eBookReaderService so we can switch states when needed
        private readonly EBookReaderService _readerService;

        //constructor takes in eBookReaderService and assign it to private _readerService variable
        public OffState(EBookReaderService readerService)
        {
            _readerService = readerService;
        }

        //below method handle what happen when power button is press while reader is off and
        //it change state to reading and return message indicating reader is turning on
        public string PressPowerButton()
        {
            _readerService.SetState(_readerService.ReadingState);//switch to reading state
            return "\nPowering on ebook reader and starting in reading mode";
        }

        //below method is called when user tries to start reading while ebook reader is off
        //and it simply return message saying you need to turn it on first
        public string StartReading()
        {
            return "\nYou need to turn ebook reader on first";
        }

        //below method is called when user tries to stop reading while ebook reader is already off and
        //since it is already off it return message saying that
        public string StopReading()
        {
            return "\nEbook reader is already off";
        }
    }
}