﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MessageService
    {
        public void OnVideoEncoded(object source,VideoEventArgs e)
        {
            Console.WriteLine("Message Service : Message sended Successfully "+e.video.title);
        }
        
    }
}
