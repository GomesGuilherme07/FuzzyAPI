using FuzzyAPI.Models;
using FuzzyAPI.Services.Interface;
using FuzzySharp;
using FuzzySharp.Extractor;

namespace FuzzyAPI.Services
{
    public class FuzzyService: IFuzzyService
    {
        public object ExtractOne(FuzzyRequest request)
        {
            var resultFuzzy = Process.ExtractOne(request.UserInput, request.Menu, cutoff: request.Score);
            var fuzzyResponse = CreateObjetcFuzzyResponse(resultFuzzy);
           
            return fuzzyResponse;
        }

        public object CreateObjetcFuzzyResponse(ExtractedResult<string> resultFuzzy)
        {
            var fuzzyResponse = new FuzzyResponse();

            if (resultFuzzy != null)            {

                fuzzyResponse.MenuOption = resultFuzzy.Index.ToString();
                fuzzyResponse.MenuDescription = resultFuzzy.Value;
                fuzzyResponse.Score = resultFuzzy.Score;            
            }
            else
            {
                fuzzyResponse.MenuOption = string.Empty;
                fuzzyResponse.MenuDescription = string.Empty;
                fuzzyResponse.Score = 0;
            }          
            
            return fuzzyResponse;
        }
    }
}
