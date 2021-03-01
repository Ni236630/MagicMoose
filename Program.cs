using System;
using System.Collections.Generic;

Main();

void Main()
{
    Console.WriteLine("Welcome Young Traveler!");
    Console.WriteLine("-----------------------");
    Console.WriteLine();

    //maic moose speaks
    MooseSays("Hi, I'm The Magic Moose");
    MooseSays("Ask me a question and I will give you an answer!");

    QuestionAsked();
}

void QuestionAsked()
{
    Dictionary<int,string> MagicAnswers = new Dictionary<int,string>(){
        {0,"As I see it, yes."},
        {1,"Ask again later."},
        {2,"Better not tell you now."},
        {3,"Cannot predict now."} ,
        {4,"Concentrate and ask again."},
        {5,"Don’t count on it."},
        {6,"It is certain."},
        {7,"It is decidedly so."},
        {8,"Most likely."},
        {9,"My reply is no."},
        {10,"My sources say no."},
        {11,"Outlook not so good."},
        {12,"Outlook good."},
        {13,"Reply hazy, try again."},
        {14,"Signs point to yes."},
        {15,"Very doubtful."},
        {16,"Without a doubt."},
        {17,"Yes."},
        {18,"Yes – definitely."},
        {19,"You may rely on it."},
    };


    int r = new Random().Next(0,19);
    string answer = Console.ReadLine();

    while (answer != "")
    {
        if ( MagicAnswers.ContainsKey(r) && answer.Contains("?"))
        {
            Console.WriteLine(MagicAnswers[r]);
            answer = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Please ask a question with a '?' or press 'enter' to exit");
            answer = Console.ReadLine();
        }
    }

}





void MooseSays(string message)
{
  Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");

}