﻿using TelSearchApi;

namespace INQ.Inquisitor.App.Functional.Miners;

public static class PhoneNumberMiner
{
    /// <summary>
    /// Does not seem to match or know Dutch telephone numbers?
    /// </summary>
    public static async Task<TelSearchQueryResponse> Mine(
        string query,
        string language = "NL")
    {
        // https://tel.search.ch/api/help.en.html
        // https://github.com/psollberger/TelSearchApi
        var client = new TelSearchClient("be8e45356f57a7a3c6777470a0a65bb1");
        var lookupRequest = new TelSearchQuery(client)
        {
            Query = query,
            Language = language
        };

        return await lookupRequest.ExecuteAsync();
    }
}
