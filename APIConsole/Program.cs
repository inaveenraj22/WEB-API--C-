using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APIConsole
{
    class Program
    {
        public  static void Main(string[] args)
        {
            // HttpContent
            Show();
            
        }

        async static void Show()
        {
            var client = new HttpClient();
            var url1 = new Uri("http://dummy.restapiexample.com/api/v1/employees");
            var url = new Uri("https://jsonplaceholder.typicode.com/users");
            try 
            {
                var response = client.GetAsync(url).Result;
                Task.WaitAll();
                //var data = JsonConvert.DeserializeObject(); ;

                
                var data = 
                    response.Content.ReadAsAsync<List<Person>>().Result;


                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
            



        }





    }
}
