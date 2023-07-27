using FuzzyAPI.Models;
using FuzzySharp.Extractor;

namespace FuzzyAPI.Services.Interface
{
    public interface IFuzzyService
    {
        object ExtractOne(FuzzyRequest request);

        object CreateObjetcFuzzyResponse(ExtractedResult<string> resultFuzzy);
    }
}
