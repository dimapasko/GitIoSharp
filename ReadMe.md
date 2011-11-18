C# wrapper for Git.io: GitHub URL Shortener 
====================

Usage
-----

    var gitIo = new GitIo();

    // Pass a direct URL and get back a random URL
    gitIo.Shorten(new Uri("http://github.com/dimapasko"));

    // Pass an optional key to get the URL of your request
    gitIo.Shorten(new Uri("https://github.com/csharpus"), "csharpus");