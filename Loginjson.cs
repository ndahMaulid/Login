using System; //library yang menandakan penggunaan functin pada c#
using System.Text.Json; // library agar dapat membuat  fungsi serialisasi 
//serialisasi mengkonversi objek ke string

namespace Login
{
    public class inputClient
    {
        public string Username { get; set; } 
        public string Password { get; set; }

        //get dijalankan ketika username, password dari client terbaca 
        //set dijalankan ketika ada vale baru 
    }
    class Client
    {
        static void Main()
        {
            inputClient client = new inputClient();

            //client input username 
            Console.WriteLine("Username : ");
            client.Username = Console.ReadLine();

            //client input password  
            Console.WriteLine("Password : ");
            client.Password = Console.ReadLine();
           
            //membaca panjang karakter username yang diinputkan 
            Console.WriteLine("Panjang Username : ");
            Console.WriteLine(client.Username.Length);

            //membaca panjang karakter password yang diinputkan 
            Console.WriteLine("Panjang Password : ");
            Console.WriteLine(client.Password.Length);
            
            //mengkonversi object inputan dari client menjadi string 
            string jsonString = JsonSerializer.Serialize(client);
            Console.WriteLine(jsonString);
            Console.ReadLine();
        }
    }
}