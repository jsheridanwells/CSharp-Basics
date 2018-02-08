using System;
namespace TextSummaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Long paragraph, we will summarize this up to 50 characters
            var paragraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fringilla, mi vitae tincidunt semper, metus ligula pharetra nunc, ut vulputate tortor leo sed urna. Etiam sit amet mauris vestibulum, consectetur lectus quis, ullamcorper leo. Phasellus vehicula, neque nec ultricies molestie, nulla enim blandit lectus, vitae ullamcorper augue tortor at libero. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla tortor ex, placerat ut erat ullamcorper, viverra sagittis justo. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Duis dictum et velit id malesuada. Aliquam laoreet sagittis nunc. Quisque lobortis, sem quis aliquet tempor, sapien tortor hendrerit elit, et rhoncus orci orci sit amet nisi. Nam commodo, dui non elementum pellentesque, justo justo accumsan lorem, eget lobortis neque est vel dui. Donec nunc tellus, cursus et elementum in, varius ac erat.";
            // call #summarize() with paragraph and 50 character limit
            Console.WriteLine(StringUtility.summarize(paragraph, 50));
        }
    }
}
