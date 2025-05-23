using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW;

class Program
{
    static async Task Main(string[] args)
    {
        using var client = new HttpClient();
        string result = await client.GetStringAsync("https://www.tabnak.ir/");
        string pattern1 = @"(?:src)\s*=\s*[""'](?<url>https?://[^""']+)[""']";
        aks(result, pattern1, "tab");


        async Task aks(string result,string pattern,string foldername )
        {
            Directory.CreateDirectory(foldername);
            foreach (Match match in Regex.Matches(result, pattern, RegexOptions.IgnoreCase))
            {
                try
                {
                    string url = match.Groups["url"].Value;
                    var bytes =client.GetByteArrayAsync(url).Result;
                    string filename = Path.GetFileName(url);
                    File.WriteAllBytes($"{foldername}/{filename}", bytes);
                    Console.WriteLine(filename + " => " + url);
                }
                catch (System.AggregateException ae)
                {
                    System.Console.WriteLine(ae.Message);
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        string pattern2 = @"(?:href)\s*=\s*[""'](?<url>https?://[^""']+)[""']";
        int n = 0;
        foreach (Match match in Regex.Matches(result, pattern2, RegexOptions.IgnoreCase))
        {
            try
            {
                string url = match.Groups["url"].Value;
                n++;
                //var bytes = client.GetByteArrayAsync(url).Result;
                //string filename = Path.GetFileName(url);

                //File.WriteAllBytes($"{foldername}/{filename}", bytes);
                //Console.WriteLine(filename + " => " + url);
                string result2 = await client.GetStringAsync(url);
                aks(result2, pattern1, $"url{n.ToString()}");
            }
            catch (System.AggregateException ae)
            {
                System.Console.WriteLine(ae.Message);
        
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
