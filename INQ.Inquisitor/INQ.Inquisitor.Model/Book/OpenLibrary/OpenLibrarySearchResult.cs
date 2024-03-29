﻿using Newtonsoft.Json;

namespace INQ.Inquisitor.Model.Book.OpenLibrary;

public class OpenLibrarySearchResult
{
    [JsonProperty("docs")]
    public List<OpenLibraryBook> Docs { get; set; }
}

