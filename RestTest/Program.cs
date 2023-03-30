using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpicorRestAPI;
namespace RestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EpicorRest.AppPoolHost = "Your.TLD.Com";
            EpicorRest.AppPoolInstance = "YourEpicorInstance";
            EpicorRest.APIKey = "YourAPIKey";
            EpicorRest.UserName = "YourUserName";
            EpicorRest.Password = "YourPassword";
            EpicorRest.Company = "YourCompanyID";
            EpicorRest.APIVersion = EpicorRestVersion.V2;
            var dic = new Dictionary<string, string>();
            dic.Add("$filter", "PartNum eq '10003'");
            var x = EpicorRest.BoGet("Erp.BO.PartRevSearchSvc", "PartRevSearches",dic);
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(x.ResponseData));
            Console.ReadLine();

        }
    }
}
