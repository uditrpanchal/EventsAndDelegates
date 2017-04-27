using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { title = "Udit Panchal" };
            var videoEncoder = new VideoEncoder();
            var MailService = new MailService();
            var MessageService = new MessageService();

            videoEncoder.VideoEncoded += MailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += MessageService.OnVideoEncoded;

            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }

    
}
