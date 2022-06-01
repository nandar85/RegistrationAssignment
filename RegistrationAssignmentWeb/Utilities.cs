using RegistrationAssignmentWeb.Model;
using System.Net.Http.Headers;

namespace RegistrationAssignmentWeb
{
    public class Utilities
    {
        public IEnumerable<CategoryViewModel> APICall()
        {
            string URL = "https://betaapi.eon-xr.com/External/GetDemoLibraryCategories";
            string urlParameters = "?avrDemoId=2";

            using (HttpClient client = new HttpClient())
            {
                //var obj = new {  avrDemoId: 2};
                client.BaseAddress = new Uri(URL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                HttpResponseMessage response = client.PostAsJsonAsync(URL + urlParameters, new ParamObj() { avrDemoId = 2 }).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var dataObjects = response.Content.ReadAsAsync<IEnumerable<CategoryViewModel>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                    return dataObjects;
                }
                else
                {
                    return null;
                }
            }
            //Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.            
        }
    }
}
