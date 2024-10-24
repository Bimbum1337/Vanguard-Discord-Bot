namespace BimBot
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string title = @"
 __      __                                   _        _____  
 \ \    / /                                  | |      |  __ \ 
  \ \  / /_ _ _ __   __ _ _   _  __ _ _ __ __| |______| |__) |
   \ \/ / _` | '_ \ / _` | | | |/ _` | '__/ _` |______|  _  / 
    \  / (_| | | | | (_| | |_| | (_| | | | (_| |      | | \ \ 
     \/ \__,_|_| |_|\__, |\__,_|\__,_|_|  \__,_|      |_|  \_\
                     __/ |                                   
                    |___/                                    
                                     
                                Version 2.0
";

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(title);
                Console.ResetColor();


                new BimBot().StartAsync().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
