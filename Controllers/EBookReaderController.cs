using EBookReaderWithStateDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookReaderWithStateDesignPattern.Controllers
{
    //below class control action of ebook reader like pressing buttons
    public class EBookReaderController
    {
        //below variable hold reference to eBookReaderService which manages states of ebook reader like reading,sleeping,off
        private readonly EBookReaderService _eBookReaderService;

        //constructor receive eBookReaderService and assign it to private variable _eBookReaderService
        public EBookReaderController(EBookReaderService eBookReaderService)
        {
            _eBookReaderService = eBookReaderService;
        }

        //below method is called when power button is press and it ask service to handle it and return message
        public string PowerButtonPressed()
        {
            return _eBookReaderService.PressPowerButton();
        }

        //below method is called when start reading button is press and it tells service to handle starting to read
        public string StartReadingButtonPressed()
        {
            return _eBookReaderService.StartReading();
        }

        //below method is called when stop reading button is press and it ask service to handle stopping reading
        public string StopReadingButtonPressed()
        {
            return _eBookReaderService.StopReading();
        }
    }
}

//why do we need controller because =>
//controller act like bridge between user interface part where user press button and service layer part that handles states
//and logic of ebook reader and controller help to separate responsibilities means task
//and user interaction logic like which button is pressed and stay in controller
//business logic like what happens when power button is press is handled by service
//it make code easier to maintain and understand because each part has clear job means what to do
//by having controller you can easily change how user interacts with system like moving from console app to graphical user interface
//without changing business logic in service layer and if you want to add new features or handle more complex user inputs
//like multiple buttons or advanced settings then having controller allows you to manage these and change without touching main logic in service