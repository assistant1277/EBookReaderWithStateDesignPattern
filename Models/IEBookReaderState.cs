using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookReaderWithStateDesignPattern.Models
{
    //below interface define actions means behaviors that any state of ebook reader should have
    public interface IEBookReaderState
    {
        //below PressPowerButton method should describe what happen when power button is press in any state
        string PressPowerButton();

        //below StartReading method should describe what happen when starting to read in any state
        string StartReading();
        string StopReading();
    }
}